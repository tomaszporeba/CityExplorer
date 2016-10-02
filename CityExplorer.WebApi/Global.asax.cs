﻿using CityExplorer.WebApi.App_Start;
using System.Web.Http;
using System.Web.Routing;

namespace CityExplorer.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //NinjectHttpContainer.RegisterModules(NinjectHttpModules.Modules);
           // NinjectHttpContainer.RegisterAssembly();

        }
    }
}
