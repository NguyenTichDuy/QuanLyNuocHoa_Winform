using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHang
{
    public partial class FormThanhToan : Form
    {
        public FormThanhToan()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // update Hoa don
            HoaDon hoaDon = new HoaDon();
            hoaDon.TenKhachHang = lbTen.Text;
            hoaDon.SdtKhachHang = lbSDT.Text;
            hoaDon.NgayLap = DateTime.Now;
            Dbo.getObject().HoaDon.Add(hoaDon);
            Dbo.getObject().SaveChanges();

            //update chi tiet hoa don
            foreach (DataGridViewRow item in dataGridViewThanhToan.Rows)
            {
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
                string str = item.Cells[0].Value.ToString();
                HoaDon hd = Dbo.getObject().HoaDon.Find(hoaDon.Id);
                NuocHoa nh = Dbo.getObject().NuocHoa.Find(str);
                MessageBox.Show(hd.Id.ToString() + " " + nh.MaNuocHoa.ToString());
                chiTietHoaDon.MaHoaDon = hoaDon.Id;
                chiTietHoaDon.MaNuocHoa = str;
                chiTietHoaDon.SoLuong = Convert.ToInt32(item.Cells[2].Value);
                chiTietHoaDon.DonGia = Convert.ToDouble(item.Cells[3].Value);
                Dbo.getObject().ChiTietHoaDon.Add(chiTietHoaDon);
                Dbo.getObject().SaveChanges();
            }
            //Dbo.getObject().SaveChanges();
            this.Close();
        }

        private void FormThanhToan_Load(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString();
        }
    }
}
