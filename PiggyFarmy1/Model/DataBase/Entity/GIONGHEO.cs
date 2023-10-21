using PiggyFarmy1.Others;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyFarmy1.Model.DataBase.Entity
{
    public partial class GIONGHEO : BaseViewModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GIONGHEO()
        {
            this.HEOs = new HashSet<HEO>();
        }
        [Key]
        public string MaGiongHeo { get; set; }
        private string _TenGiongHeo;
        public string TenGiongHeo { get => _TenGiongHeo; set { _TenGiongHeo = value; OnPropertyChanged(); } }
        public string MoTa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HEO> HEOs { get; set; }
    }
}
