
using System;
using System.Collections.Generic;
using System.Linq;

using BlogModel;
using TFSBlogRepository;

namespace TBlogServiceTests
{
   public class DummyBlogRepository : IBlogRepository
   {
      #region IBlogRepository Members

      public IQueryable<Blog> GetBlogPosts( int id )
      {
         throw new NotImplementedException();
      }

      public IQueryable<Blog> GetBlogs()
      {
         return new List<Blog>
            {
               new Blog { User = new User { Name = "Tony"  } },
               new Blog { User = new User { Name = "Brock" } }
            }
            .AsQueryable();
      }

      #endregion

      #region IRepository<Blog> Members

      public IQueryable<Blog> Entities
      {
         get
         {
            throw new NotImplementedException();
         }
      }

      public Blog New()
      {
         throw new NotImplementedException();
      }

      public void Add( Blog entity )
      {
         throw new NotImplementedException();
      }

      public void Create( Blog entity )
      {
         throw new NotImplementedException();
      }

      public void Delete( Blog entity )
      {
         throw new NotImplementedException();
      }

      public void Save()
      {
         throw new NotImplementedException();
      }

      #endregion

      #region IDisposable Members

      public void Dispose()
      {
         throw new NotImplementedException();
      }

      #endregion
   }
}
