using System;
using System.Collections.Generic;
using System.Text;
using VoicesDomain.Models;

namespace VoicesDomain.Interfaces
{
    public interface IUsersRepository
    {
        IEnumerable<Users> GetAll();
        Users GetUserByID(int userID);
        void AddUser(Users user);
        void UpdateUser(Users user);
        void DeleteUser(int userID);
        void Save();

    }
}
