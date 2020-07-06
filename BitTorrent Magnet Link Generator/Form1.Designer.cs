namespace BitTorrent_Magnet_Link_Generator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtINFO_HASH = new System.Windows.Forms.TextBox();
            this.txtTORRENT_NAME = new System.Windows.Forms.TextBox();
            this.txtMAGNET_LINK = new System.Windows.Forms.TextBox();
            this.txtTRACKER_LIST = new System.Windows.Forms.TextBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkMAGNET = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtINFO_HASH
            // 
            this.txtINFO_HASH.Location = new System.Drawing.Point(101, 18);
            this.txtINFO_HASH.MaxLength = 40;
            this.txtINFO_HASH.Name = "txtINFO_HASH";
            this.txtINFO_HASH.Size = new System.Drawing.Size(366, 21);
            this.txtINFO_HASH.TabIndex = 0;
            this.txtINFO_HASH.TextChanged += new System.EventHandler(this.txtINFO_HASH_TextChanged);
            // 
            // txtTORRENT_NAME
            // 
            this.txtTORRENT_NAME.Location = new System.Drawing.Point(101, 72);
            this.txtTORRENT_NAME.Name = "txtTORRENT_NAME";
            this.txtTORRENT_NAME.Size = new System.Drawing.Size(366, 21);
            this.txtTORRENT_NAME.TabIndex = 1;
            this.txtTORRENT_NAME.TextChanged += new System.EventHandler(this.txtTORRENT_NAME_TextChanged);
            // 
            // txtMAGNET_LINK
            // 
            this.txtMAGNET_LINK.Location = new System.Drawing.Point(101, 158);
            this.txtMAGNET_LINK.Name = "txtMAGNET_LINK";
            this.txtMAGNET_LINK.Size = new System.Drawing.Size(366, 21);
            this.txtMAGNET_LINK.TabIndex = 2;
            this.txtMAGNET_LINK.Click += new System.EventHandler(this.txtMAGNET_LINK_Click);
            // 
            // txtTRACKER_LIST
            // 
            this.txtTRACKER_LIST.Location = new System.Drawing.Point(15, 19);
            this.txtTRACKER_LIST.Multiline = true;
            this.txtTRACKER_LIST.Name = "txtTRACKER_LIST";
            this.txtTRACKER_LIST.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTRACKER_LIST.Size = new System.Drawing.Size(282, 305);
            this.txtTRACKER_LIST.TabIndex = 3;
            this.txtTRACKER_LIST.Text = "udp://tracker.openbittorrent.com:80\r\nudp://tracker.opentrackr.org:1337/announce";
            this.txtTRACKER_LIST.TextChanged += new System.EventHandler(this.txtTRACKER_LIST_TextChanged);
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(101, 120);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 23);
            this.btnGen.TabIndex = 4;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "info hash:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "torrent name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTRACKER_LIST);
            this.groupBox1.Location = new System.Drawing.Point(473, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 340);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trackers to include into the magnet link:";
            // 
            // linkMAGNET
            // 
            this.linkMAGNET.AutoSize = true;
            this.linkMAGNET.Location = new System.Drawing.Point(26, 161);
            this.linkMAGNET.Name = "linkMAGNET";
            this.linkMAGNET.Size = new System.Drawing.Size(68, 13);
            this.linkMAGNET.TabIndex = 9;
            this.linkMAGNET.TabStop = true;
            this.linkMAGNET.Text = "Magnet Link:";
            this.linkMAGNET.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMAGNET_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Example: A94A8FE5CCB19BA61C4C0873D391E987982FBBD3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "(this is not an URL, this is a title for the torrent in the client)";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(182, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Copy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::BitTorrent_Magnet_Link_Generator.Properties.Resources.bitcoin;
            this.pictureBox3.Location = new System.Drawing.Point(53, 316);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::BitTorrent_Magnet_Link_Generator.Properties.Resources.github;
            this.pictureBox2.Location = new System.Drawing.Point(12, 316);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(800, 364);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkMAGNET);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.txtMAGNET_LINK);
            this.Controls.Add(this.txtTORRENT_NAME);
            this.Controls.Add(this.txtINFO_HASH);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BitTorrent Magnet Link Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtINFO_HASH;
        private System.Windows.Forms.TextBox txtTORRENT_NAME;
        private System.Windows.Forms.TextBox txtMAGNET_LINK;
        private System.Windows.Forms.TextBox txtTRACKER_LIST;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkMAGNET;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

