using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using ACMS.DAL.Models.Configurations;
using ACMS.DAL.Models;
using Microsoft.AspNetCore.Identity;

namespace ACMS.DAL.DataContext
{
    public partial class APIDbContext : IdentityDbContext<User, UserRole, int>
    {

        //Identity Table
        public DbSet<IdentityRoleClaim<int>> AspNetRoleClaims { get; set; }
        public DbSet<IdentityUserClaim<int>> AspNetUserClaims { get; set; }
        public DbSet<IdentityUserLogin<int>> AspNetUserLogins { get; set; }
        public DbSet<IdentityUserRole<int>> AspNetUserRoles { get; set; }
        public DbSet<IdentityUserToken<int>> AspNetUserTokens { get; set; }
        public DbSet<User> AspNetUsers { get; set; }
        public DbSet<UserRole> AspNetRoles { get; set; }

        //Cusomized ACMS Table
        public virtual DbSet<AvailableClass> AvailableClasses { get; set; }
        public virtual DbSet<ClassCategory> ClassCategories { get; set; }
        public virtual DbSet<ClassReport> ClassReports { get; set; }
        public virtual DbSet<PaidSession> PaidSessions { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<RegistredClass> RegistredClasses { get; set; }
        public virtual DbSet<SessionSchedule> SessionSchedules { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }


        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityUserClaim<int>>().HasKey(p => new { p.Id });
            modelBuilder.Entity<IdentityRoleClaim<int>>().HasKey(p => new { p.Id });
            modelBuilder.Entity<IdentityUserLogin<int>>().HasKey(p => new { p.LoginProvider, p.ProviderKey });
            modelBuilder.Entity<IdentityUserRole<int>>().HasKey(p => new { p.UserId, p.RoleId });
            modelBuilder.Entity<IdentityUserToken<int>>().HasKey(p => new { p.UserId, p.LoginProvider, p.Name });
            modelBuilder.Entity<User>().HasKey(p => new { p.Id });
            modelBuilder.Entity<UserRole>().HasKey(p => new { p.Id });
            modelBuilder.ApplyConfiguration(new AvailableClassConfig());
            modelBuilder.ApplyConfiguration(new ClassCategoyConfig());
            modelBuilder.ApplyConfiguration(new ClassReportConfig());
            modelBuilder.ApplyConfiguration(new PaidSessionConfig());
            modelBuilder.ApplyConfiguration(new PaymentMethodConfig());
            modelBuilder.ApplyConfiguration(new RegisteredClassConfig());
            modelBuilder.ApplyConfiguration(new SessionScheduledConfig());
            modelBuilder.ApplyConfiguration(new StudentConfig());
            modelBuilder.ApplyConfiguration(new TeacherConfig());
            OnModelCreatingPartial(modelBuilder);

        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        //public override int SaveChanges()
        //{
        //    ChangeTracker.DetectChanges();

        //    foreach (var item in ChangeTracker.Entries<AvailableClass>().Where(e => e.State
        //      == EntityState.Deleted))
        //    {
        //        item.State = EntityState.Modified;
        //        item.CurrentValues["Deleted"] = true;
        //        item.CurrentValues["DeletedOn"] = DateTime.Now;
        //    }

        //    foreach (var item in ChangeTracker.Entries<ClassCategory>().Where(e => e.State
        //      == EntityState.Deleted))
        //    {
        //        item.State = EntityState.Modified;
        //        item.CurrentValues["Deleted"] = true;
        //        item.CurrentValues["DeletedOn"] = DateTime.Now;

        //    }
        //    foreach (var item in ChangeTracker.Entries<ClassReport>().Where(e => e.State
        //    == EntityState.Deleted))
        //    {
        //        item.State = EntityState.Modified;
        //        item.CurrentValues["Deleted"] = true;
        //        item.CurrentValues["DeletedOn"] = DateTime.Now;

        //    }
        //    foreach (var item in ChangeTracker.Entries<PaidSession>().Where(e => e.State
        //    == EntityState.Deleted))
        //    {
        //        item.State = EntityState.Modified;
        //        item.CurrentValues["Deleted"] = true;
        //        item.CurrentValues["DeletedOn"] = DateTime.Now;

        //    }
        //    foreach (var item in ChangeTracker.Entries<PaymentMethod>().Where(e => e.State
        //    == EntityState.Deleted))
        //    {
        //        item.State = EntityState.Modified;
        //        item.CurrentValues["Deleted"] = true;
        //        item.CurrentValues["DeletedOn"] = DateTime.Now;

        //    }
        //    foreach (var item in ChangeTracker.Entries<RegistredClass>().Where(e => e.State
        //    == EntityState.Deleted))
        //    {
        //        item.State = EntityState.Modified;
        //        item.CurrentValues["Deleted"] = true;
        //        item.CurrentValues["DeletedOn"] = DateTime.Now;

        //    }
        //    foreach (var item in ChangeTracker.Entries<SessionSchedule>().Where(e => e.State
        //    == EntityState.Deleted))
        //    {
        //        item.State = EntityState.Modified;
        //        item.CurrentValues["Deleted"] = true;
        //        item.CurrentValues["DeletedOn"] = DateTime.Now;

        //    }


        //    return base.SaveChanges();
        //}
        public APIDbContext NewInstance()
        {
            var dbContextOptionsBuilder = new DbContextOptionsBuilder<APIDbContext>();
            dbContextOptionsBuilder.UseSqlServer(this.Database.GetDbConnection().ConnectionString);
            return new APIDbContext(dbContextOptionsBuilder.Options);
        }
    }
}
