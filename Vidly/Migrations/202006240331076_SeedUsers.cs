namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'26446d42-e8c8-4096-b77f-b3bf6ed885f1', N'admin@vidly.com', 0, N'ANho8ZuBWJsDEf/CoGM5enaIJEPE0mb6fNUs871rdlEeqGw9tbrv7Pf9sQkNh8L0ZA==', N'2a21e6a5-7434-4a53-8137-340416fd39ab', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'65592991-c3c2-4dd9-8532-fc4e4d75768a', N'guest@vidly.com', 0, N'ADX3fOdiOqmze15c4DUsryfw3ZTTxf9MB7uUdRupuMUYP+0/Rlc6FYdeVmcNhIE22A==', N'b4bc1d2b-5889-4d55-b90f-419b0e2038df', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd1c0fac4-2333-43d1-bbbc-dd6cccfd8e0f', N'admin2@vidly.com', 0, N'ABc7QaNq8guw9um29iaKsADKRTLOHJ2+e18I5BZAf8Kp/TBkoIqBW13Ak9S/a3KFqA==', N'eeae82a7-41c6-4727-95ee-0fc0993599b3', NULL, 0, 0, NULL, 1, 0, N'admin2@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e339998b-8953-49f3-af6d-95b599eb8053', N'admin1@vidly.com', 0, N'AMTQkxTsPyYG+Thgjb/Vq9CkwJjDF39Aavm7gItulCT4MGM63NXprM5Oc6qDx0e3kQ==', N'cf2dbb07-b3ef-412c-aa2d-81754b0743ff', NULL, 0, 0, NULL, 1, 0, N'admin1@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'edab242f-6140-4ecb-8b8f-189d4d46ad5b', N'jahid.aust39@gmail.com', 0, N'ANtICCtfygJxwOMuR1rZmMjX5Y5AZCRWNFQJAtlCjT+aEKw6WYXr23oOaSdo/PG7Sg==', N'8a2d6bc0-c186-4506-b5a6-c564fa16ea36', NULL, 0, 0, NULL, 1, 0, N'jahid.aust39@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6f2067bd-58c4-4ba9-8994-7f43a5feb175', N'CanManagerMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd1c0fac4-2333-43d1-bbbc-dd6cccfd8e0f', N'6f2067bd-58c4-4ba9-8994-7f43a5feb175')



");
        }
        
        public override void Down()
        {
        }
    }
}
