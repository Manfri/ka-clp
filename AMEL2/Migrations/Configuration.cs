namespace AMEL2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using AMEL2.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    internal sealed class Configuration : DbMigrationsConfiguration<AMEL2.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        bool AddUserAndRole(AMEL2.Models.ApplicationDbContext context)
        {
            IdentityResult ir;
            var rm = new RoleManager<IdentityRole>
                (new RoleStore<IdentityRole>(context));
            ir = rm.Create(new IdentityRole("canEdit"));
            var um = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));
            var user = new ApplicationUser()
            {
                UserName = "kuehn@aqua-consult.de",
            };
            ir = um.Create(user, "$$Kuehn06");
            if (ir.Succeeded == false)
                return ir.Succeeded;
            ir = um.AddToRole(user.Id, "canEdit");
            return ir.Succeeded;
        }

        protected override void Seed(AMEL2.Models.ApplicationDbContext context)
        {
            AddUserAndRole(context);
            context.Berichts.AddOrUpdate(
                p => p.BN,
                new Bericht
                {
                    Projekt = 15103,
                    BN = 2,
                    IT = 0,
                    s1 = "A-2Y(L)2Y 4 x 2 x 0,8",
                    s2 = "60",
                    s3 = "",
                    s4 = ""
                },
                 new Bericht
                 {
                     Projekt = 15103,
                     BN = 2,
                     IT = 271,
                     s1 = "MP-62.03",
                     s2 = "Dosierpumpe 1 FHM",
                     s3 = "Antriebsschutz",
                     s4 = "30"
                 },
                  new Bericht
                  {
                      Projekt = 15103,
                      BN = 2,
                      IT = 281,
                      s1 = "MP-62.01",
                      s2 = "Dosierpumpe 2 FHM",
                      s3 = "Antriebsschutz",
                      s4 = "30"
                  },
                   new Bericht
                   {
                       Projekt = 15103,
                       BN = 2,
                       IT = 0,
                       s1 = "A-2YF(L)2Y 10 x 2 x 0,8",
                       s2 = "400",
                       s3 = "",
                       s4 = ""
                   },
                    new Bericht
                    {
                        Projekt = 15103,
                        BN = 2,
                        IT = 11,
                        s1 = "MP-10.01",
                        s2 = "Pumpstation Gadenstedt",
                        s3 = "Steuerung /Meldung",
                        s4 = "400"
                    }
                );
        }
    }
}
