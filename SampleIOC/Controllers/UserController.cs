using Microsoft.Owin.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleIOC.Logging;

namespace SampleIOC.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository repository;
        private readonly ILogging logger;

        // Use constructor injection for the dependencies
        public UserController(IUserRepository repository, ILogging logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        // implement UserController methods here:
        public ActionResult Index()
        {
            //this.logger.Log("Index called");
            return View(this.repository.GetAll());
        }
    }
}