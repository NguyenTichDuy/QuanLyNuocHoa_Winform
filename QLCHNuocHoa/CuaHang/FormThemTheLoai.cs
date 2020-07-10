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
    public partial class FormThemTheLoai : Form
    {
        public FormThemTheLoai()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tbMaTheLoai.Text = "";
            tbTenTheLoai.Text = "";
        }
        private bool check()
        {
            string str = "Không được để trống dòng này";
            if (tbMaTheLoai.Text == null)
            {
                lbCMaTheLoai.Text = str;
                return true;
            }    
            else
            {
                if(Regex.IsMatch(tbMaTheLoai.Text, @"^\d+$"))
                {
                    lbCMaTheLoai.Text = "";
                }    
                else
                {
                    lbCMaTheLoai.Text = "Vui lòng nhập số";
                    return true;
                }    
            }
            if (tbTenTheLoai.Text == null)
            {
                lbCTenTheLoai.Text = str;
                return true;
            }
            else
                lbCTenTheLoai.Text = "";
            
            return false;
        }
        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            if (check())
                return;
            TheLoai theLoai = new TheLoai();
            theLoai.MaTheLoai = Convert.ToInt32(tbMaTheLoai.Text);
            theLoai.TenTheLoai = tbTenTheLoai.Text;
            Dbo.getObject().TheLoais.Add(theLoai);
            Dbo.getObject().SaveChanges();
            this.Close();
        }
    }
}
