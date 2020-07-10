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
    public partial class FormDoiMK : Form
    {
        public FormDoiMK()
        {
            InitializeComponent();
            tbxtendangnhapdoimk.Text = Save.account;
        }
        void resetText()
        {
            tbxmatkhaudoimk.Text = "";
            tbxnhaplaimkmoi.Text = "";
            tbxmatkhaumoi.Text = "";
        }
        private void Btnluudoimk_Click(object sender, EventArgs e)
        {
            try
            {

                TaiKhoan tk1 = Dbo.getObject().TaiKhoan.Find(Save.account);

                if (tbxmatkhaudoimk.Text == tk1.MatKhau)
                {
                    if (tbxmatkhaumoi.Text == null || tbxmatkhaumoi.Text == "" || tbxmatkhaumoi.Text.Length > 15)

                        MessageBox.Show("Mật khẩu mới trống hoặc quá dài", "Thông báo");


                    else if (tbxnhaplaimkmoi.Text != tbxmatkhaumoi.Text)
                        MessageBox.Show("Mật khẩu mới không trùng khớp!", "Thông báo");

                    else
                    {
                        tk1.MatKhau = tbxmatkhaumoi.Text;
                        Dbo.getObject().SaveChanges();
                        MessageBox.Show("Thay đổi mật khẩu thành công!");
                        resetText();
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Mật khẩu không đúng!", "Thông báo");
            }
            catch { }

     
         }

        private void Btntrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
