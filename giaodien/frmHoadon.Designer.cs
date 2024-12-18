namespace giaodien
{
    partial class frmHoadon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoadon));
            this.label10 = new System.Windows.Forms.Label();
            this.btnThanhtoan = new System.Windows.Forms.Button();
            this.grpTT = new System.Windows.Forms.GroupBox();
            this.cmbPTTT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtNgaytao = new System.Windows.Forms.DateTimePicker();
            this.txtMaDH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataHD = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.lbTT = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(82, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(223, 49);
            this.label10.TabIndex = 36;
            this.label10.Text = "HÓA ĐƠN";
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.BackColor = System.Drawing.Color.Sienna;
            this.btnThanhtoan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThanhtoan.Location = new System.Drawing.Point(253, 190);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(125, 34);
            this.btnThanhtoan.TabIndex = 34;
            this.btnThanhtoan.Text = "Thanh toán";
            this.btnThanhtoan.UseVisualStyleBackColor = false;
            // 
            // grpTT
            // 
            this.grpTT.Controls.Add(this.lbTT);
            this.grpTT.Controls.Add(this.cmbPTTT);
            this.grpTT.Controls.Add(this.label3);
            this.grpTT.Controls.Add(this.dtNgaytao);
            this.grpTT.Controls.Add(this.txtMaDH);
            this.grpTT.Controls.Add(this.label6);
            this.grpTT.Controls.Add(this.label4);
            this.grpTT.Controls.Add(this.label2);
            this.grpTT.Controls.Add(this.txtTenNV);
            this.grpTT.Controls.Add(this.label1);
            this.grpTT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grpTT.Location = new System.Drawing.Point(12, 61);
            this.grpTT.Name = "grpTT";
            this.grpTT.Size = new System.Drawing.Size(900, 123);
            this.grpTT.TabIndex = 32;
            this.grpTT.TabStop = false;
            this.grpTT.Text = "Thông tin";
            // 
            // cmbPTTT
            // 
            this.cmbPTTT.FormattingEnabled = true;
            this.cmbPTTT.Location = new System.Drawing.Point(579, 82);
            this.cmbPTTT.Name = "cmbPTTT";
            this.cmbPTTT.Size = new System.Drawing.Size(160, 30);
            this.cmbPTTT.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "PTTT";
            // 
            // dtNgaytao
            // 
            this.dtNgaytao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaytao.Location = new System.Drawing.Point(725, 28);
            this.dtNgaytao.Name = "dtNgaytao";
            this.dtNgaytao.Size = new System.Drawing.Size(160, 30);
            this.dtNgaytao.TabIndex = 19;
            // 
            // txtMaDH
            // 
            this.txtMaDH.Location = new System.Drawing.Point(132, 31);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.Size = new System.Drawing.Size(133, 30);
            this.txtMaDH.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tổng tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SeaShell;
            this.label4.Location = new System.Drawing.Point(595, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ngày tạo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã đơn hàng";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(440, 31);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(133, 30);
            this.txtTenNV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhân viên";
            // 
            // dataHD
            // 
            this.dataHD.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHD.Location = new System.Drawing.Point(8, 29);
            this.dataHD.Name = "dataHD";
            this.dataHD.RowHeadersWidth = 51;
            this.dataHD.RowTemplate.Height = 24;
            this.dataHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataHD.Size = new System.Drawing.Size(886, 125);
            this.dataHD.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Sienna;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(497, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 34);
            this.button1.TabIndex = 40;
            this.button1.Text = "Chi tiết hóa đơn";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lbTT
            // 
            this.lbTT.AutoSize = true;
            this.lbTT.Location = new System.Drawing.Point(333, 90);
            this.lbTT.Name = "lbTT";
            this.lbTT.Size = new System.Drawing.Size(20, 22);
            this.lbTT.TabIndex = 22;
            this.lbTT.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(880, 107);
            this.dataGridView1.TabIndex = 41;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 164);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataHD);
            this.groupBox2.Location = new System.Drawing.Point(12, 400);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(900, 160);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // frmHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(924, 572);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThanhtoan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.grpTT);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHoadon";
            this.Text = "frmHoadon";
            this.grpTT.ResumeLayout(false);
            this.grpTT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnThanhtoan;
        private System.Windows.Forms.GroupBox grpTT;
        private System.Windows.Forms.DateTimePicker dtNgaytao;
        private System.Windows.Forms.TextBox txtMaDH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataHD;
        private System.Windows.Forms.ComboBox cmbPTTT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbTT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}