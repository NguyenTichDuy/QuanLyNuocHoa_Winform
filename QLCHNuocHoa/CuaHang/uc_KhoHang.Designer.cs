namespace CuaHang
{
    partial class uc_KhoHang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dataGridViewKhoHang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TenTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMTEditDelete = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnThemSanPham = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemLoai = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNuocHoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNuocHoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanHieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xuatXuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongHienTaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dungTichDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nuocHoaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhoHang)).BeginInit();
            this.CMTEditDelete.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuocHoaBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.dataGridViewKhoHang);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(896, 507);
            this.guna2Panel1.TabIndex = 0;
            // 
            // dataGridViewKhoHang
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewKhoHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewKhoHang.AutoGenerateColumns = false;
            this.dataGridViewKhoHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKhoHang.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewKhoHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewKhoHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewKhoHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewKhoHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewKhoHang.ColumnHeadersHeight = 40;
            this.dataGridViewKhoHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNuocHoaDataGridViewTextBoxColumn,
            this.tenNuocHoaDataGridViewTextBoxColumn,
            this.TenTheLoai,
            this.nhanHieuDataGridViewTextBoxColumn,
            this.xuatXuDataGridViewTextBoxColumn,
            this.soLuongHienTaiDataGridViewTextBoxColumn,
            this.dungTichDataGridViewTextBoxColumn,
            this.giaTienDataGridViewTextBoxColumn});
            this.dataGridViewKhoHang.ContextMenuStrip = this.CMTEditDelete;
            this.dataGridViewKhoHang.DataSource = this.nuocHoaBindingSource2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewKhoHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewKhoHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewKhoHang.EnableHeadersVisualStyles = false;
            this.dataGridViewKhoHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewKhoHang.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewKhoHang.Name = "dataGridViewKhoHang";
            this.dataGridViewKhoHang.RowHeadersVisible = false;
            this.dataGridViewKhoHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKhoHang.Size = new System.Drawing.Size(896, 424);
            this.dataGridViewKhoHang.TabIndex = 1;
            this.dataGridViewKhoHang.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridViewKhoHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewKhoHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewKhoHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewKhoHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewKhoHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewKhoHang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewKhoHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewKhoHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewKhoHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewKhoHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewKhoHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewKhoHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewKhoHang.ThemeStyle.HeaderStyle.Height = 40;
            this.dataGridViewKhoHang.ThemeStyle.ReadOnly = false;
            this.dataGridViewKhoHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewKhoHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewKhoHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewKhoHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewKhoHang.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridViewKhoHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewKhoHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewKhoHang.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewKhoHang_CellMouseDown);
            // 
            // TenTheLoai
            // 
            this.TenTheLoai.DataPropertyName = "TenTheLoai";
            this.TenTheLoai.FillWeight = 101.8107F;
            this.TenTheLoai.HeaderText = "Tên thể loại";
            this.TenTheLoai.Name = "TenTheLoai";
            this.TenTheLoai.ReadOnly = true;
            this.TenTheLoai.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CMTEditDelete
            // 
            this.CMTEditDelete.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CMTEditDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CMTEditDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.CMTEditDelete.Name = "CMTEditDelete";
            this.CMTEditDelete.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CMTEditDelete.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.CMTEditDelete.RenderStyle.ColorTable = null;
            this.CMTEditDelete.RenderStyle.RoundedEdges = true;
            this.CMTEditDelete.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.CMTEditDelete.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CMTEditDelete.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CMTEditDelete.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.CMTEditDelete.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.CMTEditDelete.Size = new System.Drawing.Size(110, 56);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(109, 26);
            this.sửaToolStripMenuItem.Text = "Sửa";
            this.sửaToolStripMenuItem.Click += new System.EventHandler(this.sửaToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(109, 26);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 424);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 83);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.94118F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.05882F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 421F));
            this.tableLayoutPanel2.Controls.Add(this.btnThemSanPham, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnThemLoai, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.guna2TextBox1, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(896, 83);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnThemSanPham
            // 
            this.btnThemSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemSanPham.CheckedState.Parent = this.btnThemSanPham;
            this.btnThemSanPham.CustomImages.Parent = this.btnThemSanPham;
            this.btnThemSanPham.FillColor = System.Drawing.Color.Transparent;
            this.btnThemSanPham.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemSanPham.ForeColor = System.Drawing.Color.White;
            this.btnThemSanPham.HoverState.Parent = this.btnThemSanPham;
            this.btnThemSanPham.Image = global::CuaHang.Properties.Resources.icons8_add_list_48px;
            this.btnThemSanPham.ImageSize = new System.Drawing.Size(40, 40);
            this.btnThemSanPham.Location = new System.Drawing.Point(3, 19);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.ShadowDecoration.Parent = this.btnThemSanPham;
            this.btnThemSanPham.Size = new System.Drawing.Size(139, 44);
            this.btnThemSanPham.TabIndex = 2;
            this.btnThemSanPham.Text = "Thêm sản phẩm";
            this.btnThemSanPham.Click += new System.EventHandler(this.btnThemSanPham_Click);
            // 
            // btnThemLoai
            // 
            this.btnThemLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemLoai.CheckedState.Parent = this.btnThemLoai;
            this.btnThemLoai.CustomImages.Parent = this.btnThemLoai;
            this.btnThemLoai.FillColor = System.Drawing.Color.Transparent;
            this.btnThemLoai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemLoai.ForeColor = System.Drawing.Color.White;
            this.btnThemLoai.HoverState.Parent = this.btnThemLoai;
            this.btnThemLoai.Image = global::CuaHang.Properties.Resources.icons8_add_database_48px;
            this.btnThemLoai.ImageSize = new System.Drawing.Size(35, 35);
            this.btnThemLoai.Location = new System.Drawing.Point(148, 19);
            this.btnThemLoai.Name = "btnThemLoai";
            this.btnThemLoai.ShadowDecoration.Parent = this.btnThemLoai;
            this.btnThemLoai.Size = new System.Drawing.Size(151, 44);
            this.btnThemLoai.TabIndex = 3;
            this.btnThemLoai.Text = "Thêm Loại";
            this.btnThemLoai.Click += new System.EventHandler(this.btnThemLoai_Click_1);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2TextBox1.BorderRadius = 12;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.IconLeft = global::CuaHang.Properties.Resources.icons8_search_128px_31;
            this.guna2TextBox1.IconLeftSize = new System.Drawing.Size(30, 30);
            this.guna2TextBox1.Location = new System.Drawing.Point(585, 23);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Tìm kiếm";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(200, 36);
            this.guna2TextBox1.TabIndex = 4;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TheLoai";
            this.dataGridViewTextBoxColumn1.FillWeight = 101.8107F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên thể loại";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 896;
            // 
            // maNuocHoaDataGridViewTextBoxColumn
            // 
            this.maNuocHoaDataGridViewTextBoxColumn.DataPropertyName = "MaNuocHoa";
            this.maNuocHoaDataGridViewTextBoxColumn.FillWeight = 101.8107F;
            this.maNuocHoaDataGridViewTextBoxColumn.HeaderText = "Mã nước hoa";
            this.maNuocHoaDataGridViewTextBoxColumn.Name = "maNuocHoaDataGridViewTextBoxColumn";
            this.maNuocHoaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tenNuocHoaDataGridViewTextBoxColumn
            // 
            this.tenNuocHoaDataGridViewTextBoxColumn.DataPropertyName = "TenNuocHoa";
            this.tenNuocHoaDataGridViewTextBoxColumn.FillWeight = 121.8274F;
            this.tenNuocHoaDataGridViewTextBoxColumn.HeaderText = "Tên nước hoa";
            this.tenNuocHoaDataGridViewTextBoxColumn.Name = "tenNuocHoaDataGridViewTextBoxColumn";
            this.tenNuocHoaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nhanHieuDataGridViewTextBoxColumn
            // 
            this.nhanHieuDataGridViewTextBoxColumn.DataPropertyName = "NhanHieu";
            this.nhanHieuDataGridViewTextBoxColumn.FillWeight = 101.8107F;
            this.nhanHieuDataGridViewTextBoxColumn.HeaderText = "Nhãn hiệu";
            this.nhanHieuDataGridViewTextBoxColumn.Name = "nhanHieuDataGridViewTextBoxColumn";
            this.nhanHieuDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // xuatXuDataGridViewTextBoxColumn
            // 
            this.xuatXuDataGridViewTextBoxColumn.DataPropertyName = "XuatXu";
            this.xuatXuDataGridViewTextBoxColumn.FillWeight = 101.8107F;
            this.xuatXuDataGridViewTextBoxColumn.HeaderText = "Xuất xứ";
            this.xuatXuDataGridViewTextBoxColumn.Name = "xuatXuDataGridViewTextBoxColumn";
            this.xuatXuDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // soLuongHienTaiDataGridViewTextBoxColumn
            // 
            this.soLuongHienTaiDataGridViewTextBoxColumn.DataPropertyName = "SoLuongHienTai";
            this.soLuongHienTaiDataGridViewTextBoxColumn.FillWeight = 67.30821F;
            this.soLuongHienTaiDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soLuongHienTaiDataGridViewTextBoxColumn.Name = "soLuongHienTaiDataGridViewTextBoxColumn";
            this.soLuongHienTaiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dungTichDataGridViewTextBoxColumn
            // 
            this.dungTichDataGridViewTextBoxColumn.DataPropertyName = "DungTich";
            this.dungTichDataGridViewTextBoxColumn.FillWeight = 101.8107F;
            this.dungTichDataGridViewTextBoxColumn.HeaderText = "Dung tích";
            this.dungTichDataGridViewTextBoxColumn.Name = "dungTichDataGridViewTextBoxColumn";
            this.dungTichDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // giaTienDataGridViewTextBoxColumn
            // 
            this.giaTienDataGridViewTextBoxColumn.DataPropertyName = "GiaTien";
            this.giaTienDataGridViewTextBoxColumn.FillWeight = 101.8107F;
            this.giaTienDataGridViewTextBoxColumn.HeaderText = "Giá tiền";
            this.giaTienDataGridViewTextBoxColumn.Name = "giaTienDataGridViewTextBoxColumn";
            this.giaTienDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nuocHoaBindingSource2
            // 
            this.nuocHoaBindingSource2.DataSource = typeof(CuaHang.NuocHoa);
            // 
            // uc_KhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "uc_KhoHang";
            this.Size = new System.Drawing.Size(896, 507);
            this.Load += new System.EventHandler(this.uc_KhoHang_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhoHang)).EndInit();
            this.CMTEditDelete.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nuocHoaBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Button btnThemSanPham;
        private Guna.UI2.WinForms.Guna2Button btnThemLoai;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI.WinForms.GunaContextMenuStrip CMTEditDelete;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewKhoHang;
        private System.Windows.Forms.BindingSource nuocHoaBindingSource2;

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNuocHoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNuocHoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhanHieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xuatXuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongHienTaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dungTichDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTienDataGridViewTextBoxColumn;
    }
}
