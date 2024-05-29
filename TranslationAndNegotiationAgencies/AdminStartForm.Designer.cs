namespace TranslationAndNegotiationAgencies
{
    partial class AdminStartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminStartForm));
            this.backfromrec = new System.Windows.Forms.Button();
            this.recordconfirm = new System.Windows.Forms.Button();
            this.recGridAdmin = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.языкDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.уровеньDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонклиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bTANDataSet1 = new TranslationAndNegotiationAgencies.BTANDataSet1();
            this.recordsTableAdapter = new TranslationAndNegotiationAgencies.BTANDataSet1TableAdapters.recordsTableAdapter();
            this.clientnumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.logoutadmin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.recordlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.recGridAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTANDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backfromrec
            // 
            this.backfromrec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backfromrec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backfromrec.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.backfromrec.Location = new System.Drawing.Point(501, 176);
            this.backfromrec.Name = "backfromrec";
            this.backfromrec.Size = new System.Drawing.Size(223, 43);
            this.backfromrec.TabIndex = 40;
            this.backfromrec.Text = "Отклонить";
            this.backfromrec.UseVisualStyleBackColor = true;
            this.backfromrec.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // recordconfirm
            // 
            this.recordconfirm.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.recordconfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordconfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recordconfirm.ForeColor = System.Drawing.Color.White;
            this.recordconfirm.Location = new System.Drawing.Point(501, 127);
            this.recordconfirm.Name = "recordconfirm";
            this.recordconfirm.Size = new System.Drawing.Size(223, 43);
            this.recordconfirm.TabIndex = 30;
            this.recordconfirm.Text = "Подтвердить";
            this.recordconfirm.UseVisualStyleBackColor = false;
            this.recordconfirm.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // recGridAdmin
            // 
            this.recGridAdmin.AutoGenerateColumns = false;
            this.recGridAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.recGridAdmin.BackgroundColor = System.Drawing.Color.White;
            this.recGridAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recGridAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.видDataGridViewTextBoxColumn,
            this.языкDataGridViewTextBoxColumn,
            this.уровеньDataGridViewTextBoxColumn,
            this.телефонклиентаDataGridViewTextBoxColumn});
            this.recGridAdmin.DataSource = this.recordsBindingSource;
            this.recGridAdmin.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.recGridAdmin.Location = new System.Drawing.Point(7, 72);
            this.recGridAdmin.Name = "recGridAdmin";
            this.recGridAdmin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.recGridAdmin.Size = new System.Drawing.Size(488, 196);
            this.recGridAdmin.TabIndex = 22;
            this.recGridAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recGridAdmin_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 43;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.Width = 81;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.Width = 54;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.Width = 79;
            // 
            // видDataGridViewTextBoxColumn
            // 
            this.видDataGridViewTextBoxColumn.DataPropertyName = "Вид";
            this.видDataGridViewTextBoxColumn.HeaderText = "Вид";
            this.видDataGridViewTextBoxColumn.Name = "видDataGridViewTextBoxColumn";
            this.видDataGridViewTextBoxColumn.Width = 51;
            // 
            // языкDataGridViewTextBoxColumn
            // 
            this.языкDataGridViewTextBoxColumn.DataPropertyName = "Язык";
            this.языкDataGridViewTextBoxColumn.HeaderText = "Язык";
            this.языкDataGridViewTextBoxColumn.Name = "языкDataGridViewTextBoxColumn";
            this.языкDataGridViewTextBoxColumn.Width = 60;
            // 
            // уровеньDataGridViewTextBoxColumn
            // 
            this.уровеньDataGridViewTextBoxColumn.DataPropertyName = "Уровень";
            this.уровеньDataGridViewTextBoxColumn.HeaderText = "Уровень";
            this.уровеньDataGridViewTextBoxColumn.Name = "уровеньDataGridViewTextBoxColumn";
            this.уровеньDataGridViewTextBoxColumn.Width = 76;
            // 
            // телефонклиентаDataGridViewTextBoxColumn
            // 
            this.телефонклиентаDataGridViewTextBoxColumn.DataPropertyName = "Телефон_клиента";
            this.телефонклиентаDataGridViewTextBoxColumn.HeaderText = "Телефон_клиента";
            this.телефонклиентаDataGridViewTextBoxColumn.Name = "телефонклиентаDataGridViewTextBoxColumn";
            this.телефонклиентаDataGridViewTextBoxColumn.Width = 124;
            // 
            // recordsBindingSource
            // 
            this.recordsBindingSource.DataMember = "records";
            this.recordsBindingSource.DataSource = this.bTANDataSet1;
            // 
            // bTANDataSet1
            // 
            this.bTANDataSet1.DataSetName = "BTANDataSet1";
            this.bTANDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recordsTableAdapter
            // 
            this.recordsTableAdapter.ClearBeforeFill = true;
            // 
            // clientnumber
            // 
            this.clientnumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientnumber.Location = new System.Drawing.Point(501, 92);
            this.clientnumber.Name = "clientnumber";
            this.clientnumber.Size = new System.Drawing.Size(223, 29);
            this.clientnumber.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(497, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 21);
            this.label2.TabIndex = 42;
            this.label2.Text = "Телефон клиента:";
            // 
            // logoutadmin
            // 
            this.logoutadmin.BackColor = System.Drawing.Color.White;
            this.logoutadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutadmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoutadmin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.logoutadmin.Location = new System.Drawing.Point(501, 225);
            this.logoutadmin.Name = "logoutadmin";
            this.logoutadmin.Size = new System.Drawing.Size(223, 43);
            this.logoutadmin.TabIndex = 43;
            this.logoutadmin.Text = "Выйти из аккаунта";
            this.logoutadmin.UseVisualStyleBackColor = false;
            this.logoutadmin.Click += new System.EventHandler(this.logoutadmin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // recordlabel
            // 
            this.recordlabel.AutoSize = true;
            this.recordlabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recordlabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.recordlabel.Location = new System.Drawing.Point(94, 22);
            this.recordlabel.Name = "recordlabel";
            this.recordlabel.Size = new System.Drawing.Size(92, 32);
            this.recordlabel.TabIndex = 45;
            this.recordlabel.Text = "Записи";
            // 
            // AdminStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 281);
            this.Controls.Add(this.recordlabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logoutadmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientnumber);
            this.Controls.Add(this.backfromrec);
            this.Controls.Add(this.recordconfirm);
            this.Controls.Add(this.recGridAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminStartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "--";
            this.Load += new System.EventHandler(this.AdminStartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recGridAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTANDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backfromrec;
        private System.Windows.Forms.Button recordconfirm;
        private System.Windows.Forms.DataGridView recGridAdmin;
        private BTANDataSet1 bTANDataSet1;
        private System.Windows.Forms.BindingSource recordsBindingSource;
        private BTANDataSet1TableAdapters.recordsTableAdapter recordsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn языкDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn уровеньDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонклиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox clientnumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logoutadmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label recordlabel;
    }
}