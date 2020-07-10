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
    public partial class FormTatCaTK : Form
    {
        public FormTatCaTK()
        {
            InitializeComponent();
            hidethem();
            dataGridView1.AutoGenerateColumns = false;
            bindingSourcetaikhoan.DataSource = Dbo.getObject().TaiKhoan.ToList();
            
        }
        void hidethem()
        {
            this.Size = new Size(400, 430);
            tbxmk.Text = "";
            tbxtk.Text = "";
            tbxMaKhoiPhuc.Text = "";
            lbltk.Hide();
            lblmk.Hide();
            lblmkp.Hide();
            tbxtk.Hide();
            tbxmk.Hide();
            tbxMaKhoiPhuc.Hide();

            btnthem2.Hide();
            btnhuy.Hide();
            btnthoat2.Hide();
        }
        void showthem()
        {

            lbltk.Show();
            lblmk.Show();
            lblmkp.Show();
            tbxtk.Show();
            tbxmk.Show();
            tbxMaKhoiPhuc.Show();

            btnthem2.Show();
            btnhuy.Show();
            btnthoat2.Show();
            this.Size = new Size(400, 560);
        }

        private void Btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn muốn xóa tài khoản này?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    string tk = "";


                    try
                    {
                        tk = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();


                    }

                    catch
                    {
                        tk = dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString();

                    }

                    TaiKhoan tk1 = Dbo.getObject().TaiKhoan.Find(tk);
                    if (tk1.TenDangNhap == "admin")
                        MessageBox.Show("Bạn không thể xóa tài khoản admin");
                    else if (tk1.TenDangNhap == Save.account)
                        MessageBox.Show("Tài khoản này đang đăng nhập");
                    else
                    {
                        Dbo.getObject().TaiKhoan.Remove(tk1);
                        Dbo.getObject().SaveChanges();
                        bindingSourcetaikhoan.DataSource = Dbo.getObject().TaiKhoan.ToList();
                    }


                }
            }
            catch { }

        }

        private void Btnthem_Click(object sender, EventArgs e)
        {
            
            pnlmain.Hide();
            showthem();
            

        }

        private void Btnhuy_Click(object sender, EventArgs e)
        {
            hidethem();
            pnlmain.Show();
        }

        private void Btnthem2_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxtk.Text.Length == 0 || tbxtk.Text.Length > 20)
                    MessageBox.Show("Tên tài khoản không được trống hoặc quá dài");
                else if (tbxmk.Text.Length > 20)
                    MessageBox.Show("Mật khẩu quá dài");
                else if(tbxMaKhoiPhuc.Text.Length == 0 || tbxMaKhoiPhuc.Text.Length > 20)
                    MessageBox.Show("Mã khôi phục không được trống hoặc quá dài");
                else
                {
                    TaiKhoan tk1 = new TaiKhoan();
                    tk1.TenDangNhap = tbxtk.Text;
                    tk1.MatKhau = tbxmk.Text;
                    tk1.MaKhoiPhuc = tbxMaKhoiPhuc.Text;
                    Dbo.getObject().TaiKhoan.Add(tk1);
                    Dbo.getObject().SaveChanges();
                    btnhuy.PerformClick();
                    bindingSourcetaikhoan.DataSource = Dbo.getObject().TaiKhoan.ToList();
                }
            }
            catch {
                MessageBox.Show("Tài khoản này đã có rồi!");
            }
    }

        private void Btnthoat2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTatCaTK_Load(object sender, EventArgs e)
        {
            dataGridView1.Font = new System.Drawing.Font(dataGridView1.Font.FontFamily, 12);
        }
    }
}
