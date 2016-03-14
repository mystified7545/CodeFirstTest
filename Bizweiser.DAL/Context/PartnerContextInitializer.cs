using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.Entity;

namespace Bizweiser.DAL
{
    public class PartnerContextInitializer: System.Data.Entity.DropCreateDatabaseAlways<PartnerContext>
    {

        public PartnerContextInitializer()
        {
            
        }
        protected override void Seed(PartnerContext context)
        {
            context.Users.Add(new User { Id = 1, UserName = "admin", Password = "admin", SecurityQuestion = "admin", SecurityAnswer = "admin" });
            base.Seed(context);
            
        }
    }

    
}