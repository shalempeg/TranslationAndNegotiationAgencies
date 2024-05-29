namespace TranslationAndNegotiationAgencies
{
    partial class record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(record));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.recGrid = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.языкDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.уровеньDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.translateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bTANDataSet = new TranslationAndNegotiationAgencies.BTANDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.translateTableAdapter = new TranslationAndNegotiationAgencies.BTANDataSetTableAdapters.translateTableAdapter();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textOtch = new System.Windows.Forms.TextBox();
            this.textVid = new System.Windows.Forms.TextBox();
            this.textLanguage = new System.Windows.Forms.TextBox();
            this.textLevel = new System.Windows.Forms.TextBox();
            this.recordbutton = new System.Windows.Forms.Button();
            this.numberphone = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.backfromrec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // recGrid
            // 
            this.recGrid.AutoGenerateColumns = false;
            this.recGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.recGrid.BackgroundColor = System.Drawing.Color.White;
            this.recGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.видDataGridViewTextBoxColumn,
            this.языкDataGridViewTextBoxColumn,
            this.уровеньDataGridViewTextBoxColumn});
            this.recGrid.DataSource = this.translateBindingSource;
            this.recGrid.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.recGrid.Location = new System.Drawing.Point(12, 71);
            this.recGrid.Name = "recGrid";
            this.recGrid.Size = new System.Drawing.Size(564, 291);
            this.recGrid.TabIndex = 2;
            this.recGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recGrid_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // видDataGridViewTextBoxColumn
            // 
            this.видDataGridViewTextBoxColumn.DataPropertyName = "Вид";
            this.видDataGridViewTextBoxColumn.HeaderText = "Вид";
            this.видDataGridViewTextBoxColumn.Name = "видDataGridViewTextBoxColumn";
            // 
            // языкDataGridViewTextBoxColumn
            // 
            this.языкDataGridViewTextBoxColumn.DataPropertyName = "Язык";
            this.языкDataGridViewTextBoxColumn.HeaderText = "Язык";
            this.языкDataGridViewTextBoxColumn.Name = "языкDataGridViewTextBoxColumn";
            // 
            // уровеньDataGridViewTextBoxColumn
            // 
            this.уровеньDataGridViewTextBoxColumn.DataPropertyName = "Уровень";
            this.уровеньDataGridViewTextBoxColumn.HeaderText = "Уровень";
            this.уровеньDataGridViewTextBoxColumn.Name = "уровеньDataGridViewTextBoxColumn";
            // 
            // translateBindingSource
            // 
            this.translateBindingSource.DataMember = "translate";
            this.translateBindingSource.DataSource = this.bTANDataSet;
            // 
            // bTANDataSet
            // 
            this.bTANDataSet.DataSetName = "BTANDataSet";
            this.bTANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(93, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите нужную услугу";
            // 
            // translateTableAdapter
            // 
            this.translateTableAdapter.ClearBeforeFill = true;
            // 
            // textSurname
            // 
            this.textSurname.BackColor = System.Drawing.Color.White;
            this.textSurname.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSurname.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textSurname.Location = new System.Drawing.Point(12, 406);
            this.textSurname.Name = "textSurname";
            this.textSurname.ReadOnly = true;
            this.textSurname.Size = new System.Drawing.Size(147, 27);
            this.textSurname.TabIndex = 4;
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.White;
            this.textName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textName.Location = new System.Drawing.Point(12, 456);
            this.textName.Name = "textName";
            this.textName.ReadOnly = true;
            this.textName.Size = new System.Drawing.Size(147, 27);
            this.textName.TabIndex = 5;
            // 
            // textOtch
            // 
            this.textOtch.BackColor = System.Drawing.Color.White;
            this.textOtch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textOtch.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textOtch.Location = new System.Drawing.Point(12, 506);
            this.textOtch.Name = "textOtch";
            this.textOtch.ReadOnly = true;
            this.textOtch.Size = new System.Drawing.Size(147, 27);
            this.textOtch.TabIndex = 6;
            // 
            // textVid
            // 
            this.textVid.BackColor = System.Drawing.Color.White;
            this.textVid.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textVid.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textVid.Location = new System.Drawing.Point(200, 456);
            this.textVid.Name = "textVid";
            this.textVid.ReadOnly = true;
            this.textVid.Size = new System.Drawing.Size(157, 27);
            this.textVid.TabIndex = 7;
            // 
            // textLanguage
            // 
            this.textLanguage.BackColor = System.Drawing.Color.White;
            this.textLanguage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLanguage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textLanguage.Location = new System.Drawing.Point(200, 406);
            this.textLanguage.Name = "textLanguage";
            this.textLanguage.ReadOnly = true;
            this.textLanguage.Size = new System.Drawing.Size(157, 27);
            this.textLanguage.TabIndex = 8;
            // 
            // textLevel
            // 
            this.textLevel.BackColor = System.Drawing.Color.White;
            this.textLevel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLevel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textLevel.Location = new System.Drawing.Point(200, 506);
            this.textLevel.Name = "textLevel";
            this.textLevel.ReadOnly = true;
            this.textLevel.Size = new System.Drawing.Size(157, 27);
            this.textLevel.TabIndex = 9;
            // 
            // recordbutton
            // 
            this.recordbutton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.recordbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recordbutton.ForeColor = System.Drawing.Color.White;
            this.recordbutton.Location = new System.Drawing.Point(392, 440);
            this.recordbutton.Name = "recordbutton";
            this.recordbutton.Size = new System.Drawing.Size(184, 44);
            this.recordbutton.TabIndex = 10;
            this.recordbutton.Text = "Записаться";
            this.recordbutton.UseVisualStyleBackColor = false;
            this.recordbutton.Click += new System.EventHandler(this.recordbutton_Click);
            // 
            // numberphone
            // 
            this.numberphone.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberphone.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.numberphone.Location = new System.Drawing.Point(426, 406);
            this.numberphone.Name = "numberphone";
            this.numberphone.Size = new System.Drawing.Size(151, 27);
            this.numberphone.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(393, 406);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(9, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Фамилия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(9, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Имя:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(9, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Отчество:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(197, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Вид:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(197, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Язык:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(197, 486);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Уровень:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(437, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ваш номер телефона:";
            // 
            // backfromrec
            // 
            this.backfromrec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backfromrec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backfromrec.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.backfromrec.Location = new System.Drawing.Point(394, 490);
            this.backfromrec.Name = "backfromrec";
            this.backfromrec.Size = new System.Drawing.Size(183, 43);
            this.backfromrec.TabIndex = 20;
            this.backfromrec.Text = "Назад";
            this.backfromrec.UseVisualStyleBackColor = true;
            this.backfromrec.Click += new System.EventHandler(this.backfromrec_Click);
            // 
            // record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(589, 549);
            this.Controls.Add(this.backfromrec);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.numberphone);
            this.Controls.Add(this.recordbutton);
            this.Controls.Add(this.textLevel);
            this.Controls.Add(this.textLanguage);
            this.Controls.Add(this.textVid);
            this.Controls.Add(this.textOtch);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recGrid);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "record";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "record";
            this.Load += new System.EventHandler(this.record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView recGrid;
        private System.Windows.Forms.Label label1;
        private BTANDataSet bTANDataSet;
        private System.Windows.Forms.BindingSource translateBindingSource;
        private BTANDataSetTableAdapters.translateTableAdapter translateTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn языкDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn уровеньDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textOtch;
        private System.Windows.Forms.TextBox textVid;
        private System.Windows.Forms.TextBox textLanguage;
        private System.Windows.Forms.TextBox textLevel;
        private System.Windows.Forms.Button recordbutton;
        private System.Windows.Forms.TextBox numberphone;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button backfromrec;
    }
}