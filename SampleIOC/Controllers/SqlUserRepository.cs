using Microsoft.Owin.Logging;
using SampleIOC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleIOC.Controllers
{
    public class SqlUserRepository : IUserRepository
    {
        private readonly ILogger logger;

        // Use constructor injection for the dependencies
        public SqlUserRepository(ILogger logger)
        {
            this.logger = logger;
        }

        public User GetById(Guid id)
        {
            //this.logger.Log("Getting User " + id);
            // retrieve from db.
            return null;
        }

        List<UserModel> IUserRepository.GetAll()
        {
            List<UserModel> Users = new List<Models.UserModel>()
            {
                new UserModel() {FirstName = "From", LastName = "The"},
                new UserModel() {FirstName = "Controller", LastName = "Object" }
            };
            return Users;
        }
    }
}