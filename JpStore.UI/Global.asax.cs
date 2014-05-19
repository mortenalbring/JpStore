using JpStore.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using StructureMap;
using JpStore.Controllers;

namespace JpStore.UI
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            Database.SetInitializer(new InitializeDB());
            //Database.SetInitializer<SharePeepsDB>(new DropCreateDatabaseIfModelChanges<SharePeepsDB>());
            BootStrapper.ConfigureDependecies();
            ControllerBuilder.Current.SetControllerFactory(new IoCControllerFactory());


            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}