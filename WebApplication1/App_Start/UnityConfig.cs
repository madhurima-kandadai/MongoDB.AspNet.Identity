using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.Practices.Unity;
using MongoDB.AspNet.Identity;
using Unity.Mvc5;
using WebApplication11.Controllers;
using WebApplication11.Models;

namespace WebApplication11
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<AccountController>(new InjectionConstructor());
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}