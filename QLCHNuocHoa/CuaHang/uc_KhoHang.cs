using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace CuaHang
{
    public partial class uc_KhoHang : UserControl
    {
        public uc_KhoHang()
        {
            InitializeComponent();
        }
        private int index;
        private void LoadData()
        {
            var result = from data in Dbo.getObject().NuocHoa
                         select new
                         {
                             MaNuocHoa = data.MaNuocHoa,
                             TenNuocHoa = data.TenNuocHoa,
                             TenTheLoai = data.TheLoai.TenTheLoai,
                             NhanHieu = data.NhanHieu,
                             XuatXu = data.XuatXu,
                             SoLuongHienTai = data.SoLuongHienTai,
                             DungTich =
                         data.DungTich,
                             GiaTien = data.GiaTien
                         };
            this.nuocHoaBindingSource2.DataSource = result.ToList();
            
        }    

        private void uc_KhoHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            using (FormThemSanPham frm = new FormThemSanPham())
            {
                frm.ShowDialog();
                LoadData();
            }    
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            Guna2TextBox tb = sender as Guna2TextBox;
            var ls = (from c in Dbo.getObject().NuocHoa
                      where (c.MaNuocHoa.StartsWith(tb.Text) ||
                             c.TenNuocHoa.Contains(tb.Text) ||
                             c.TheLoai.TenTheLoai.StartsWith(tb.Text) ||
                             c.XuatXu.Contains(tb.Text) ||
                             c.NhanHieu.Contains(tb.Text) ||
                             c.DungTich.Contains(tb.Text)
                             )
                      select new
                      {
                          c.MaNuocHoa,
                          c.TenNuocHoa,
                          c.TheLoai.TenTheLoai,
                          c.XuatXu,
                          c.NhanHieu,
                          c.SoLuongHienTai,
                          c.DungTich,
                          c.GiaTien
                      });
            dataGridViewKhoHang.DataSource = ls.ToList();
        }


        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(FormSua frm = new FormSua())
            {
                frm.tbMaNuocHoa.Text = dataGridViewKhoHang.Rows[index].Cells[0].Value.ToString();
                frm.tbTenNuocHoa.Text = dataGridViewKhoHang.Rows[index].Cells[1].Value.ToString();
                frm.cbTheLoai.Text = dataGridViewKhoHang.Rows[index].Cells[2].Value.ToString();
                frm.tbNhanHieu.Text = dataGridViewKhoHang.Rows[index].Cells[3].Value.ToString();
                frm.tbXuatXu.Text = dataGridViewKhoHang.Rows[index].Cells[4].Value.ToString();
                frm.tbSoLuong.Text = dataGridViewKhoHang.Rows[index].Cells[5].Value.ToString();
                frm.tbDungTich.Text = dataGridViewKhoHang.Rows[index].Cells[6].Value.ToString();
                frm.tbGiaTien.Text = dataGridViewKhoHang.Rows[index].Cells[7].Value.ToString();
                frm.ShowDialog();
                if (frm.check)
                    removeRow(index);
            }    
        }
        private void removeRow(int index)
        {
            string str = dataGridViewKhoHang.Rows[index].Cells[0].Value.ToString();
            var remove = Dbo.getObject().NuocHoa.SingleOrDefault(x => x.MaNuocHoa == str);
            if (remove != null)
            {
                Dbo.getObject().NuocHoa.Remove(remove);
                Dbo.getObject().SaveChanges();
                LoadData();
            }    
                
        }
        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeRow(index);
        }


        private void btnThemLoai_Click_1(object sender, EventArgs e)
        {
            using (FormThemTheLoai frm = new FormThemTheLoai())
            {
                frm.ShowDialog();
                LoadData();
            }
        }

        private void dataGridViewKhoHang_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                index = e.RowIndex;
        }
    }
}
