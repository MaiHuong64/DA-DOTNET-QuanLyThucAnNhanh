namespace giaodien
{
    partial class frmChitietHoadon
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
            this.dataCTHD = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // dataCTHD
            // 
            this.dataCTHD.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCTHD.Location = new System.Drawing.Point(33, 82);
            this.dataCTHD.Name = "dataCTHD";
            this.dataCTHD.RowHeadersWidth = 51;
            this.dataCTHD.RowTemplate.Height = 24;
            this.dataCTHD.Size = new System.Drawing.Size(881, 205);
            this.dataCTHD.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(24, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(428, 49);
            this.label10.TabIndex = 44;
            this.label10.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // frmChitietHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(963, 489);
            this.Controls.Add(this.dataCTHD);
            this.Controls.Add(this.label10);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChitietHoadon";
            this.Text = "frmChitietHoadon";
            ((System.ComponentModel.ISupportInitialize)(this.dataCTHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCTHD;
        private System.Windows.Forms.Label label10;
    }
}