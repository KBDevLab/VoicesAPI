using DataAccess.Models;
using System;
using System.Collections.Generic;

namespace VoicesDataAccess.Interfaces
{
    public interface IUsersRepository : IDisposable
    {
        IEnumerable<Users> GetAll();
        Users GetUserByID(int userID);
        void AddUser(Users user);
        void UpdateUser(Users user);
        void DeleteUser(int userID);
        void Save();

    }
}
