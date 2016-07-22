
using System.Collections.Generic;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using TBlogService;
using TBlogService.Models;

namespace TBlogServiceTests
{
   [TestClass]
   public class BlogServiceTest
   {
      [TestMethod]
      public void GetBlogs_LessThanPageSizeBlogs_ReturnsAllBlogs()
      {
         BlogService target = new BlogService( new DummyBlogRepository() );

         IEnumerable<Blog> actual = target.GetBlogs();

         Assert.AreEqual( 2, actual.Count() );
      }
   }
}
