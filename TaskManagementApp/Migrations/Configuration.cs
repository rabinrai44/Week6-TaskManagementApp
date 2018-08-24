namespace TaskManagementApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using TaskManagementApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TaskManagementApp.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TaskManagementApp.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            AddUsers(context);
        }

        //creating user by default (seed)
        void AddUsers(TaskManagementApp.Models.ApplicationDbContext context)
        {
            var user = new ApplicationUser { UserName = "user1@email.com" };
            var userManager = new UserManager<ApplicationUser>(
                    new UserStore<ApplicationUser>(context));
            userManager.Create(user, "password");
        }
    }
}
