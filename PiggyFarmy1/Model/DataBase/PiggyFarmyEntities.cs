using PiggyFarmy1.Model.DataBase.Entity;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PiggyFarmy1.Model.DataBase
{
    public partial class PiggyFarmyEntities : DbContext
    {
        public PiggyFarmyEntities()
            : base("name=PiggyFarmyDB")
        {
        }

        public DbSet<HEO> HEOs { get; set; }
        public DbSet<LOAIHEO> LOAIHEOs { get; set; }
        public DbSet<GIONGHEO> GIONGHEOs { get; set; }
        public DbSet<CHUONGHEO> CHUONGHEOs { get; set; }
        public DbSet<LOAICHUONG> LOAICHUONGs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
