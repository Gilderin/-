using Entity.Entities;
using Entity.Entities.Auth;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.EntityFramework
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Client> Clients { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<ComplaintCategory> ComplaintCategories { get; set; }
        public DbSet<ComplaintCategoryJoin> ComplaintCategoryJoins { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<RoomService> RoomServices { get; set; }
        public DbSet<Entities.Service> Services { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }

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
            base.OnModelCreating(modelBuilder);

            //configure one-to-one
            var actorBuilder = modelBuilder.Entity<Actor>();
            actorBuilder
                .HasRequired(e => e.Employee)
                .WithRequiredPrincipal(e => e.Actor);

           
            //configure many-to-many
            var complaintCategoryJoinBuilder = modelBuilder
                .Entity<ComplaintCategoryJoin>();
            complaintCategoryJoinBuilder
                .HasRequired(e => e.Complaint)
                .WithMany(e => e.ComplaintCategotyJoins)
                .HasForeignKey(e => e.ComplaintId);
            complaintCategoryJoinBuilder
                .HasRequired(e => e.ComplaintCategory)
                .WithMany(e => e.ComplaintCategotyJoins)
                .HasForeignKey(e => e.ComplaintCategoryId);
            complaintCategoryJoinBuilder
                .HasKey(e => new { e.ComplaintCategoryId, e.ComplaintId });

            // configure cascade delete
            var roomServiceBuilder = modelBuilder
                .Entity<RoomService>();
            roomServiceBuilder
                .HasRequired(e => e.Payment)
                .WithMany(e => e.RoomServices)
                .HasForeignKey(e => e.PaymentId)
                .WillCascadeOnDelete(false);
            roomServiceBuilder.
                HasRequired(e => e.Employee)
                .WithMany(e => e.RoomServices)
                .HasForeignKey(e => e.EmployeeId)
                .WillCascadeOnDelete(true);

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
