using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHang
{
    class V_xem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public V_xem()
        {
            this.v_xem = new HashSet<V_xem>();
        }

        public string MaNuocHoa { get; set; }
        public string TenNuocHoa { get; set; }
        public string NhanHieu { get; set; }
        public string XuatXu { get; set; }
        public int SoLuongHienTai { get; set; }
        public string DungTich { get; set; }
        public double GiaTien { get; set; }
        public string TenTheLoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<V_xem> v_xem { get; set; }
    }
}
