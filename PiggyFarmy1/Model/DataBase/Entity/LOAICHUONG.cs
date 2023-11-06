using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyFarmy1.Model.DataBase.Entity
{
    public partial class LOAICHUONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAICHUONG()
        {
            this.CHUONGHEOs = new HashSet<CHUONGHEO>();
        }
        [Key]
        public string MaLoaiChuong { get; set; }
        public string TenLoai { get; set; }
        public string MoTa { get; set; }
        public int SucChuaToiDa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUONGHEO> CHUONGHEOs { get; set; }
    }
}
