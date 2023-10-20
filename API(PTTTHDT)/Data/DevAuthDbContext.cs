using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API_PTTTHDT_.Data
{
    public class DevAuthDbContext : IdentityDbContext
    {
        public DevAuthDbContext(DbContextOptions<DevAuthDbContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)   
        {
            base.OnModelCreating(builder);
            var studentRoleId = "cd715684-33b1-49c9-b408-4553cb20a176";
            var lecturersRoleId = "b99feb6f-6376-431b-94e0-e2197b7f264a";
            var ministryRoleId = "b936e0bf-98ec-4606-9e83-8e0d898edaa3";
            var industryLeaderRoleId = "9403f83e-4965-4c59-a3c5-c90d46d29965";
            var deanRoleId = "caa15f30-cd62-41f7-b9b9-e7449d23ab65";
            var adminRoleId = "bb444917-971a-4eb9-bcce-85d4cac76ca5";
            var roles = new List<IdentityRole>()
                {
                     new IdentityRole
                     {
                         Id = studentRoleId,
                         ConcurrencyStamp = studentRoleId,
                         Name = "Student",
                         NormalizedName = "Student".ToUpper()
                     },
                     new IdentityRole
                     {
                         Id = lecturersRoleId,
                         ConcurrencyStamp =  lecturersRoleId,
                         Name = "Lecturers",
                         NormalizedName = "Lecturers".ToUpper()
                     },
                     new IdentityRole
                     {
                         Id =ministryRoleId,
                         ConcurrencyStamp = ministryRoleId,
                         Name = "Ministry",
                         NormalizedName = "Ministry".ToUpper()
                     },
                     new IdentityRole
                     {
                         Id = industryLeaderRoleId,
                         ConcurrencyStamp = industryLeaderRoleId,
                         Name = "IndustryLeader",
                         NormalizedName = "IndustryLeader".ToUpper()
                     },
                     new IdentityRole
                     {
                         Id = deanRoleId,
                         ConcurrencyStamp = deanRoleId,
                         Name = "Dean",
                         NormalizedName = "Dean".ToUpper()
                     },
                     new IdentityRole
                     {
                         Id = adminRoleId ,
                         ConcurrencyStamp = adminRoleId ,
                         Name = "Admin",
                         NormalizedName = "Admin".ToUpper()
                     }
                };
            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
