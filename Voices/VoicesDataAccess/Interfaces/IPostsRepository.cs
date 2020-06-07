using DataAccess.Models;
using System;
using System.Collections.Generic;

namespace VoicesDataAccess.Interfaces
{
    public interface IPostsRepository : IDisposable
    {
        IEnumerable<PostData> GetAll();
        PostData GetPostByID(int postID);
        void AddPost(PostData post);
        void UpdatePost(PostData post);
        void RemovePost(int postID);
        void Save();
    }
}
