using Microsoft.EntityFrameworkCore;
using System.Numerics;


namespace UsersAPI.Models
{
    public partial class UsersDbContext : DbContext
    {
        public UsersDbContext() { }
        public UsersDbContext(DbContextOptions<UsersDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Users> Users { get; set; }

        public virtual DbSet<Role> Role { get; set; }
        protected override void OnModelCreating(ModelBuilder mbuilder)
        {
            mbuilder.Entity<Users>().HasData(
                new Users
                {
                    Id = 1,
                    FirstName = "shayma",
                    LastName = "ben ahmed",
                    Email = "shaymabenahmed1002@gmail.com",
                    Phone = "+21625456146"
                },
                  new Users
                  {
                      Id = 2,
                      FirstName = "imen",
                      LastName = "ben dhiab",
                      Email = "imeneebendhiab@gmail.com",
                      Phone = "+21628673043"
                  });
            mbuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = 1,
                    RoleName = "membre",
                    Description = "Pour ce faire, cliquez sur la ligne correspondante à cette action reconnue par",
                   
                },
                  new Role
                  {
                      Id = 2,
                      RoleName = "Administrateur",
                      Description = "Adjust the code based on the specific ORM or data access approach you're using.",
                      
                  });

        }
    }
}
