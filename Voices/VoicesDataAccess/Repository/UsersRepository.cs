using System;
using System.Collections.Generic;
using System.Text;
using Domain.Interfaces;
using DataAccess.Models;
using Microsoft.Extensions.Logging;
using VoicesDataAccess.Logic;

namespace Domain.Repository
{
    public class UsersRepository : IUsersRepository
    {
        private readonly VoicesContext _ctx;
        private readonly ILogger<VoicesContext> _logger;
        public UsersRepository(VoicesContext context, ILogger<VoicesContext> logger)
        {
            _ctx = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public void AddUser(Models.Users user)
        {
            if (user.UserId != 0)
            {
                _logger.LogWarning("Users to be added has an ID ({UserId}) already: ignoring.", user.UserId);
            }

            _logger.LogInformation("Adding User");

            Users entity = Mapper.MapUsersDataAccess(user);
            entity.UserId = 0;
            _ctx.Add(entity);
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
            _logger.LogInformation("Saving changes to the database");
            _ctx.SaveChanges();
        }

        public void UpdateUser(Models.Users user)
        {
            throw new NotImplementedException();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~UsersRepository()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
