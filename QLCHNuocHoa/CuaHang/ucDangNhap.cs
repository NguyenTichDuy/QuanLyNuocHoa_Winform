using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CuaHang
{
    public partial class ucDangNhap : UserControl
    {
        public ucDangNhap()
        {
            InitializeComponent();
        }
        public bool checkSucess = false;
        private bool checkTaiKhoan()
        {
            if (Regex.IsMatch(tbxtaikhoan.Text, @"^\w{1,50}$"))
            {
                if (Dbo.getObject().TaiKhoan.Find(tbxtaikhoan.Text) != null)
                {
                    lbCUserName.Text = "";
                    return true;
                }
                else
                {
                    lbCUserName.Text = "Không tồn tại tài khoản này";
                }
            }    
            else
            {
                lbCUserName.Text = "Kí tự nhập vào không hợp lệ hoặc để trống";
            }
            return false;
        }
        private bool checkPassword()
        {
            if (checkTaiKhoan())
            {
                if (Regex.IsMatch(tbxmatkhau.Text, @"^\w{1,50}$"))
                {
                    if (Dbo.getObject().TaiKhoan.Find(tbxtaikhoan.Text).MatKhau == tbxmatkhau.Text)
                    {
                        lbCPassword.Text = "";
                        checkSucess = true;
                        return true;
                    }
                    else
                    {
                        lbCPassword.Text = "Mật khẩu sai";
                    }
                }
                else
                {
                    lbCPassword.Text = "Kí tự nhập vào không hợp lệ hoặc để trống";
                }
            }
            return false;
        }
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkPassword())
                {
                    MyForm myForm = new MyForm();
                        checkSucess = true;
                        myForm.lbTaiKhoan.Text = tbxtaikhoan.Text;
                        myForm.Show();
                }
            }
            catch { }
        }

        private void ucDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
