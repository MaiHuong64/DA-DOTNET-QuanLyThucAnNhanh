namespace giaodien
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.lbThucan = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbHome = new System.Windows.Forms.Label();
            this.lbHD = new System.Windows.Forms.Label();
            this.lbOrder = new System.Windows.Forms.Label();
            this.pnDisplay = new System.Windows.Forms.Panel();
            this.grpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMain
            // 
            this.grpMain.BackColor = System.Drawing.Color.Wheat;
            this.grpMain.Controls.Add(this.lbThucan);
            this.grpMain.Controls.Add(this.pictureBox1);
            this.grpMain.Controls.Add(this.lbHome);
            this.grpMain.Controls.Add(this.lbHD);
            this.grpMain.Controls.Add(this.lbOrder);
            this.grpMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grpMain.Location = new System.Drawing.Point(12, 1);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(225, 621);
            this.grpMain.TabIndex = 0;
            this.grpMain.TabStop = false;
            // 
            // lbThucan
            // 
            this.lbThucan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThucan.Location = new System.Drawing.Point(51, 297);
            this.lbThucan.Name = "lbThucan";
            this.lbThucan.Size = new System.Drawing.Size(124, 37);
            this.lbThucan.TabIndex = 30;
            this.lbThucan.Text = "Thức ăn";
            this.lbThucan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbThucan.Click += new System.EventHandler(this.lbThucan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::giaodien.Properties.Resources.food_icon_design_vector_png_120564;
            this.pictureBox1.Location = new System.Drawing.Point(46, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // lbHome
            // 
            this.lbHome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHome.Location = new System.Drawing.Point(54, 159);
            this.lbHome.Name = "lbHome";
            this.lbHome.Size = new System.Drawing.Size(124, 37);
            this.lbHome.TabIndex = 21;
            this.lbHome.Text = "Home";
            this.lbHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbHome.Click += new System.EventHandler(this.lbHome_Click);
            // 
            // lbHD
            // 
            this.lbHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHD.Location = new System.Drawing.Point(54, 225);
            this.lbHD.Name = "lbHD";
            this.lbHD.Size = new System.Drawing.Size(124, 37);
            this.lbHD.TabIndex = 23;
            this.lbHD.Text = "Hóa đơn";
            this.lbHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbHD.Click += new System.EventHandler(this.lbHD_Click);
            // 
            // lbOrder
            // 
            this.lbOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrder.Location = new System.Drawing.Point(51, 368);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(124, 37);
            this.lbOrder.TabIndex = 28;
            this.lbOrder.Text = "Order";
            this.lbOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbOrder.Click += new System.EventHandler(this.lbOrder_Click);
            // 
            // pnDisplay
            // 
            this.pnDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnDisplay.Location = new System.Drawing.Point(243, 12);
            this.pnDisplay.Name = "pnDisplay";
            this.pnDisplay.Size = new System.Drawing.Size(922, 610);
            this.pnDisplay.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1177, 634);
            this.Controls.Add(this.pnDisplay);
            this.Controls.Add(this.grpMain);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.Label lbOrder;
        private System.Windows.Forms.Label lbHome;
        private System.Windows.Forms.Label lbHD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnDisplay;
        private System.Windows.Forms.Label lbThucan;
    }
}

