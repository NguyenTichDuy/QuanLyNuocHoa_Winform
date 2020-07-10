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
    public partial class FormKhoHang : Form
    {
        BindingSource BindingSourcetheloai = new BindingSource();
        BindingSource BindingSourcetimkiem = new BindingSource();
        public FormKhoHang()
        {
            InitializeComponent();
            Check.checkexit = true;
           
            showsize();
            loadViewSize();
            loadsource();
          




        }
        #region method
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
        void loadsource()
        {
            
            loadSoureNuocHoa();
            clear_bindingthongtin();
            update_bindingsourceNuocHoa();
            

        }

        void loadCbxTheLoai()
        {
            var ls = Dbo.getObject().TheLoais.ToList();

            cbxTheLoai.DataSource = ls;
            cbxTheLoai.DisplayMember = "TenTheLoai";

            
        }

        void loadCbxTheLoai2()
        {
            var l = Dbo.getObject().TheLoais.ToList();
            cbxtheloai2.DataSource = l;
            cbxtheloai2.DisplayMember = "TenTheLoai";
        }

        void clear_bindingthongtin()
        {

            tbxmasp.DataBindings.Clear();
            tbxtensp.DataBindings.Clear();
            tbxtheloai.DataBindings.Clear();
            tbxxuatxu.DataBindings.Clear();
            tbxnhanhieu.DataBindings.Clear();
            tbxsoluong.DataBindings.Clear();
            tbxgiatien.DataBindings.Clear();
            tbxdungtich.DataBindings.Clear();
        }
        void update_bindingsourceNuocHoa()
        {

            tbxmasp.DataBindings.Add("text",bdsNuocHoa, "MaNuocHoa",true,DataSourceUpdateMode.Never);
            tbxtensp.DataBindings.Add("text", bdsNuocHoa, "TenNuocHoa",true, DataSourceUpdateMode.Never);
            tbxtheloai.DataBindings.Add("text", bdsNuocHoa, "TheLoai.TenTheLoai", true, DataSourceUpdateMode.Never);

            tbxxuatxu.DataBindings.Add("text", bdsNuocHoa, "XuatXu",true, DataSourceUpdateMode.Never);
            tbxnhanhieu.DataBindings.Add("text", bdsNuocHoa, "NhanHieu", true, DataSourceUpdateMode.Never);
            tbxsoluong.DataBindings.Add("text", bdsNuocHoa, "SoLuongHienTai", true, DataSourceUpdateMode.Never);
            tbxgiatien.DataBindings.Add("text", bdsNuocHoa, "GiaTien", true, DataSourceUpdateMode.Never);
            tbxdungtich.DataBindings.Add("text", bdsNuocHoa, "DungTich", true, DataSourceUpdateMode.Never);

        }
        void update_bindingsourceTimKiem()
        {

            tbxmasp.DataBindings.Add("text", BindingSourcetimkiem, "MaNuocHoa", true, DataSourceUpdateMode.Never);
            tbxtensp.DataBindings.Add("text", BindingSourcetimkiem, "TenNuocHoa", true, DataSourceUpdateMode.Never);
            tbxtheloai.DataBindings.Add("text", BindingSourcetimkiem, "TheLoai.TenTheLoai", true, DataSourceUpdateMode.Never);
            tbxxuatxu.DataBindings.Add("text", BindingSourcetimkiem, "XuatXu", true, DataSourceUpdateMode.Never);
            tbxnhanhieu.DataBindings.Add("text", BindingSourcetimkiem, "NhanHieu", true, DataSourceUpdateMode.Never);
            tbxsoluong.DataBindings.Add("text", BindingSourcetimkiem, "SoLuongHienTai", true, DataSourceUpdateMode.Never);
            tbxgiatien.DataBindings.Add("text", BindingSourcetimkiem, "GiaTien", true, DataSourceUpdateMode.Never);
            tbxdungtich.DataBindings.Add("text", BindingSourcetimkiem, "DungTich", true, DataSourceUpdateMode.Never);

        }

        void update_bindingsourceTheLoai()
        {

            tbxmasp.DataBindings.Add("text", BindingSourcetheloai, "MaNuocHoa", true, DataSourceUpdateMode.Never);
            tbxtensp.DataBindings.Add("text", BindingSourcetheloai, "TenNuocHoa", true, DataSourceUpdateMode.Never);
            tbxtheloai.DataBindings.Add("text", BindingSourcetheloai, "TheLoai.TenTheLoai", true, DataSourceUpdateMode.Never);


            tbxxuatxu.DataBindings.Add("text", BindingSourcetheloai, "XuatXu", true, DataSourceUpdateMode.Never);
            tbxnhanhieu.DataBindings.Add("text", BindingSourcetheloai, "NhanHieu", true, DataSourceUpdateMode.Never);
            tbxsoluong.DataBindings.Add("text", BindingSourcetheloai, "SoLuongHienTai", true, DataSourceUpdateMode.Never);
            tbxgiatien.DataBindings.Add("text", BindingSourcetheloai, "GiaTien", true, DataSourceUpdateMode.Never);
            tbxdungtich.DataBindings.Add("text", BindingSourcetheloai, "DungTich", true, DataSourceUpdateMode.Never);

        }

        void loadSoureNuocHoa()
        {
            bdsNuocHoa.DataSource = Dbo.getObject().NuocHoa.ToList();
            if(dataGridView1.DataSource!=bdsNuocHoa)
            {
                dataGridView1.DataSource = bdsNuocHoa;

                clear_bindingthongtin();
                update_bindingsourceNuocHoa();
            }

           

        }

        void loadsourceTimKiem()
        {
            BindingSourcetimkiem.DataSource = (from c in Dbo.getObject().NuocHoa
                                               where (c.MaNuocHoa.StartsWith(tbxTimKiem.Text) || c.TenNuocHoa.Contains(tbxTimKiem.Text))
                                               select c).ToList();
           
            if (dataGridView1.DataSource != BindingSourcetimkiem)
            {
                dataGridView1.DataSource = BindingSourcetimkiem;
                clear_bindingthongtin();
                update_bindingsourceTimKiem();

            }
        }

        void loadsourcetheloai()
        {
            BindingSourcetheloai.DataSource =( from c in Dbo.getObject().NuocHoa where c.TheLoai.TenTheLoai == cbxTheLoai.Text
                                               select c).ToList();
            if (dataGridView1.DataSource != BindingSourcetheloai)
            {
                tbxTimKiem.Text = "";
                dataGridView1.DataSource = BindingSourcetheloai;
                clear_bindingthongtin();
                update_bindingsourceTheLoai();
            }
        }

         void loadCurentSource()
        {
            if (dataGridView1.DataSource == bdsNuocHoa)
                loadSoureNuocHoa();
            else if (dataGridView1.DataSource == BindingSourcetheloai)
                loadsourcetheloai();
            else if (dataGridView1.DataSource == BindingSourcetimkiem)
                loadsourceTimKiem();
        }
        

        void loadViewSize()
        {
            try
            {
                float s = (float)tbxTimKiem.Size.Height / 100 * 50;
                
                tbxTimKiem.Font = new System.Drawing.Font(tbxTimKiem.Font.FontFamily, s);
                cbxTheLoai.Font = new System.Drawing.Font(cbxTheLoai.Font.FontFamily, s);

                dataGridView1.Columns[0].Width = (dataGridView1.Size.Width / 10) * 4;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                float z = (float)tbxmasp.Size.Height / 100 * 50;
                tbxmasp.Font = new System.Drawing.Font(tbxTimKiem.Font.FontFamily, z);
                tbxtensp.Font = new System.Drawing.Font(tbxTimKiem.Font.FontFamily, z);
                tbxxuatxu.Font = new System.Drawing.Font(tbxTimKiem.Font.FontFamily, z);
                tbxnhanhieu.Font = new System.Drawing.Font(tbxTimKiem.Font.FontFamily, z);
                tbxdungtich.Font = new System.Drawing.Font(tbxTimKiem.Font.FontFamily, z);
                tbxtheloai.Font = new System.Drawing.Font(tbxTimKiem.Font.FontFamily, z);
                tbxgiatien.Font = new System.Drawing.Font(tbxTimKiem.Font.FontFamily, z);
                tbxsoluong.Font = new System.Drawing.Font(tbxTimKiem.Font.FontFamily, z);
                tbxsoluong.Font = new System.Drawing.Font(tbxTimKiem.Font.FontFamily, z);
                cbxtheloai2.Font = new System.Drawing.Font(tbxTimKiem.Font.FontFamily, z);
                nudSoluong.Font = new System.Drawing.Font(tbxTimKiem.Font.FontFamily, z);

                float k = (float)tbxmasp.Size.Height / 100 * 38;
                btnTatCa.Font = new System.Drawing.Font(tbxTimKiem.Font.FontFamily, k);
                btntheloai.Font = new System.Drawing.Font(tbxTimKiem.Font.FontFamily, k);
                btnthem.Font = new System.Drawing.Font(tbxTimKiem.Font.FontFamily, k);
                btnsua.Font = new System.Drawing.Font(tbxTimKiem.Font.FontFamily, k);
                btnxacnhan.Font = new System.Drawing.Font(tbxTimKiem.Font.FontFamily, k);
                btnxoa.Font = new System.Drawing.Font(tbxTimKiem.Font.FontFamily, k);
                btnhuy.Font = new System.Drawing.Font(tbxTimKiem.Font.FontFamily, k);
                btntrolai.Font = new System.Drawing.Font(tbxTimKiem.Font.FontFamily, k);
                btncongtru.Font = new System.Drawing.Font(tbxTimKiem.Font.FontFamily, k);

                float h = (float)tbxmasp.Size.Height / 100 * 39;
                dataGridView1.Font = new System.Drawing.Font(tbxTimKiem.Font.FontFamily, h);
            }
            catch { }



        }

        void ReadonlyThongTin()
        {
            btnTatCa.Enabled = true;
            tbxTimKiem.Enabled = true;
            cbxTheLoai.Enabled = true;
            btntheloai.Enabled = true;

            dataGridView1.Enabled = true;
            tbxmasp.ReadOnly = true;
            tbxmasp.TabStop = false;
            tbxtensp.ReadOnly = true;
            tbxtheloai.ReadOnly = true;
            tbxdungtich.ReadOnly = true;
            tbxxuatxu.ReadOnly = true;
            tbxnhanhieu.ReadOnly = true;
            tbxsoluong.ReadOnly = true;
            tbxgiatien.ReadOnly = true;

            cbxtheloai2.Visible = false;
            nudSoluong.Visible = false;
            nudSoluong.Value = 0;
            btncongtru.Visible = false;

            btnthem.Visible = true;
            btnsua.Visible = true;
            btnxoa.Visible = true;
            btntrolai.Visible = true;

            btnxacnhan.Visible = false;
            btnhuy.Visible = false;

            cbxtheloai2.Text = "";

            
        }

        void chinhsua()
        {
            btnTatCa.Enabled = false;
            tbxTimKiem.Enabled = false;
            cbxTheLoai.Enabled = false;
            btntheloai.Enabled = false;

            dataGridView1.Enabled = false;
         
            tbxtensp.ReadOnly = false;
            tbxtheloai.ReadOnly = true;
            tbxdungtich.ReadOnly = false;
            tbxxuatxu.ReadOnly = false;
            tbxnhanhieu.ReadOnly = false;
            tbxsoluong.ReadOnly = false;
            tbxgiatien.ReadOnly = false;

            cbxtheloai2.Visible = true;
            nudSoluong.Visible = true;
            btncongtru.Visible = true;

            btnthem.Visible = false;
            btnsua.Visible = false;
            btnxoa.Visible = false;
            btntrolai.Visible = false;

            btnxacnhan.Visible = true;
            btnhuy.Visible = true;

           

        }
        void chinhsua2()
        {
            btnTatCa.Enabled = false;
            tbxTimKiem.Enabled = false;
            cbxTheLoai.Enabled = false;
            btntheloai.Enabled = false;

            dataGridView1.Enabled = false;
            tbxmasp.TabStop = true;
            tbxmasp.ReadOnly = false;
            tbxtensp.ReadOnly = false;
            tbxtheloai.ReadOnly = true;
            tbxdungtich.ReadOnly = false;
            tbxxuatxu.ReadOnly = false;
            tbxnhanhieu.ReadOnly = false;
            tbxsoluong.ReadOnly = false;
            tbxgiatien.ReadOnly = false;

            cbxtheloai2.Visible = true;
            nudSoluong.Visible = true;
            btncongtru.Visible = true;

            btnthem.Visible = false;
            btnsua.Visible = false;
            btnxoa.Visible = false;
            btntrolai.Visible = false;

            btnxacnhan.Visible = true;
            btnhuy.Visible = true;



        }
        void clearThongTin()
        {
            tbxmasp.Text = "";
            tbxtensp.Text = "";
            tbxtheloai.Text = "";
            tbxnhanhieu.Text = "";
            tbxxuatxu.Text = "";
            tbxdungtich.Text = "";
            tbxsoluong.Text = "";
            tbxgiatien.Text = "";



        }
        #endregion



        #region event
        private void FormKhoHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            resize();
        }

        private void FormKhoHang_Resize(object sender, EventArgs e)
        {
            
            loadViewSize();

        }

        private void Btntrolai_Click(object sender, EventArgs e)
        {
            Check.checkexit = false;
            this.Close();
        }

      

        private void Btnhuy_Click(object sender, EventArgs e)
        {
            ReadonlyThongTin();
            loadCurentSource();

        }

        private void TbxTimKiem_TextChanged(object sender, EventArgs e)
        {
            
            loadsourceTimKiem();
            cbxTheLoai.Text = "";
        }

        private void BtnTatCa_Click(object sender, EventArgs e)
        {
            loadSoureNuocHoa();
            cbxTheLoai.Text = "";
            tbxTimKiem.Text = "";
        }

        private void CbxTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            loadsourcetheloai();

        }

        private void CbxTheLoai_DropDown(object sender, EventArgs e)
        {
            loadCbxTheLoai();
        }


        

        private void Cbxtheloai2_DropDown(object sender, EventArgs e)
        {
            loadCbxTheLoai2();
        }
        private void Cbxtheloai2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxtheloai.Text = cbxtheloai2.Text;
        }

        

      
        private void Btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                var lst = (from c in Dbo.getObject().ChiTietHoaDon
                           where c.MaNuocHoa == tbxmasp.Text
                           select c).ToList();

                if (lst.Count > 0)
                    MessageBox.Show("Không thể xóa sản phẩm này");

                else if (MessageBox.Show("Bạn có muốn tiếp tục xóa sản phẩm " + tbxmasp.Text, "", MessageBoxButtons.OKCancel)
                                            == System.Windows.Forms.DialogResult.OK)
                {
                    NuocHoa nh = Dbo.getObject().NuocHoa.Find(tbxmasp.Text);
                    Dbo.getObject().NuocHoa.Remove(nh);
                    Dbo.getObject().SaveChanges();
                    loadCurentSource();
                }
            }
            catch { }
        }
   

       
        private void Btncongtru_Click_1(object sender, EventArgs e)
        {
            try
            {
                decimal sl1 = decimal.Parse(tbxsoluong.Text);
                sl1 += nudSoluong.Value;
                if (sl1 < 0)
                {
                    MessageBox.Show("số lượng không đúng");
                    sl1 -= nudSoluong.Value;
                }
                else
                    tbxsoluong.Text = sl1.ToString();
            }
            catch { }
        }


       


        private void Btnthem_Click(object sender, EventArgs e)
        {
            Check.checkstatus = 1;
            clearThongTin();
            chinhsua2();
          
            btncongtru.Visible = false;
            nudSoluong.Visible = false;
        }

        private void Btnsua_Click_1(object sender, EventArgs e)
        {
            Check.checkstatus = 2;
            chinhsua();
            Save.s1 = tbxmasp.Text;

        }

        private void Btnxacnhan_Click(object sender, EventArgs e)
        {
            if (Check.checkstatus == 1)
            {
                try
                {
                    float gt = 0;
                    int sl = 0;
                    Boolean kt = true;

                    NuocHoa n = Dbo.getObject().NuocHoa.Find(tbxmasp.Text);
                    if (n != null)
                    {
                        MessageBox.Show("Mã Sản phẩm không được trùng");
                        kt = false;
                    }


                    if (kt)
                    {
                        if (tbxmasp.Text.Length == 0 || tbxmasp.Text.Length > 20)
                            MessageBox.Show("Mã sản phẩm không được trống hoặc quá dài");
                        else if (tbxtensp.Text.Length == 0 || tbxtensp.Text.Length > 50)
                            MessageBox.Show("Tên sản phẩm không được trống hoặc quá dài");
                        else if (tbxnhanhieu.Text.Length > 30)
                            MessageBox.Show("Tên nhãn hiệu không được quá dài");
                        else if (tbxtheloai.Text == "")
                            MessageBox.Show("Thể loại không được bỏ trống");
                        else if (tbxxuatxu.Text.Length > 30)
                            MessageBox.Show("Tên xuất hiệu không được quá dài");
                        else if (float.TryParse(tbxgiatien.Text, out gt) == false || gt < 0)
                            MessageBox.Show("Giá tiền không đúng");
                        else if (tbxdungtich.Text.Length > 20)
                            MessageBox.Show("Dung tích quá dài");
                        else if (int.TryParse(tbxsoluong.Text, out sl) == false || sl < 0)
                            MessageBox.Show("Số lượng không đúng");
                        else
                        {
                            TheLoai tl1 = new TheLoai();
                            foreach (TheLoai item in Dbo.getObject().TheLoais)
                            {
                                if (item.TenTheLoai == tbxtheloai.Text)
                                { tl1 = item; break; }
                            }
                            NuocHoa nh1 = new NuocHoa();
                            nh1.MaNuocHoa = tbxmasp.Text;
                            nh1.TenNuocHoa = tbxtensp.Text;
                            nh1.NhanHieu = tbxnhanhieu.Text;
                            nh1.MaTheLoai = tl1.MaTheLoai;
                            nh1.XuatXu = tbxxuatxu.Text;
                            nh1.DungTich = tbxdungtich.Text;
                            nh1.SoLuongHienTai = int.Parse(tbxsoluong.Text);
                            nh1.GiaTien = float.Parse(tbxgiatien.Text);
                            Dbo.getObject().NuocHoa.Add(nh1);
                            Dbo.getObject().SaveChanges();
                            btnhuy.PerformClick();
                            btnTatCa.PerformClick();

                        }
                    }
                }
                catch
                {

                }

            }
            else if (Check.checkstatus == 2)
            {
                try
                {
                    float gt = 0;
                    int sl = 0;
                    Boolean kt = true;
                    if (Save.s1 != tbxmasp.Text)
                    {
                        NuocHoa n = Dbo.getObject().NuocHoa.Find(tbxmasp.Text);
                        if (n != null)
                        {
                            MessageBox.Show("Mã Sản phẩm không được trùng");
                            kt = false;
                        }

                    }

                    if (kt)
                    {
                        if (tbxmasp.Text.Length == 0 || tbxmasp.Text.Length > 20)
                            MessageBox.Show("Mã sản phẩm không được trống hoặc quá dài");
                        else if (tbxtensp.Text.Length == 0 || tbxtensp.Text.Length > 50)
                            MessageBox.Show("Tên sản phẩm không được trống hoặc quá dài");
                        else if (tbxnhanhieu.Text.Length > 30)
                            MessageBox.Show("Tên nhãn hiệu không được quá dài");
                        else if (tbxxuatxu.Text.Length > 30)
                            MessageBox.Show("Tên xuất hiệu không được quá dài");
                        else if (tbxtheloai.Text == "")
                            MessageBox.Show("Thể loại không được bỏ trống");
                        else if (float.TryParse(tbxgiatien.Text, out gt) == false || gt < 0)
                            MessageBox.Show("Giá tiền không đúng");
                        else if (tbxdungtich.Text.Length > 20)
                            MessageBox.Show("Dung tích quá dài");
                        else if (int.TryParse(tbxsoluong.Text, out sl) == false || sl < 0)
                            MessageBox.Show("Số lượng không đúng");
                        else
                        {
                            if (Save.s1 == tbxmasp.Text)
                            {
                                TheLoai tl1 = new TheLoai();
                                foreach (TheLoai item in Dbo.getObject().TheLoais)
                                {
                                    if (item.TenTheLoai == tbxtheloai.Text)
                                    { tl1 = item; break; }
                                }

                                NuocHoa nh1 = Dbo.getObject().NuocHoa.Find(Save.s1);

                                nh1.TenNuocHoa = tbxtensp.Text;
                                nh1.NhanHieu = tbxnhanhieu.Text;
                                nh1.MaTheLoai = tl1.MaTheLoai;
                                nh1.XuatXu = tbxxuatxu.Text;
                                nh1.DungTich = tbxdungtich.Text;
                                nh1.SoLuongHienTai = int.Parse(tbxsoluong.Text);
                                nh1.GiaTien = float.Parse(tbxgiatien.Text);
                                Dbo.getObject().SaveChanges();
                                MessageBox.Show("Cập nhật Thành công!");
                                loadCurentSource();
                            }
                            else
                            {
                                TheLoai tl1 = new TheLoai();
                                foreach (TheLoai item in Dbo.getObject().TheLoais)
                                {
                                    if (item.TenTheLoai == tbxtheloai.Text)
                                    { tl1 = item; break; }
                                }

                                NuocHoa nh = Dbo.getObject().NuocHoa.Find(Save.s1);
                                Dbo.getObject().NuocHoa.Remove(nh);
                                Dbo.getObject().SaveChanges();


                                NuocHoa nh1 = new NuocHoa();
                                nh1.MaNuocHoa = tbxmasp.Text;
                                nh1.TenNuocHoa = tbxtensp.Text;
                                nh1.NhanHieu = tbxnhanhieu.Text;
                                nh1.MaTheLoai = tl1.MaTheLoai;
                                nh1.XuatXu = tbxxuatxu.Text;
                                nh1.DungTich = tbxdungtich.Text;
                                nh1.SoLuongHienTai = int.Parse(tbxsoluong.Text);
                                nh1.GiaTien = float.Parse(tbxgiatien.Text);
                                Dbo.getObject().NuocHoa.Add(nh1);
                                Dbo.getObject().SaveChanges();
                                MessageBox.Show("Cập nhật Thành công!");
                                loadCurentSource();
                                Save.s1 = tbxmasp.Text;

                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Cập nhật thất bại");
                }



            }
        }



        private void Btntheloai_Click(object sender, EventArgs e)
        {
            Check.checkbool = false;
            //FormTheLoai ftl = new FormTheLoai();
            //ftl.ShowDialog();
            if (Check.checkbool)
            {
                btnTatCa.PerformClick();
                Check.checkbool = false;
            }
        }



        #endregion

        private void FormKhoHang_Load(object sender, EventArgs e)
        {

        }
    }
}
