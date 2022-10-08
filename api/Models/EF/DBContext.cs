using System;
using System.Data;
using System.Data.Common;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Homo.AuthApi
{
    public partial class DBContext : DbContext
    {
        public DBContext() { }

        public DBContext(DbContextOptions<DBContext> options) : base(options) { }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<VerifyCode> VerifyCode { get; set; }
        public virtual DbSet<RelationOfGroupAndUser> RelationOfGroupAndUser { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<EarlyAdopter> EarlyAdopter { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            OnModelCreatingPartial(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(p => new { p.DeletedAt });
                entity.HasIndex(p => new { p.Email });
                entity.HasIndex(p => new { p.Status });
                entity.HasIndex(p => new { p.IsManager });
                entity.HasIndex(p => new { p.Username });
                entity.HasIndex(p => new { p.FirstName });
                entity.HasIndex(p => new { p.LastName });
                entity.HasIndex(p => new { p.Gender });
                entity.HasIndex(p => new { p.County });
                entity.HasIndex(p => new { p.City });
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasIndex(p => new { p.DeletedAt });
                entity.HasIndex(p => new { p.Name });
                entity.HasIndex(p => new { p.Roles });
            });

            modelBuilder.Entity<EarlyAdopter>(entity =>
            {
                entity.HasIndex(p => new { p.Email });
                entity.HasIndex(p => new { p.Phone });
            });

            modelBuilder.Entity<VerifyCode>(entity =>
            {
                entity.HasIndex(p => new { p.Expiration });
                entity.HasIndex(p => new { p.Code });
                entity.HasIndex(p => new { p.Ip });
                entity.HasIndex(p => new { p.Phone });
                entity.HasIndex(p => new { p.Email });
                entity.HasIndex(p => new { p.IsUsed });
            });

            modelBuilder.Entity<RelationOfGroupAndUser>(entity =>
            {
                entity.HasIndex(p => new { p.UserId });
                entity.HasIndex(p => new { p.GroupId });
            });
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);


    }
}