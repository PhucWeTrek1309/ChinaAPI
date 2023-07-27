using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChinaAPICommon.Database;
using ChinaAPICommon.DbConfiguration;
using Microsoft.EntityFrameworkCore;

namespace ChinaAPICommon.EFContext
{
    public class MyDbContext : DbContext
    {

        public MyDbContext()
        {
            //
        }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            //
        }


        public virtual DbSet<AccountDb>? AccountDb { get; set; }
        public virtual DbSet<AdvertisementPositionDb>? AdvertisementPositionDb { get; set; }
        public virtual DbSet<AdvertisementsDb>? AdvertisementsDb { get; set; }
        public virtual DbSet<NotificationDb>? BillDb { get; set; }
        public virtual DbSet<GroupDb>? GroupDb { get; set; }
        public virtual DbSet<GroupItemsDb>? GroupItemsDb { get; set; }
        public virtual DbSet<ItemDb>? ItemDb { get; set; }
        public virtual DbSet<MenuDb>? MenuDb { get; set; }
        public virtual DbSet<RoleDb>? RoleDb { get; set; }
        public virtual DbSet<ImageDb>? ImageDb { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountConfig());

            modelBuilder.ApplyConfiguration(new AdvertisementConfig());

            modelBuilder.ApplyConfiguration(new AdvertisementPositionConfig());

            modelBuilder.ApplyConfiguration(new NotificationConfig());

            modelBuilder.ApplyConfiguration(new GroupConfig());

            modelBuilder.ApplyConfiguration(new GroupItemConfig());

            modelBuilder.ApplyConfiguration(new ItemConfig());

            modelBuilder.ApplyConfiguration(new MenuConfig());

            modelBuilder.ApplyConfiguration(new RoleConfig());

            modelBuilder.ApplyConfiguration(new ImageConfig());

            //modelBuilder.Seed();
        }
    }
}
