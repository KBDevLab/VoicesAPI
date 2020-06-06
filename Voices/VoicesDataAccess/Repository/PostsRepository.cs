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
    }
}
