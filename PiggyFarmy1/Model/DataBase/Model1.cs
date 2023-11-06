using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PiggyFarmy1.Model.DataBase
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=PiggyFarmyDB")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
