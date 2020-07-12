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
    public partial class MyForm : Form
    {
        int PanelWidth;
        bool isCollapsed;
        ucBanHang ucBanHang;
        uc_KhoHang ucKhoHang;
        uc_TaiKhoan ucTaiKhoa;
        uc_CaiDat ucCaiDat;
        public MyForm()
        {
            InitializeComponent();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 70;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }    
            }    
            else
            {
                panelLeft.Width = panelLeft.Width - 70;
                if (panelLeft.Width <= 75)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }    
            }    
        }
        private void movePannel(Control btn)
        {
            panelTruot.Top = btn.Top;
            panelTruot.Height = btn.Height;
        }
        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnControl.Controls.Clear();
            pnControl.Controls.Add(c);
        }
        private void btnBanHang_Click(object sender, EventArgs e)
        {
            movePannel(btnBanHang);
            AddControlsToPanel(ucBanHang);
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            movePannel(btnKhoHang);
            AddControlsToPanel(ucKhoHang);

        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            movePannel(btnTaiKhoan);
            AddControlsToPanel(ucTaiKhoa);
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            movePannel(btnCaiDat);
            AddControlsToPanel(ucCaiDat);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lbTime.Text = dateTime.ToString("HH:MM:ss");
        }

        private void MyForm_Load(object sender, EventArgs e)
        {
            timer2.Start();
            ucBanHang = new ucBanHang();
            ucKhoHang = new uc_KhoHang();
            ucTaiKhoa = new uc_TaiKhoan();
            ucTaiKhoa.lbAccount.Text = this.lbTaiKhoan.Text;
            ucTaiKhoa.btnDangXuat.Click += (object s, EventArgs ev) =>
            {
                
                this.Close();
            };
            ucCaiDat = new uc_CaiDat();
            AddControlsToPanel(ucBanHang);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
