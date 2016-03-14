using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;


 namespace Bizweiser.DAL
 {
    public class PartnerContext:DbContext
    {
        #region Constructors
        public PartnerContext()
            : base("PartnerContext")
        {
            try
            {
                PartnerContextInitializer dbInitializer = new PartnerContextInitializer();
                Database.SetInitializer<PartnerContext>(dbInitializer);
                Database.Initialize(true);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

   


        }
        #endregion

        #region members
        public DbSet<User> Users { get; set; }
        //public DbSet<Partner> Partners { get; set; }

        #endregion

        #region Events
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        #endregion

    }
}