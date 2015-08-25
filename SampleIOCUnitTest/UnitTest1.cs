using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleIOC;
using SampleIOC.Controllers;
using SampleIOC.Models;
using SampleIOC.Logging;

namespace SampleIOCUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetAllUsers()
        {
            IUserRepository repository = new UserRepositoryUnitTest();
            ILogging logger = new MailLoggerUnitTest();
            UserController user = new UserController(repository, logger);
        }
    }
}
