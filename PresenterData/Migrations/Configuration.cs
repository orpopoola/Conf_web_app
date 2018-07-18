namespace PresenterData.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using PresenterData.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Security;

    internal sealed class Configuration : DbMigrationsConfiguration<PresenterData.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PresenterData.Models.ApplicationDbContext context)
        {
            var presenter = new List<Presenter>
            {
                new Presenter(){StudentName = "Roosevelt  Reed  ", PaperTitle="NEW-BURN-CUT-BLAST-DESIGN-IN-DRIVES-ENHANCES-DRILLING-BLASTING-EFFICIENCY-WITH-ECONOMY-A-CASE-STUDY", PaperId=1, SessionId="1", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Brice  Basil  ", PaperTitle="Priming of Explosives", PaperId=2, SessionId="1", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Yetta  Alfonso  ", PaperTitle="SUSTAINABLE AGGREGATE PRODUCTION – ADOPTING IMPROVED EXTRACTIVE PROCESS FOR REDUCTION OF FINE GENERATION", PaperId=3, SessionId="1", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Meryl  Johnie  ", PaperTitle="DESIGN AND OPERATIONAL CONSIDERATIONS OF HARD ROCK AGGREGATE QUARRIES", PaperId=4, SessionId="1", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Maribeth  Silas  ", PaperTitle="ROCK BREAKAGE AND BLAST DESIGN CONSIDERATIONS IN OPENPIT", PaperId=5, SessionId="1", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Janelle  Arturo  ", PaperTitle="Cost effective new formulation of ANFO by using Biomass Briquette as Additive", PaperId=6, SessionId="1", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Tarsha  Lynwood  ", PaperTitle="APPRAISAL OF EXPLOSIVE PERFORMANCE BY MEASUREMENT OF VELOCITY OF DETONATION (VOD) IN MINES – DISCUSSION", PaperId=7, SessionId="2", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Gayle  Grady  ", PaperTitle="MEASUREMENT WHILE DRILLING (MWD) AND IMAGE ANALYSIS SYSTEMS: Today’s Most Useful and Cost-effective Tools for Mining Industry", PaperId=8, SessionId="2", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Sharice  Bennie  ", PaperTitle="EMPIRICAL EQUATIONS SUPPORTING BLAST DESIGNSt", PaperId=9, SessionId="2", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Rozella  Jon  ", PaperTitle="HANDLING OF MISFIRES IN MINES", PaperId=10, SessionId="2", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Rochell  Eddy  ", PaperTitle="GROUND CONTROL IN OPEN PIT MINES", PaperId=11, SessionId="2", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Mireya  Jarrod  ", PaperTitle="SAFE STORAGE OF AMMONIUM NITRATE", PaperId=12, SessionId="2", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Hassan  Paris  ", PaperTitle="CHALLENGES IN MINE PLANNING AND SCHEDULING – DISCUSSION", PaperId=13, SessionId="3", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Maryetta  Jody  ", PaperTitle="Cost Reduction in Mining Operations – Discussion", PaperId=14, SessionId="3", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Refugia  Simon  ", PaperTitle="MINING SOFTWARE SYSTEM OPTIMIZES MINE OPERATION, SAFETY AND ENHANCES OVERALL COST-EFFECTIVENESS & PRODUCTIVITY", PaperId=15, SessionId="3", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Danyell  Horacio  ", PaperTitle="MINING AND INDUSTRIAL DUST, AIR POLLUTION AND RELATED OCCUPATIONAL DISEASES", PaperId=16, SessionId="3", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Madalyn  Herbert  ", PaperTitle="MINE PLANNING AND SCHEDULING – SMART PRACTICES", PaperId=17, SessionId="3", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Wilfred  Robbie  ", PaperTitle="Blasting in High Production UG Metal Mines workings – Vertical Crater Retreat (VCR) method", PaperId=18, SessionId="3", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Carmella  Harvey  ", PaperTitle="Tunnel Construction Methods and their comparison", PaperId=19, SessionId="4", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Orval  Jean  ", PaperTitle="Factors in Controlling Drilling and Blasting Costs in Mines – Discussion", PaperId=20, SessionId="4", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Elvie  Abram  ", PaperTitle="Characteristics of Rock and Geology influence Surface, UG and Tunnel Rock Blasting Results", PaperId=21, SessionId="4", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Toshiko  Aaron  ", PaperTitle="Programmable Electronic Detonator System", PaperId=22, SessionId="4", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Corinne  Dominic  ", PaperTitle="MECHANICS OF BLASTING AND AIR-BLAST – ITS CONCEPT AND CONTROL WHILE BLASTING", PaperId=23, SessionId="4", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Dane  Dean  ", PaperTitle="Wall Control Blasting Techniques", PaperId=24, SessionId="4", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Lai  Walter  ", PaperTitle="Modification of Blasting Techniques as per Geological Conditions of Strata", PaperId=25, SessionId="5", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Kerstin  Marcellus  ", PaperTitle="Environmental Impacts of Mining", PaperId=26, SessionId="5", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Ricky  Ricky  ", PaperTitle="ACID DRAINAGE FROM MINES AND ITS RELATED PROBLEMS", PaperId=27, SessionId="5", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Sophia  Isreal  ", PaperTitle="Blast Fragmentation Appraisal-Means to Improve Cost Effectiveness in Mines", PaperId=28, SessionId="5", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Christen  Rodrick  ", PaperTitle="Cost effectiveness of open-pit hard rock Ore Mining", PaperId=29, SessionId="5", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Rebecka  Frederic  ", PaperTitle="Application of Air-Deck Technique in Surface Blasting", PaperId=30, SessionId="5", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Yu  Shayne  ", PaperTitle="ANFO, Emulsion and Heavy ANFO Blends – Useful Explosive and Blasting Agent for modern day blasting", PaperId=31, SessionId="6", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Fred  Lavern  ", PaperTitle="EXPLOSIVES", PaperId=32, SessionId="6", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Seema  Jan  ", PaperTitle="Acid Mine Drainage (AMD) and its control", PaperId=33, SessionId="6", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Myong  Cedrick  ", PaperTitle="Explosives, Theory of Breakage and Blasting Operations", PaperId=34, SessionId="6", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "September  Clinton  ", PaperTitle="Mining Practices with Objective of Sustainabilitys", PaperId=35, SessionId="6", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                new Presenter(){StudentName = "Josette  Rupert ", PaperTitle="Tunnel Excavations", PaperId=36, SessionId="6", SelectedClearansw=1, SelectedClarity=1, SelectedEyecon=1, SelectedInteng=1, SelectedTimekee=1, SelectedOrigqua=1, SelectedCorlev=1, SelectedGooduse=1, SelectedQuestwell=1, SelectedWellstru=1},
                };
            presenter.ForEach(e => context.Presenters.AddOrUpdate(p => p.Id, e));

            string[] roles = new string[] { "Admin", "Marker1", "Marker2", "Marker3", "Marker4", "Marker5", "Marker6" };

            foreach (string role in roles)
            {
                if (!context.Roles.Any(r => r.Name == role))
                {
                    context.Roles.Add(new IdentityRole(role));
                }

            }

            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var hasher = new PasswordHasher();
            var users = new List<ApplicationUser>
            {
                new ApplicationUser(){UserName = "admin@upec2018.com",Email = "admin@upec2018.com",EmailConfirmed = true,PasswordHash = hasher.HashPassword("3WPapt$p^="),LockoutEnabled = false,SecurityStamp = Guid.NewGuid().ToString()},
                new ApplicationUser(){UserName = "Session1@upec2018.com",Email = "Session1@upec2018.com",EmailConfirmed = true,PasswordHash = hasher.HashPassword("Yu+Ehz*%5P"),LockoutEnabled = false,SecurityStamp = Guid.NewGuid().ToString()},
                new ApplicationUser(){UserName = "Session2@upec2018.com",Email = "Session2@upec2018.com",EmailConfirmed = true,PasswordHash = hasher.HashPassword("4+6^$NJGvp"),LockoutEnabled = false,SecurityStamp = Guid.NewGuid().ToString()},
                new ApplicationUser(){UserName = "Session3@upec2018.com",Email = "Session3@upec2018.com",EmailConfirmed = true,PasswordHash = hasher.HashPassword("DWbQLq36!9"),LockoutEnabled = false,SecurityStamp = Guid.NewGuid().ToString()},
                new ApplicationUser(){UserName = "Session4@upec2018.com",Email = "Session4@upec2018.com",EmailConfirmed = true,PasswordHash = hasher.HashPassword("ND!?2_jxP@"),LockoutEnabled = false,SecurityStamp = Guid.NewGuid().ToString()},
                new ApplicationUser(){UserName = "Session5@upec2018.com",Email = "Session5@upec2018.com",EmailConfirmed = true,PasswordHash = hasher.HashPassword("$%c8+FVQP!"),LockoutEnabled = false,SecurityStamp = Guid.NewGuid().ToString()},
                new ApplicationUser(){UserName = "Session6@upec2018.com",Email = "Session7@upec2018.com",EmailConfirmed = true,PasswordHash = hasher.HashPassword("Ur2@jr5Nps"),LockoutEnabled = false,SecurityStamp = Guid.NewGuid().ToString()},
            };
            users.ForEach(u => context.Users.AddOrUpdate(q => q.Id, u));
                      
            context.SaveChanges();

            foreach (var item in users)
            {
                if (item.UserName == "admin@upec2018.com")
                {
                    userManager.AddToRole(item.Id, "Admin");
                }
                if (item.UserName == "Session1@upec2018.com")
                {
                    userManager.AddToRole(item.Id, "Marker1");
                }

                if (item.UserName == "Session2@upec2018.com")
                {
                    userManager.AddToRole(item.Id, "Marker2");
                }

                if (item.UserName == "Session3@upec2018.com")
                {
                    userManager.AddToRole(item.Id, "Marker3");
                }

                if (item.UserName == "Session4@upec2018.com")
                {
                    userManager.AddToRole(item.Id, "Marker4");
                }

                if (item.UserName == "Session5@upec2018.com")
                {
                    userManager.AddToRole(item.Id, "Marker5");
                }

                if (item.UserName == "Session6@upec2018.com")
                {
                    userManager.AddToRole(item.Id, "Marker6");
                }
            }

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
        
    }
}
