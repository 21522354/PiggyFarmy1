using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyFarmy1.Model.DataBase.Entity
{
    public partial class LOAIHEO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIHEO()
        {
            this.HEOs = new HashSet<HEO>();
        }
        [Key]
        public string MaLoaiHeo { get; set; }
        public string TenLoaiHeo { get; set; }
        public string MoTa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HEO> HEOs { get; set; }
    }
}
