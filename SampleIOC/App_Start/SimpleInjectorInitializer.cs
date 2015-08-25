[assembly: WebActivator.PostApplicationStartMethod(typeof(SampleIOC.App_Start.SimpleInjectorInitializer), "Initialize")]

namespace SampleIOC.App_Start
{
    using System.Reflection;
    using System.Web.Mvc;

    using SimpleInjector;
    using SimpleInjector.Extensions;
    using SimpleInjector.Integration.Web;
    using SimpleInjector.Integration.Web.Mvc;
    using Controllers;
    using Microsoft.Owin.Logging;

    public static class SimpleInjectorInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            //var container = new Container();
            //container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            
            //InitializeContainer(container);

            //container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            
            //container.Verify();
            
            //DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));

            // 1. Create a new Simple Injector container
            var container = new Container();

            // 2. Configure the container (register)
            container.Register<IUserRepository, SqlUserRepository>(Lifestyle.Transient);

            container.Register<SampleIOC.Logging.ILogging, MailLogger>(Lifestyle.Singleton);

            // 3. Optionally verify the container's configuration.
            container.Verify();

            // 4. Register the container as MVC3 IDependencyResolver.
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
     
        private static void InitializeContainer(Container container)
        {

            // For instance:
            // container.Register<IUserRepository, SqlUserRepository>(Lifestyle.Scoped);
        }
    }
}