namespace CuaHang
{
    partial class FormChonSL
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudSoluong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnDong = new Guna.UI2.WinForms.Guna2Button();
            this.btnXacNhan = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoluong)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số lượng:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(14, 166);
            this.panel1.TabIndex = 4;
            // 
            // nudSoluong
            // 
            this.nudSoluong.BackColor = System.Drawing.Color.Transparent;
            this.nudSoluong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudSoluong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudSoluong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nudSoluong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nudSoluong.DisabledState.Parent = this.nudSoluong;
            this.nudSoluong.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nudSoluong.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nudSoluong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nudSoluong.FocusedState.Parent = this.nudSoluong;
            this.nudSoluong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoluong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.nudSoluong.Location = new System.Drawing.Point(254, 23);
            this.nudSoluong.Name = "nudSoluong";
            this.nudSoluong.ShadowDecoration.Parent = this.nudSoluong;
            this.nudSoluong.Size = new System.Drawing.Size(100, 36);
            this.nudSoluong.TabIndex = 5;
            this.nudSoluong.ValueChanged += new System.EventHandler(this.nudSoluong_ValueChanged);
            // 
            // btnDong
            // 
            this.btnDong.CheckedState.Parent = this.btnDong;
            this.btnDong.CustomImages.Parent = this.btnDong;
            this.btnDong.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.HoverState.Parent = this.btnDong;
            this.btnDong.Location = new System.Drawing.Point(243, 94);
            this.btnDong.Name = "btnDong";
            this.btnDong.ShadowDecoration.Parent = this.btnDong;
            this.btnDong.Size = new System.Drawing.Size(111, 45);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.CheckedState.Parent = this.btnXacNhan;
            this.btnXacNhan.CustomImages.Parent = this.btnXacNhan;
            this.btnXacNhan.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.HoverState.Parent = this.btnXacNhan;
            this.btnXacNhan.Location = new System.Drawing.Point(67, 94);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.ShadowDecoration.Parent = this.btnXacNhan;
            this.btnXacNhan.Size = new System.Drawing.Size(111, 45);
            this.btnXacNhan.TabIndex = 7;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // FormChonSL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(405, 166);
            this.ControlBox = false;
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.nudSoluong);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChonSL";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.nudSoluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        public Guna.UI2.WinForms.Guna2NumericUpDown nudSoluong;
        private Guna.UI2.WinForms.Guna2Button btnDong;
        private Guna.UI2.WinForms.Guna2Button btnXacNhan;
    }
}