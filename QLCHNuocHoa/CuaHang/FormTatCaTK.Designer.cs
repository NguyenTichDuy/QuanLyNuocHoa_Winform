namespace CuaHang
{
    partial class FormTatCaTK
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.pnlmain = new System.Windows.Forms.Panel();
            this.btnhuy = new System.Windows.Forms.Button();
            this.lbltk = new System.Windows.Forms.Label();
            this.tbxtk = new System.Windows.Forms.TextBox();
            this.lblmk = new System.Windows.Forms.Label();
            this.tbxmk = new System.Windows.Forms.TextBox();
            this.btnthem2 = new System.Windows.Forms.Button();
            this.btnthoat2 = new System.Windows.Forms.Button();
            this.lblmkp = new System.Windows.Forms.Label();
            this.tbxMaKhoiPhuc = new System.Windows.Forms.TextBox();
            this.tenDangNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourcetaikhoan = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcetaikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenDangNhapDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourcetaikhoan;
            this.dataGridView1.Location = new System.Drawing.Point(9, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(366, 317);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.Snow;
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(89, 12);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 25);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm mới";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.Btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.Snow;
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(191, 12);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 25);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.Btnxoa_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.Snow;
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(291, 12);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 25);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.Btnthoat_Click);
            // 
            // pnlmain
            // 
            this.pnlmain.BackColor = System.Drawing.Color.Transparent;
            this.pnlmain.Controls.Add(this.btnthoat);
            this.pnlmain.Controls.Add(this.btnthem);
            this.pnlmain.Controls.Add(this.btnxoa);
            this.pnlmain.Location = new System.Drawing.Point(9, 344);
            this.pnlmain.Name = "pnlmain";
            this.pnlmain.Size = new System.Drawing.Size(366, 43);
            this.pnlmain.TabIndex = 4;
            // 
            // btnhuy
            // 
            this.btnhuy.BackColor = System.Drawing.Color.Snow;
            this.btnhuy.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.Location = new System.Drawing.Point(197, 481);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 25);
            this.btnhuy.TabIndex = 9;
            this.btnhuy.TabStop = false;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = false;
            this.btnhuy.Click += new System.EventHandler(this.Btnhuy_Click);
            // 
            // lbltk
            // 
            this.lbltk.AutoSize = true;
            this.lbltk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltk.Location = new System.Drawing.Point(9, 354);
            this.lbltk.Name = "lbltk";
            this.lbltk.Size = new System.Drawing.Size(76, 15);
            this.lbltk.TabIndex = 5;
            this.lbltk.Text = "Tài Khoản:";
            // 
            // tbxtk
            // 
            this.tbxtk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxtk.Location = new System.Drawing.Point(127, 346);
            this.tbxtk.Multiline = true;
            this.tbxtk.Name = "tbxtk";
            this.tbxtk.Size = new System.Drawing.Size(245, 24);
            this.tbxtk.TabIndex = 4;
            this.tbxtk.TabStop = false;
            // 
            // lblmk
            // 
            this.lblmk.AutoSize = true;
            this.lblmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmk.Location = new System.Drawing.Point(9, 402);
            this.lblmk.Name = "lblmk";
            this.lblmk.Size = new System.Drawing.Size(72, 15);
            this.lblmk.TabIndex = 4;
            this.lblmk.Text = "Mật Khẩu:";
            // 
            // tbxmk
            // 
            this.tbxmk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxmk.Location = new System.Drawing.Point(127, 393);
            this.tbxmk.Multiline = true;
            this.tbxmk.Name = "tbxmk";
            this.tbxmk.Size = new System.Drawing.Size(245, 24);
            this.tbxmk.TabIndex = 5;
            this.tbxmk.TabStop = false;
            // 
            // btnthem2
            // 
            this.btnthem2.BackColor = System.Drawing.Color.Snow;
            this.btnthem2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem2.Location = new System.Drawing.Point(95, 481);
            this.btnthem2.Name = "btnthem2";
            this.btnthem2.Size = new System.Drawing.Size(75, 25);
            this.btnthem2.TabIndex = 7;
            this.btnthem2.TabStop = false;
            this.btnthem2.Text = "Thêm";
            this.btnthem2.UseVisualStyleBackColor = false;
            this.btnthem2.Click += new System.EventHandler(this.Btnthem2_Click);
            // 
            // btnthoat2
            // 
            this.btnthoat2.BackColor = System.Drawing.Color.Snow;
            this.btnthoat2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat2.Location = new System.Drawing.Point(297, 481);
            this.btnthoat2.Name = "btnthoat2";
            this.btnthoat2.Size = new System.Drawing.Size(75, 25);
            this.btnthoat2.TabIndex = 3;
            this.btnthoat2.TabStop = false;
            this.btnthoat2.Text = "Thoát";
            this.btnthoat2.UseVisualStyleBackColor = false;
            this.btnthoat2.Click += new System.EventHandler(this.Btnthoat2_Click);
            // 
            // lblmkp
            // 
            this.lblmkp.AutoSize = true;
            this.lblmkp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmkp.Location = new System.Drawing.Point(6, 446);
            this.lblmkp.Name = "lblmkp";
            this.lblmkp.Size = new System.Drawing.Size(97, 15);
            this.lblmkp.TabIndex = 10;
            this.lblmkp.Text = "Mã khôi phục:";
            // 
            // tbxMaKhoiPhuc
            // 
            this.tbxMaKhoiPhuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaKhoiPhuc.Location = new System.Drawing.Point(127, 437);
            this.tbxMaKhoiPhuc.Multiline = true;
            this.tbxMaKhoiPhuc.Name = "tbxMaKhoiPhuc";
            this.tbxMaKhoiPhuc.Size = new System.Drawing.Size(245, 24);
            this.tbxMaKhoiPhuc.TabIndex = 6;
            this.tbxMaKhoiPhuc.TabStop = false;
            this.tbxMaKhoiPhuc.Visible = false;
            // 
            // tenDangNhapDataGridViewTextBoxColumn
            // 
            this.tenDangNhapDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenDangNhapDataGridViewTextBoxColumn.DataPropertyName = "TenDangNhap";
            this.tenDangNhapDataGridViewTextBoxColumn.HeaderText = "Tài Khoản";
            this.tenDangNhapDataGridViewTextBoxColumn.Name = "tenDangNhapDataGridViewTextBoxColumn";
            this.tenDangNhapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourcetaikhoan
            // 
            this.bindingSourcetaikhoan.DataSource = typeof(CuaHang.TaiKhoan);
            // 
            // FormTatCaTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(384, 521);
            this.Controls.Add(this.tbxMaKhoiPhuc);
            this.Controls.Add(this.lblmkp);
            this.Controls.Add(this.btnthoat2);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.pnlmain);
            this.Controls.Add(this.tbxmk);
            this.Controls.Add(this.btnthem2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbxtk);
            this.Controls.Add(this.lblmk);
            this.Controls.Add(this.lbltk);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTatCaTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Việt Hàn Store";
            this.Load += new System.EventHandler(this.FormTatCaTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlmain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcetaikhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDangNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSourcetaikhoan;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Panel pnlmain;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Label lbltk;
        private System.Windows.Forms.TextBox tbxtk;
        private System.Windows.Forms.Label lblmk;
        private System.Windows.Forms.TextBox tbxmk;
        private System.Windows.Forms.Button btnthem2;
        private System.Windows.Forms.Button btnthoat2;
        private System.Windows.Forms.Label lblmkp;
        private System.Windows.Forms.TextBox tbxMaKhoiPhuc;
    }
}