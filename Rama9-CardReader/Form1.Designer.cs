namespace Rama9_CardReader
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
            this.btn_read = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxReaderList = new System.Windows.Forms.ComboBox();
            this.btnRefreshReaderList = new System.Windows.Forms.Button();
            this.lbLibVersion = new System.Windows.Forms.Label();
            this.PhotoProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.tb_fullname = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_cid = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_read
            // 
            this.btn_read.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_read.Font = new System.Drawing.Font("Circular", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_read.Location = new System.Drawing.Point(826, 12);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(199, 143);
            this.btn_read.TabIndex = 0;
            this.btn_read.Text = "READ";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Circular", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "ชื่อ - นามสกุล :";
            // 
            // cbxReaderList
            // 
            this.cbxReaderList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxReaderList.FormattingEnabled = true;
            this.cbxReaderList.Location = new System.Drawing.Point(826, 161);
            this.cbxReaderList.Name = "cbxReaderList";
            this.cbxReaderList.Size = new System.Drawing.Size(199, 21);
            this.cbxReaderList.TabIndex = 3;
            // 
            // btnRefreshReaderList
            // 
            this.btnRefreshReaderList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshReaderList.Location = new System.Drawing.Point(826, 188);
            this.btnRefreshReaderList.Name = "btnRefreshReaderList";
            this.btnRefreshReaderList.Size = new System.Drawing.Size(199, 23);
            this.btnRefreshReaderList.TabIndex = 4;
            this.btnRefreshReaderList.Text = "Refresh Reader";
            this.btnRefreshReaderList.UseVisualStyleBackColor = true;
            this.btnRefreshReaderList.Click += new System.EventHandler(this.btnRefreshReaderList_Click);
            // 
            // lbLibVersion
            // 
            this.lbLibVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbLibVersion.AutoSize = true;
            this.lbLibVersion.Location = new System.Drawing.Point(12, 425);
            this.lbLibVersion.Name = "lbLibVersion";
            this.lbLibVersion.Size = new System.Drawing.Size(64, 13);
            this.lbLibVersion.TabIndex = 5;
            this.lbLibVersion.Text = "lbLibVersion";
            // 
            // PhotoProgressBar1
            // 
            this.PhotoProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PhotoProgressBar1.Location = new System.Drawing.Point(826, 217);
            this.PhotoProgressBar1.Name = "PhotoProgressBar1";
            this.PhotoProgressBar1.Size = new System.Drawing.Size(199, 19);
            this.PhotoProgressBar1.TabIndex = 6;
            // 
            // tb_fullname
            // 
            this.tb_fullname.Font = new System.Drawing.Font("Circular", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_fullname.Location = new System.Drawing.Point(212, 12);
            this.tb_fullname.Name = "tb_fullname";
            this.tb_fullname.Size = new System.Drawing.Size(423, 48);
            this.tb_fullname.TabIndex = 7;
            this.tb_fullname.TextChanged += new System.EventHandler(this.tb_fullname_TextChanged);
            // 
            // btn_send
            // 
            this.btn_send.AutoSize = true;
            this.btn_send.Enabled = false;
            this.btn_send.Font = new System.Drawing.Font("Circular", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_send.Location = new System.Drawing.Point(641, 12);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(120, 50);
            this.btn_send.TabIndex = 8;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(826, 242);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 193);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // lb_cid
            // 
            this.lb_cid.AutoSize = true;
            this.lb_cid.Location = new System.Drawing.Point(17, 55);
            this.lb_cid.Name = "lb_cid";
            this.lb_cid.Size = new System.Drawing.Size(35, 13);
            this.lb_cid.TabIndex = 10;
            this.lb_cid.Text = "label2";
            this.lb_cid.Visible = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(12, 71);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(808, 351);
            this.webBrowser1.TabIndex = 11;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 447);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.lb_cid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.tb_fullname);
            this.Controls.Add(this.PhotoProgressBar1);
            this.Controls.Add(this.lbLibVersion);
            this.Controls.Add(this.btnRefreshReaderList);
            this.Controls.Add(this.cbxReaderList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_read);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "ถวายความอาลัย ด้วยบัตรประชาชน";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxReaderList;
        private System.Windows.Forms.Button btnRefreshReaderList;
        private System.Windows.Forms.Label lbLibVersion;
        private System.Windows.Forms.ProgressBar PhotoProgressBar1;
        private System.Windows.Forms.TextBox tb_fullname;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_cid;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

