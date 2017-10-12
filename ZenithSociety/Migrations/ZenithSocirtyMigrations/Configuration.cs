namespace ZenithSociety.Migrations.ZenithSocirtyMigrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ZenithSociety.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ZenithSociety.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\ZenithSocirtyMigrations";
        }

        protected override void Seed(ZenithSociety.Models.ApplicationDbContext context)
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            if (!roleManager.RoleExists("Admin"))
                roleManager.Create(new IdentityRole("Admin"));

            if (!roleManager.RoleExists("Member"))
                roleManager.Create(new IdentityRole("Member"));

            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            string[] emails = { "a@a.a", "m@m.m" };
            string[] userNames = { "a", "m" };

            if (userManager.FindByEmail(emails[0]) == null)
            {
                var user = new ApplicationUser
                {
                    Email = emails[0],
                    UserName = userNames[0],
                };
                var result = userManager.Create(user, "P@$$w0rd");
                if (result.Succeeded)
                    userManager.AddToRole(userManager.FindByEmail(user.Email).Id, "Admin");
            }
            if (userManager.FindByEmail(emails[1]) == null)
            {
                var user = new ApplicationUser
                {
                    Email = emails[1],
                    UserName = userNames[1],
                };
                var result = userManager.Create(user, "P@$$w0rd");
                if (result.Succeeded)
                    userManager.AddToRole(userManager.FindByEmail(user.Email).Id, "Member");
            }

            // Seed data for ActivityCategory
            List<ActivityCategory> ActivityCategories = new List<ActivityCategory>() {
                 new ActivityCategory {
                        ActivityDescription="Senior’s Golf Tournament",
                        CreationDate =  new DateTime(2017, 10, 5, 1, 00, 0)
                    },
                 new ActivityCategory {
                        ActivityDescription="Leadership General Assembly Meeting",
                        CreationDate =  new DateTime(2017, 10, 5, 1, 00, 0)
                    },
                 new ActivityCategory {
                        ActivityDescription="Youth Bowling Tournament",
                        CreationDate =  new DateTime(2017, 10, 5, 1, 00, 0)
                    },
                 new ActivityCategory {
                        ActivityDescription="Young ladies cooking lessons",
                        CreationDate =  new DateTime(2017, 9, 8, 1, 00, 0)
                    },
                 new ActivityCategory {
                        ActivityDescription="Youth craft lessons",
                        CreationDate =  new DateTime(2017, 9, 9, 3, 15, 0)
                    },
                 new ActivityCategory {
                        ActivityDescription="Lunch",
                        CreationDate =  new DateTime(2017, 9, 9, 3, 15, 0)
                    },
                 new ActivityCategory {
                        ActivityDescription="Pancake Breakfast",
                        CreationDate =  new DateTime(2017, 9, 9, 3, 15, 0)
                    },
                 new ActivityCategory {
                        ActivityDescription="Swimming Lessons for the youth",
                        CreationDate =  new DateTime(2017, 9, 9, 3, 15, 0)
                    },
                 new ActivityCategory {
                        ActivityDescription="Swimming Exercise for parents",
                        CreationDate =  new DateTime(2017, 9, 9, 3, 15, 0)
                    },
                 new ActivityCategory {
                        ActivityDescription="Bingo Tournament",
                        CreationDate =  new DateTime(2017, 9, 9, 3, 15, 0)
                    },
                 new ActivityCategory {
                        ActivityDescription="BBQ Lunch",
                        CreationDate =  new DateTime(2017, 9, 9, 3, 15, 0)
                    },
                  new ActivityCategory {
                        ActivityDescription="Garage Sale",
                        CreationDate =  new DateTime(2017, 9, 9, 3, 15, 0)
                    },
                };

            context.ActivityCategories.AddOrUpdate(
              a => a.ActivityCategoryId,
              ActivityCategories.ToArray()
            );


        }
    }
}
