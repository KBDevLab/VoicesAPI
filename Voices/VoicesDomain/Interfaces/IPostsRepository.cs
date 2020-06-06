using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;

namespace VoicesDataAccess.Interfaces
{
    public interface IPostsRepository
    {
        IEnumerable<PostData> GetAll();
        PostData GetPostByID(int postID);
        void AddPost(PostData post);
        void UpdatePost(PostData post);
        void RemovePost(int postID);
        void Save();
    }
}
