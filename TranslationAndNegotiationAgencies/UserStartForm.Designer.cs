namespace TranslationAndNegotiationAgencies
{
    partial class UserStartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserStartForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.info = new System.Windows.Forms.RichTextBox();
            this.record = new System.Windows.Forms.Button();
            this.logoutaccount = new System.Windows.Forms.Button();
            this.theme = new System.Windows.Forms.Label();
            this.backinfo = new System.Windows.Forms.Button();
            this.nextinfo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.White;
            this.info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.info.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.info.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.info.Location = new System.Drawing.Point(266, 33);
            this.info.Name = "info";
            this.info.ReadOnly = true;
            this.info.Size = new System.Drawing.Size(399, 229);
            this.info.TabIndex = 2;
            this.info.TabStop = false;
            this.info.Text = "";
            // 
            // record
            // 
            this.record.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.record.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.record.ForeColor = System.Drawing.Color.White;
            this.record.Location = new System.Drawing.Point(24, 201);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(197, 44);
            this.record.TabIndex = 3;
            this.record.Text = "Записаться";
            this.record.UseVisualStyleBackColor = false;
            this.record.Click += new System.EventHandler(this.record_Click);
            // 
            // logoutaccount
            // 
            this.logoutaccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutaccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoutaccount.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.logoutaccount.Location = new System.Drawing.Point(24, 251);
            this.logoutaccount.Name = "logoutaccount";
            this.logoutaccount.Size = new System.Drawing.Size(197, 44);
            this.logoutaccount.TabIndex = 5;
            this.logoutaccount.Text = "Выйти из аккаунта";
            this.logoutaccount.UseVisualStyleBackColor = true;
            this.logoutaccount.Click += new System.EventHandler(this.logoutaccount_Click);
            // 
            // theme
            // 
            this.theme.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theme.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.theme.Location = new System.Drawing.Point(297, 269);
            this.theme.Name = "theme";
            this.theme.Size = new System.Drawing.Size(337, 23);
            this.theme.TabIndex = 6;
            this.theme.Text = "themetext";
            this.theme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backinfo
            // 
            this.backinfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backinfo.BackgroundImage")));
            this.backinfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backinfo.FlatAppearance.BorderSize = 0;
            this.backinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backinfo.Location = new System.Drawing.Point(266, 268);
            this.backinfo.Name = "backinfo";
            this.backinfo.Size = new System.Drawing.Size(25, 24);
            this.backinfo.TabIndex = 8;
            this.backinfo.UseVisualStyleBackColor = true;
            this.backinfo.Click += new System.EventHandler(this.backinfo_Click);
            // 
            // nextinfo
            // 
            this.nextinfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextinfo.BackgroundImage")));
            this.nextinfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextinfo.FlatAppearance.BorderSize = 0;
            this.nextinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextinfo.Location = new System.Drawing.Point(640, 268);
            this.nextinfo.Name = "nextinfo";
            this.nextinfo.Size = new System.Drawing.Size(25, 24);
            this.nextinfo.TabIndex = 9;
            this.nextinfo.UseVisualStyleBackColor = true;
            this.nextinfo.Click += new System.EventHandler(this.nextinfo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(640, 298);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(25, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            // 
            // UserStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(677, 323);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nextinfo);
            this.Controls.Add(this.backinfo);
            this.Controls.Add(this.theme);
            this.Controls.Add(this.logoutaccount);
            this.Controls.Add(this.record);
            this.Controls.Add(this.info);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserStartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserStartForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox info;
        private System.Windows.Forms.Button record;
        private System.Windows.Forms.Button logoutaccount;
        private System.Windows.Forms.Label theme;
        private System.Windows.Forms.Button backinfo;
        private System.Windows.Forms.Button nextinfo;
        private System.Windows.Forms.TextBox textBox1;
    }
}