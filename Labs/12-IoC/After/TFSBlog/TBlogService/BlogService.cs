
using System.Collections.Generic;
// using System.Configuration;

using Microsoft.Practices.Unity;

using Audit;
using IoC;
using TBlogService.Models;
using TFSBlogRepository;

namespace TBlogService
{
   public class BlogService : IBlogService
   {
      private IBlogRepository repository;
      private IAudit audit;

      // public BlogService() : this( new BlogRepository(
      //       ConfigurationManager.ConnectionStrings[ "TFSBlogEntities" ].ConnectionString ) )
      // {
      //    //
      // }

      public BlogService() : this(
         Container.Instance.Resolve<IBlogRepository>(),
         Container.Instance.Resolve<IAudit>() )
      {
         //
      }

      public BlogService( IBlogRepository repository, IAudit audit )
      {
         this.repository = repository;
         this.audit = audit;
      }

      public IEnumerable<Blog> GetBlogs()
      {
         // string connectionString =
         //    ConfigurationManager.ConnectionStrings[ "TFSBlogEntities" ].ConnectionString;
         // IBlogRepository repository = new BlogRepository( connectionString );

         // Blogs blogFactory = new Blogs();
         // IEnumerable<Blog> blogs = blogFactory.GetBlogs( this.repository, 10, 1 );

         Blogs blogFactory = new Blogs();
         IEnumerable<Blog> blogs;
         try
         {
            blogs = blogFactory.GetBlogs( this.repository, 10, 1 );
         }
         catch
         {
            throw new ServiceException();
         }

         if ( this.audit != null )
            this.audit.Message( "GetBlogs" );

         return blogs;
      }
   }
}
