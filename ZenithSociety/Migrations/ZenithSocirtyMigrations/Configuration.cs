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

            context.Events.AddOrUpdate(
              e => e.EventId,
              new Event()
              {
                  EventId = 1
                  ,
                  EventFromDate = new DateTime(2017, 9, 9, 3, 15, 0)
                  ,
                  EventToDate = new DateTime(2017, 9, 9, 5, 30, 0)
                  ,
                  EnteredUserName = "a"
                  ,
                  CreationDate = new DateTime(2017, 9, 1, 5, 30, 0)
                  ,
                  IsActive = true
                  ,
                  ActivityCategoryId = 1

              },
              new Event()
              {
                  EventId = 2
                  ,
                  EventFromDate = new DateTime(2017, 10, 9, 8, 15, 0)
                  ,
                  EventToDate = new DateTime(2017, 10, 9, 11, 30, 0)
                  ,
                  EnteredUserName = "a"
                  ,
                  CreationDate = new DateTime(2017, 9, 15, 10, 30, 0)
                  ,
                  IsActive = true
                  ,
                  ActivityCategoryId = 3

              },
              new Event()
              {
                  EventId = 3
                  ,
                  EventFromDate = new DateTime(2017, 10, 9, 12, 15, 0)
                  ,
                  EventToDate = new DateTime(2017, 10, 9, 15, 30, 0)
                  ,
                  EnteredUserName = "a"
                  ,
                  CreationDate = new DateTime(2017, 9, 15, 10, 30, 0)
                  ,
                  IsActive = true
                  ,
                  ActivityCategoryId = 2

              },
              new Event()
              {
                  EventId = 4
                  ,
                  EventFromDate = new DateTime(2017, 10, 10, 8, 15, 0)
                  ,
                  EventToDate = new DateTime(2017, 10, 10, 11, 30, 0)
                  ,
                  EnteredUserName = "a"
                  ,
                  CreationDate = new DateTime(2017, 9, 15, 10, 30, 0)
                  ,
                  IsActive = true
                  ,
                  ActivityCategoryId = 5

              },
              new Event()
              {
                  EventId = 5
                  ,
                  EventFromDate = new DateTime(2017, 10, 10, 18, 15, 0)
                  ,
                  EventToDate = new DateTime(2017, 10, 10, 19, 30, 0)
                  ,
                  EnteredUserName = "a"
                  ,
                  CreationDate = new DateTime(2017, 9, 15, 10, 30, 0)
                  ,
                  IsActive = true
                  ,
                  ActivityCategoryId = 3

              },
              new Event()
              {
                  EventId = 6
                  ,
                  EventFromDate = new DateTime(2017, 10, 10, 13, 15, 0)
                  ,
                  EventToDate = new DateTime(2017, 10, 10, 15, 30, 0)
                  ,
                  EnteredUserName = "a"
                  ,
                  CreationDate = new DateTime(2017, 9, 15, 10, 30, 0)
                  ,
                  IsActive = true
                  ,
                  ActivityCategoryId = 7

              },
              new Event()
              {
                  EventId = 7
                  ,
                  EventFromDate = new DateTime(2017, 10, 10, 16, 15, 0)
                  ,
                  EventToDate = new DateTime(2017, 10, 10, 17, 30, 0)
                  ,
                  EnteredUserName = "a"
                  ,
                  CreationDate = new DateTime(2017, 9, 15, 10, 30, 0)
                  ,
                  IsActive = true
                  ,
                  ActivityCategoryId = 7

              },
              new Event()
              {
                  EventId = 8
                  ,
                  EventFromDate = new DateTime(2017, 10, 11, 18, 15, 0)
                  ,
                  EventToDate = new DateTime(2017, 10, 11, 17, 30, 0)
                  ,
                  EnteredUserName = "a"
                  ,
                  CreationDate = new DateTime(2017, 9, 15, 10, 30, 0)
                  ,
                  IsActive = true
                  ,
                  ActivityCategoryId = 2

              },
              new Event()
              {
                  EventId = 9
                  ,
                  EventFromDate = new DateTime(2017, 10, 11, 8, 15, 0)
                  ,
                  EventToDate = new DateTime(2017, 10, 11, 10, 30, 0)
                  ,
                  EnteredUserName = "a"
                  ,
                  CreationDate = new DateTime(2017, 9, 15, 10, 30, 0)
                  ,
                  IsActive = true
                  ,
                  ActivityCategoryId = 8

              },
              new Event()
              {
                  EventId = 10
                  ,
                  EventFromDate = new DateTime(2017, 10, 12, 18, 15, 0)
                  ,
                  EventToDate = new DateTime(2017, 10, 12, 17, 30, 0)
                  ,
                  EnteredUserName = "a"
                  ,
                  CreationDate = new DateTime(2017, 9, 15, 10, 30, 0)
                  ,
                  IsActive = true
                  ,
                  ActivityCategoryId = 4

              },
              new Event()
              {
                  EventId = 11
                  ,
                  EventFromDate = new DateTime(2017, 10, 13, 18, 15, 0)
                  ,
                  EventToDate = new DateTime(2017, 10, 13, 17, 30, 0)
                  ,
                  EnteredUserName = "a"
                  ,
                  CreationDate = new DateTime(2017, 9, 15, 10, 30, 0)
                  ,
                  IsActive = true
                  ,
                  ActivityCategoryId = 6

              },
              new Event()
              {
                  EventId = 12
                  ,
                  EventFromDate = new DateTime(2017, 10, 14, 18, 15, 0)
                  ,
                  EventToDate = new DateTime(2017, 10, 14, 17, 30, 0)
                  ,
                  EnteredUserName = "a"
                  ,
                  CreationDate = new DateTime(2017, 9, 15, 10, 30, 0)
                  ,
                  IsActive = true
                  ,
                  ActivityCategoryId = 3

              },
              new Event()
              {
                  EventId = 13
                  ,
                  EventFromDate = new DateTime(2017, 10, 15, 18, 15, 0)
                  ,
                  EventToDate = new DateTime(2017, 10, 15, 17, 30, 0)
                  ,
                  EnteredUserName = "a"
                  ,
                  CreationDate = new DateTime(2017, 9, 15, 10, 30, 0)
                  ,
                  IsActive = true
                  ,
                  ActivityCategoryId = 1

              },
              new Event()
              {
                  EventId = 14
                  ,
                  EventFromDate = new DateTime(2017, 9, 8, 3, 15, 0)
                  ,
                  EventToDate = new DateTime(2017, 9, 8, 5, 30, 0)
                  ,
                  EnteredUserName = "a"
                  ,
                  CreationDate = new DateTime(2017, 9, 1, 5, 30, 0)
                  ,
                  IsActive = true
                  ,
                  ActivityCategoryId = 9

              },
              new Event()
              {
                  EventId = 15
                  ,
                  EventFromDate = new DateTime(2017, 9, 16, 3, 15, 0)
                  ,
                  EventToDate = new DateTime(2017, 9, 16, 5, 30, 0)
                  ,
                  EnteredUserName = "a"
                  ,
                  CreationDate = new DateTime(2017, 9, 1, 5, 30, 0)
                  ,
                  IsActive = true
                  ,
                  ActivityCategoryId = 10

              }
            );


        }
    }
}
