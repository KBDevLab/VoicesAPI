using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VoicesDataAccess.Interfaces;
using Domain.Models;
using DataAccess.Models;

namespace VoicesDataAccess.Repository
{
    public class PostsRepository : IPostsRepository
    {
        private readonly VoicesContext _ctx;
        private readonly ILogger<PostsRepository> _logger;
        public PostsRepository(VoicesContext context)
        {
            this._ctx = context;
        }
        public void AddPost(Domain.Models.PostData post)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Domain.Models.PostData> GetAll()
        {
            throw new NotImplementedException();
        }

        public Domain.Models.PostData GetPostByID(int postID)
        {
            throw new NotImplementedException();
        }

        public void RemovePost(int postID)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdatePost(Domain.Models.PostData post)
        {
            throw new NotImplementedException();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~PostsRepository()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
