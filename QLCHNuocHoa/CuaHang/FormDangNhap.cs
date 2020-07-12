using Guna.UI2.WinForms;
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
        public ucDangNhap ucDangNhap;
        ucQuenMatKhau ucQuenMatKhau;
        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            ucDangNhap = new ucDangNhap();
            ucQuenMatKhau = new ucQuenMatKhau();
            AddControlsToPanel(ucDangNhap);
            ucDangNhap.btDangNhap.Click += (object s, EventArgs ev) =>
            {
                Guna2Button btn = s as Guna2Button;
                if (btn == null)
                    return;
                if (ucDangNhap.checkSucess)
                {
                    this.Hide();
                }
            };
        }

        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {
            AddControlsToPanel(ucQuenMatKhau);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            AddControlsToPanel(ucDangNhap);
        }
        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelDangNhap.Controls.Clear();
            panelDangNhap.Controls.Add(c);
        }
    }
}
