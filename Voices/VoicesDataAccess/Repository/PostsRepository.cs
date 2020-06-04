using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VoicesDataAccess.Interfaces;
using VoicesDomain.Models;
using VoicesWebUI.Entities;

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
        public void AddPost(VoicesDomain.Models.PostData post)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VoicesDomain.Models.PostData> GetAll()
        {
            throw new NotImplementedException();
        }

        public VoicesDomain.Models.PostData GetPostByID(int postID)
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

        public void UpdatePost(VoicesDomain.Models.PostData post)
        {
            throw new NotImplementedException();
        }
    }
}
