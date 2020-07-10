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
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            i++;
            if (i==12)
            {
                FormDangNhap frmDangNhap = new FormDangNhap();
                frmDangNhap.ShowDialog();
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Save.LoadResource();
        }

    }
}
