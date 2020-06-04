using System;
using System.Collections.Generic;
using System.Text;
using VoicesDomain.Models;

namespace VoicesDataAccess.Logic
{
    public class Mapper
    {
        public static PostData MapUsersWithPosts(PostData post)
        {
            return new PostData
            {
                PostID = post.PostID,
                UserID = post.UserID,
                Title = post.Title,
                Comment = post.Comment,
                Media = post.Media,
                Rating = post.Rating
            };
        }

    }
}
