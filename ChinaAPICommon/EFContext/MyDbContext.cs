using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChinaAPICommon.Database;
using Microsoft.EntityFrameworkCore;

namespace ChinaAPICommon.EFContext
{
    public class MyDbContext : DbContext
    {
        public virtual DbSet<AccountDb>? AccountDb { get; set; }

        public virtual DbSet<AdvertisementPositionDb>? AdvertisementPositionDb { get; set; }
        public virtual DbSet<AdvertisementsDb>? AdvertisementsDb { get; set; }
        public virtual DbSet<BillDb>? BillDb { get; set; }
        public virtual DbSet<GroupDb>? GroupDb { get; set; }
        public virtual DbSet<GroupItemsDb>? GroupItemsDb { get; set; }
        public virtual DbSet<ItemDb>? ItemDb { get; set; }
        public virtual DbSet<MenuDb>? MenuDb { get; set; }
        public virtual DbSet<RoleDb>? RoleDb { get; set; }
    }
}
