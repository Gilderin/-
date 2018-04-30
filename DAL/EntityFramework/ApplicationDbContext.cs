using DAL.Entities;
using DAL.Entities.Auth;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework
{
    public class ApplicationDbContext : DbContext
    { 


        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }

        #region auth
        public DbSet<Role> Roles { get; set; } 
        public DbSet<AdminUnit> AdminUnits { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PermissionType> PermissionTypes { get; set; }
        #endregion  

        public ApplicationDbContext()
            :base(GetConnectionString())
        {
            Database.SetInitializer( new Initializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Actor>()
                .HasRequired(e => e.Employee)
                .WithRequiredPrincipal(e => e.Actor);
        }

        private static string GetConnectionString()
        {
            var sb = new DbConnectionStringBuilder();
            sb.Add("Data Source", @"(localdb)\MSSQLLocalDB");
            sb.Add("Initial Catalog", "Hotel"); //database name
            sb.Add("Integrated Security", "True"); //enable windows authentication
            var connection = sb.ConnectionString;
            return connection;
        }
    }
}
