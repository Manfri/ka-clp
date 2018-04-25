namespace AMEL2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Berichts",
                c => new
                    {
                        BerichtID = c.Int(nullable: false, identity: true),
                        Projekt = c.Int(nullable: false),
                        BN = c.Int(nullable: false),
                        IT = c.Int(nullable: false),
                        s1 = c.String(),
                        s2 = c.String(),
                        s3 = c.String(),
                        s4 = c.String(),
                        s5 = c.String(),
                        s6 = c.String(),
                        s7 = c.String(),
                        s8 = c.String(),
                        s9 = c.String(),
                        s10 = c.String(),
                        s11 = c.String(),
                        s12 = c.String(),
                        s13 = c.String(),
                        s14 = c.String(),
                        s15 = c.String(),
                        s16 = c.String(),
                        s17 = c.String(),
                        s18 = c.String(),
                        s19 = c.String(),
                        s20 = c.String(),
                        s21 = c.String(),
                        s22 = c.String(),
                        s23 = c.String(),
                        s24 = c.String(),
                        s25 = c.String(),
                        s26 = c.String(),
                        s27 = c.String(),
                        s28 = c.String(),
                        s29 = c.String(),
                        s30 = c.String(),
                        s31 = c.String(),
                        s32 = c.String(),
                        s33 = c.String(),
                        s34 = c.String(),
                        s35 = c.String(),
                        s36 = c.String(),
                        s37 = c.String(),
                        s38 = c.String(),
                        s39 = c.String(),
                        s40 = c.String(),
                        s41 = c.String(),
                        s42 = c.String(),
                        s43 = c.String(),
                        s44 = c.String(),
                        s45 = c.String(),
                        s46 = c.String(),
                        s47 = c.String(),
                        s48 = c.String(),
                        s49 = c.String(),
                        s50 = c.String(),
                        s51 = c.String(),
                        s52 = c.String(),
                        s53 = c.String(),
                        s54 = c.String(),
                        s55 = c.String(),
                        s56 = c.String(),
                        s57 = c.String(),
                        s58 = c.String(),
                        s59 = c.String(),
                        s60 = c.String(),
                    })
                .PrimaryKey(t => t.BerichtID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Berichts");
        }
    }
}
