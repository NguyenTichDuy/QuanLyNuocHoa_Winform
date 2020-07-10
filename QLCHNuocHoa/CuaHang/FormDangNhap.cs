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
    public partial class FormDangNhap : Form
    {
        
        public FormDangNhap()
        {
            InitializeComponent();
        }
        

        private void Btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lblquenmk_Click(object sender, EventArgs e)
        {


        }

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                TaiKhoan tk1 = Dbo.getObject().TaiKhoan.Find(tbxtaikhoan.Text);
                if (tk1 == null && tk1.MatKhau != tbxmatkhau.Text)
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                }
                else
                {
                    Check.checkbool = true;
                    Save.account = tbxtaikhoan.Text;
                    using (MyForm myForm = new MyForm())
                    {
                        myForm.ShowDialog();
                    }
                    this.Close();
                }


            }
            catch { }
        }

        private void lblquenmk_Click_2(object sender, EventArgs e)
        {
            //this.Hide();
            //FormQuenMK fq = new FormQuenMK();
            //fq.ShowDialog();
            //this.Show();
        }
    }
}
