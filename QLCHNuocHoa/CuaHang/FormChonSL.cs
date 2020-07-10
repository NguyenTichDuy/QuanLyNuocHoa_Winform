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
    public partial class FormChonSL : Form
    {
        public FormChonSL()
        {
            InitializeComponent();

        }
        public bool check = true;
        public void nudSoluong_ValueChanged(object sender, EventArgs e)
        {
            Guna2NumericUpDown num = sender as Guna2NumericUpDown;
            if (num != null)
            {
                int a = Convert.ToInt32(num.Value);
     
            }    
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            check = false;
        }
    }
}
