using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHang
{
    public partial class uc_TaiKhoan : UserControl
    {
        public uc_TaiKhoan()
        {
            InitializeComponent();
        }
        private bool checkAdmin()
        {
            if (lbAccount.Text == "admin")
                return true;
            return false;
        }
        private void uc_TaiKhoan_Load(object sender, EventArgs e)
        {
            if (checkAdmin())
            {
                this.LoadDataSource();
                this.btnThemTaiKhoan.Enabled = true;
            }
            else
            {
                this.btnThemTaiKhoan.Visible = false;
                this.btnThemTaiKhoan.Enabled = false;
               
            }
                
        }
        private void LoadDataSource()
        {
            var result = from data in Dbo.getObject().TaiKhoan
                         select data;
            this.taiKhoanBindingSource.DataSource = result.ToList();
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Program.formDangNhap.Show();
            Program.formDangNhap.ucDangNhap.tbxmatkhau.Text = "";
        }
    }
}
