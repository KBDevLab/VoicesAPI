using System;
using System.Collections.Generic;
using System.Text;
using VoicesDomain.Interfaces;
using VoicesWebUI.Entities;

namespace VoicesDomain.Repository
{
    public class UsersRepository : IUsersRepository
    {
        private VoicesContext _ctx;
        public UsersRepository(VoicesContext context)
        {
            this._ctx = context;
        }

        public void AddUser(Models.Users user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int userID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Models.Users> GetAll()
        {
            throw new NotImplementedException();
        }

        public Models.Users GetUserByID(int userID)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(Models.Users user)
        {
            throw new NotImplementedException();
        }
    }
}
