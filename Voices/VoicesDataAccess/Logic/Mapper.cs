using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace VoicesDataAccess.Logic
{
    public class Mapper
    {
        /// <summary>
        /// Mapping the Data Access "PostData" to the Domain "PostData"
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
        public static DataAccess.Models.PostData MapPostsDataAccess(Domain.Models.PostData post)
        {
            return new DataAccess.Models.PostData
            {
                PostId = post.PostID, 
                Title = post.Title,
                Comment = post.Comment,
                Media = post.Media,
                Rating = post.Rating
            };
        }

        /// <summary>
        /// Mapping the Domain "PostData" to the Data Access "PostData" 
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
        public static Domain.Models.PostData MapPostsDomain(DataAccess.Models.PostData post)
        {
            return new Domain.Models.PostData
            {
                PostID = post.PostId,
                UserID = post.Users.Select(p => p.UserId).FirstOrDefault(),
                Title = post.Title,
                Media = post.Media,
                Rating = post.Rating
            };
        }

        /// <summary>
        /// Maps the Data Access "User" to the Domain "User"
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static DataAccess.Models.Users MapUsersDataAccess(Domain.Models.Users user)
        {
            return new DataAccess.Models.Users
            {
                UserId = user.UserId,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.Username,
                Email = user.Email,
                Password = user.Password,
                ProfilePic = user.ProfilePicture.Select(pic => pic.PictureId).FirstOrDefault(),
                Posts = user.Post.Select(post => post.PostID).FirstOrDefault()
            };
        }

        /// <summary>
        /// Maps the Domain "User" to the Data Access "User"
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static Domain.Models.Users MapUsersDomain(DataAccess.Models.Users user)
        {
            return new Domain.Models.Users
            {
                UserId = user.UserId,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.Username,
                Email = user.Email,
                Password = user.Password,
                ProfilePic = user.ProfilePic
            };
        }
    }
}
