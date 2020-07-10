using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Guna.UI2.WinForms;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using Guna.UI.WinForms;

namespace CuaHang
{
    public partial class ucBanHang : UserControl
    {
        public ucBanHang()
        {
            InitializeComponent();
        }
        
        private int indexSp = 0;
        private int indexLC = -1;
        private double thanhTien = 0;
        private void ucBanHang_Load(object sender, EventArgs e)
        {
            var result = from data in Dbo.getObject().NuocHoa
                         select new { MaNuocHoa = data.MaNuocHoa, TenNuocHoa = data.TenNuocHoa,
                         TenTheLoai = data.TheLoai.TenTheLoai, NhanHieu = data.NhanHieu,
                         XuatXu = data.XuatXu, SoLuongHienTai=data.SoLuongHienTai, DungTich=
                         data.DungTich, GiaTien=data.GiaTien};
            this.nuocHoaBindingSource.DataSource = result.ToList();
        }

        private void dataGridViewSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.AddNewRow(e.RowIndex);
        }
        private void AddNewRow(int index)
        {
            using (DataGridViewRow row = (DataGridViewRow)dataGridViewSanPham.Rows[index])
            using (FormChonSL form = new FormChonSL())
            {

                if (Convert.ToDouble(row.Cells[5].Value) == 0)
                {
                    MessageBox.Show("Sản phẩm đã hết hàng!!");
                    return;
                }
                form.nudSoluong.Maximum = Convert.ToDecimal(row.Cells[5].Value);
                form.nudSoluong.Minimum = 1;
                form.ShowDialog();
                if (!form.check)
                    return;
                int soLuong = Convert.ToInt32(form.nudSoluong.Value);

                double thanhtien = soLuong * Convert.ToDouble(row.Cells[7].Value);
                object[] newRow = { row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), soLuong.ToString(), row.Cells[7].Value.ToString(), thanhtien.ToString() };
                dataGridViewChon.Rows.Add(newRow);
                this.indexLC = dataGridViewChon.RowCount - 1;

                //Cập nhập thành tiền 
                updateThanhTien(thanhtien + this.thanhTien);
            }
        }
        private void updateThanhTien(double num)
        {
            thanhTien = num;
            lbThanhTien.Text = thanhTien + "Đ";
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {

             dataGridViewChon.Rows.Clear();
             dataGridViewChon.Refresh();
             //Cập nhập thành tiền                
             updateThanhTien(0);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.AddNewRow(this.indexSp);
        }

        private void dataGridViewSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.indexSp = e.RowIndex;
        }

        private void btnLoaiTru_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewChon.RowCount != 0)
            {
                double thanhtien = this.thanhTien - Convert.ToDouble(dataGridViewChon.Rows[this.indexLC].Cells[4].Value);
                updateThanhTien(thanhtien);
                dataGridViewChon.Rows.RemoveAt(this.indexLC);
                this.indexLC = dataGridViewChon.Rows.Count-1;
            }    
        }

        private void dataGridViewChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.indexLC = e.RowIndex;
        }


        private void guna2Button3_Click(object sender, EventArgs e)
        {
            using (FormThanhToan frm = new FormThanhToan())
            {
                frm.Load += (object s, EventArgs ev) =>
                {
                    foreach (DataGridViewRow item in dataGridViewChon.Rows)
                    {
                        List<string> list = new List<string>();
                        foreach (DataGridViewCell cell in item.Cells)
                        {
                            list.Add(cell.Value.ToString());
                        }
                        frm.dataGridViewThanhToan.Rows.Add(list.ToArray());
                    }

                    frm.lbTen.Text = this.tbTen.Text;
                    frm.lbSDT.Text = this.tbSDT.Text;
                    frm.lbTongTien.Text = this.lbThanhTien.Text;
                };
                frm.ShowDialog();   
            }    
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Guna2Button button = sender as Guna2Button;
            if (button == null)
                return;
            dataGridViewChon.Rows.Clear();
            dataGridViewChon.Refresh();
            button.Click += this.ucBanHang_Load;
            tbTen.Text = null;
            tbSDT.Text = null;
            tbTimKiem.Text = null;
            lbThanhTien.Text = "0Đ";
        }

        private void tbTimKiem_TextChanged_1(object sender, EventArgs e)
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
            dataGridViewSanPham.DataSource = ls.ToList();
        }
    }
}
