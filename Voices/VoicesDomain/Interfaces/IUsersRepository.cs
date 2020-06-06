using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;

namespace Domain.Interfaces
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
