using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHang
{
    public partial class FormThemSanPham : Form
    {
        public FormThemSanPham()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tbMaNuocHoa.Text = null;
            tbTenNuocHoa.Text = null;
            tbNhanHieu.Text = null;
            tbXuatXu.Text = null;
            tbSoLuong.Text = null;
            tbGiaTien.Text = null;
            tbDungTich.Text = null;
            btnXoa.Click += this.LoadToCombobox;
        }

        private bool CheckValues()
        {
            bool c = true;
            string check = "Không được bỏ trống";
            if (tbMaNuocHoa.Text == "")
            {
                lbCMaNuocHoa.Text = check;
                c = false;
            }
            else
            {
                lbCMaNuocHoa.Text = "";
            }
            if (tbTenNuocHoa.Text == "")
            {
                lbCTenNuocHoa.Text = check;
                c = false;
            }
            else
            {
                lbCTenNuocHoa.Text = "";
            }
            if (tbNhanHieu.Text == "")
            {
                lbCNhanHieu.Text = check;
                c = false;
            }
            else
            {
                lbCNhanHieu.Text = "";
            }
            if (tbXuatXu.Text == "")
            {
                lbCXuatXu.Text = check;
                c = false;
            }
            else
            {
                lbCXuatXu.Text = "";
            }
            if (tbSoLuong.Text == "")
            {
                    
                lbCSoLuong.Text = check;
                c = false;
            }
            else
            {
                if (!Regex.IsMatch(tbSoLuong.Text, @"^\d+$"))
                {
                    check = "Vui lòng nhập số";
                    lbCSoLuong.Text = check;
                    check = "Không được bỏ trống";
                }
                else
                lbCSoLuong.Text = "";
            }
            if (tbDungTich.Text == "")
            {
                lbCDungTich.Text = check;
                c = false;
            }
            else
            {
                lbCDungTich.Text = "";
            }
            if (cbTheLoai.SelectedIndex < 0)
            {
                lbCTenTheLoai.Text = check;
                c = false;
            }
            else
            {
                lbCTenTheLoai.Text = "";
            }
            if (tbGiaTien.Text == "")
            {
                lbCGiaTien.Text = check;
                c = false;
            }
            else
            {
                if (!Regex.IsMatch(tbGiaTien.Text, @"^\d+$"))
                {
                    check = "Vui lòng nhập số";
                    lbCGiaTien.Text = check;
                    c = false;
                }
                else
                {
                    lbCGiaTien.Text = "";
                }    
                    
            }
            if (c)
                return true;
            return false;
        }

        public void btnLuu_Click(object sender, EventArgs e)
        {
            if (!CheckValues())
            {
                return;
            }    
                
            NuocHoa nuocHoa = new NuocHoa();
            nuocHoa.MaNuocHoa = tbMaNuocHoa.Text;
            nuocHoa.TenNuocHoa = tbTenNuocHoa.Text;
            nuocHoa.MaTheLoai = cbTheLoai.SelectedItem.ToString()[0] - '0';
            nuocHoa.NhanHieu = tbNhanHieu.Text;
            nuocHoa.XuatXu = tbXuatXu.Text;
            nuocHoa.DungTich = tbDungTich.Text;
            nuocHoa.SoLuongHienTai = Convert.ToInt32(tbSoLuong.Text);
            nuocHoa.GiaTien = Convert.ToDouble(tbGiaTien.Text);
            Dbo.getObject().NuocHoa.Add(nuocHoa);
            Dbo.getObject().SaveChanges();
            this.Close();
        }

        private void LoadToCombobox(object sender, EventArgs e)
        {
            var theLoai = from p in Dbo.getObject().TheLoais
                          select new { p.TenTheLoai,p.MaTheLoai };
            foreach (var item in theLoai)
            {
                cbTheLoai.Items.Add(item.MaTheLoai + " " +item.TenTheLoai);
            }
        }

        private void FormThemSanPham_Load(object sender, EventArgs e)
        {
            //load combobox
            this.LoadToCombobox(sender, e);
        }
    }
}
