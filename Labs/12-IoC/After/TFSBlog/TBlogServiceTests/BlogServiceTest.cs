
using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;

using Audit;
using TBlogService;
using TBlogService.Models;
using TFSBlogRepository;

namespace TBlogServiceTests
{
   [TestClass]
   public class BlogServiceTest
   {
      private Mock<IBlogRepository> blogRepository;

      [TestInitialize]
      public void TestInitialize()
      {
         this.blogRepository = new Mock<IBlogRepository>();
      }

      [TestMethod]
      public void GetBlogs_LessThanPageSizeBlogs_ReturnsAllBlogs()
      {
         IQueryable<BlogModel.Blog> blogs = new List<BlogModel.Blog>
            {
               new BlogModel.Blog { User = new BlogModel.User { Name = "Cal"     } },
               new BlogModel.Blog { User = new BlogModel.User { Name = "Michael" } }
            }
            .AsQueryable();

         this.blogRepository.Setup( b => b.GetBlogs() ).Returns( blogs );

         BlogService target = new BlogService( this.blogRepository.Object, null );

         IEnumerable<Blog> actual = target.GetBlogs();

         Assert.AreEqual( 2, actual.Count() );
      }

      [TestMethod]
      [ExpectedException( typeof( ServiceException ) )]
      public void GetBlogs_NullRepository_ThrowsException()
      {
         this.blogRepository.Setup(
            b => b.GetBlogs() ).Returns<IQueryable<BlogModel.Blog>>( null );

         BlogService target = new BlogService( this.blogRepository.Object, null );

         IEnumerable<Blog> actual = target.GetBlogs();

         Assert.AreEqual( 2, actual.Count() );
      }

      [TestMethod]
      [ExpectedException( typeof( ServiceException ) )]
      public void GetBlogs_ExceptionRaised_ThrowsServiceException()
      {
         this.blogRepository.Setup(
            b => b.GetBlogs() ).Throws( new NullReferenceException() );

         BlogService target = new BlogService( this.blogRepository.Object, null );

         IEnumerable<Blog> actual = target.GetBlogs();

         Assert.AreEqual( 2, actual.Count() );
      }

      [TestMethod]
      public void GetBlogs_IAuditNotNull_MessageCalled()
      {
         Mock<IAudit> audit = new Mock<IAudit>();

         BlogService target = new BlogService( this.blogRepository.Object, audit.Object );

         target.GetBlogs();

         audit.Verify( a => a.Message( "GetBlogs" ), Times.Once() );
         this.blogRepository.Verify( b => b.GetBlogs(), Times.Once() );
      }
   }
}
