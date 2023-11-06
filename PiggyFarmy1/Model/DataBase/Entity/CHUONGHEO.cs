using PiggyFarmy1.Others;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyFarmy1.Model.DataBase.Entity
{
    public class CHUONGHEO:BaseViewModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHUONGHEO()
        {
            this.HEOs = new HashSet<HEO>();
        }
        [Key]
        public string MaChuong { get; set; }
        public string MaLoaiChuong { get; set; }
        private string _TinhTrang;
        public string TinhTrang { get => _TinhTrang; set { _TinhTrang = value; OnPropertyChanged(); } }
        public Nullable<int> SoLuongHeo { get; set; }

        public virtual LOAICHUONG LOAICHUONG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HEO> HEOs { get; set; }
    }
}
