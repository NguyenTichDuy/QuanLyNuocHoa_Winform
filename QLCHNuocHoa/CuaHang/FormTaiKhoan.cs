using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHang
{
    public partial class FormTaiKhoan : Form
    {
        
        int i = 0;
        public FormTaiKhoan()
        {
            InitializeComponent();
            Check.checkexit = true;
            lbltaikhoan.Text = Save.account + " Account";
            showText();
            
            timer1.Start();
 

        }
        void showText()
        {
            float tk1 = (float)lblxinchao.Size.Height / 100 * 60;
            lblxinchao.Font = new System.Drawing.Font(lblxinchao.Font.FontFamily, tk1);

            float tk2 = (float)lbltaikhoan.Size.Height / 100 * 40;
            lbltaikhoan.Font = new System.Drawing.Font(lbltaikhoan.Font.FontFamily, tk2);
        }
        
            void resize()
            {
                Save.height = this.Height;

                Save.width = this.Width;
                Save.point = this.Location;
            }
       
        void showsize()
        {
            this.Height = Save.height;
            this.Width = Save.width;
            this.Location = Save.point;



        }
      
        private void FormTaiKhoan_Resize(object sender, EventArgs e)
        {
            showText();
            
        }

        private void Btntrolai_Click(object sender, EventArgs e)
        {
            Check.checkexit = false;
            this.Close();
        }

        private void FormTaiKhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                Check.size = true;    
            else
                Check.size = false;
         
        }

        private void FormTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            resize();
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if(i==0)
            {
                //lblxinchao.ForeColor = Color.LimeGreen;
                lbltaikhoan.ForeColor = Color.Red;
            }
            else if (i == 1)
            {
                //lblxinchao.ForeColor = Color.Red;
                lbltaikhoan.ForeColor = Color.LightBlue;
            }
            else if (i == 2)
            {
               // lblxinchao.ForeColor = Color.Snow;
                lbltaikhoan.ForeColor = Color.Black;
            }
            else if (i == 3)
            {
                //lblxinchao.ForeColor = Color.Yellow;
                lbltaikhoan.ForeColor = Color.White;
                i = -1;
            }
        }

        private void Btndoimk_Click(object sender, EventArgs e)
        {
            FormDoiMK fd = new FormDoiMK();
            fd.ShowDialog();
        }

        private void Btntatca_Click(object sender, EventArgs e)
        {

            if (Save.account == "Admin" || Save.account == "admin")
            {
                FormTatCaTK ftc = new FormTatCaTK();
                ftc.ShowDialog();
            }
            else
                MessageBox.Show("Chỉ có thể truy cập bằng quyền admin!!");
         

        }

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            showsize();
        }
    }
}
