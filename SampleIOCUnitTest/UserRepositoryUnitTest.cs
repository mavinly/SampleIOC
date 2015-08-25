using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleIOC.Controllers;
using SampleIOC.Models;

namespace SampleIOCUnitTest
{
    class UserRepositoryUnitTest : IUserRepository
    {
        public List<UserModel> GetAll()
        {
            List<UserModel> Users = new List<UserModel>()
            {
                new UserModel() {FirstName = "From", LastName = "The"},
                new UserModel() {FirstName = "Unit", LastName = "Test" }
            };
            return Users;
        }
    }
}
