using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

using System.Data.Entity;
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using Bizweiser.DAL;

namespace Bizweiser
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            PartnerContext partnerContext = new PartnerContext();

            //Database.SetInitializer(new DropCreateDatabaseAlways<PartnerContext>());
            //using (var db = new PartnerContext()) //initializer won't be called here
            //{

            //    db.Users.Add(new User { Id = 1, UserName = "admin", Password = "admin", SecurityQuestion = "admin", SecurityAnswer = "admin" }); //initializer will be called here
            //    db.SaveChanges();
            //}
            
        }
    }
}
