namespace Students
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btAddStud = new System.Windows.Forms.Button();
            this.btRemStud = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxfio = new System.Windows.Forms.TextBox();
            this.textBoxage = new System.Windows.Forms.TextBox();
            this.textBoxadr = new System.Windows.Forms.TextBox();
            this.textBoxstep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.TestButon = new System.Windows.Forms.Button();
            this.checkBoxEdit = new System.Windows.Forms.CheckBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxstep1 = new System.Windows.Forms.TextBox();
            this.btClAll = new System.Windows.Forms.Button();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.labelPhoto = new System.Windows.Forms.Label();
            this.Фотография = new System.Windows.Forms.DataGridViewImageColumn();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Адресс = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Возраст = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Стипендия = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btAddStud
            // 
            this.btAddStud.Location = new System.Drawing.Point(12, 12);
            this.btAddStud.Name = "btAddStud";
            this.btAddStud.Size = new System.Drawing.Size(75, 23);
            this.btAddStud.TabIndex = 0;
            this.btAddStud.Text = "Добавить";
            this.btAddStud.UseVisualStyleBackColor = true;
            this.btAddStud.Click += new System.EventHandler(this.btAddStud_Click);
            // 
            // btRemStud
            // 
            this.btRemStud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRemStud.Enabled = false;
            this.btRemStud.Location = new System.Drawing.Point(408, 11);
            this.btRemStud.Name = "btRemStud";
            this.btRemStud.Size = new System.Drawing.Size(75, 23);
            this.btRemStud.TabIndex = 1;
            this.btRemStud.Text = "Удалить";
            this.btRemStud.UseVisualStyleBackColor = true;
            this.btRemStud.Click += new System.EventHandler(this.btRemStud_Click);
            // 
            // btPrint
            // 
            this.btPrint.Enabled = false;
            this.btPrint.Location = new System.Drawing.Point(174, 12);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(75, 23);
            this.btPrint.TabIndex = 3;
            this.btPrint.Text = "Сохранить";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Фотография,
            this.FIO,
            this.Адресс,
            this.Возраст,
            this.Стипендия});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Location = new System.Drawing.Point(12, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowTemplate.Height = 220;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(600, 223);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged_1);
            this.dataGridView1.VisibleChanged += new System.EventHandler(this.dataGridView1_VisibleChanged);
            // 
            // textBoxfio
            // 
            this.textBoxfio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxfio.Location = new System.Drawing.Point(69, 326);
            this.textBoxfio.Name = "textBoxfio";
            this.textBoxfio.ReadOnly = true;
            this.textBoxfio.Size = new System.Drawing.Size(274, 20);
            this.textBoxfio.TabIndex = 5;
            this.textBoxfio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxage
            // 
            this.textBoxage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxage.Location = new System.Drawing.Point(69, 402);
            this.textBoxage.Name = "textBoxage";
            this.textBoxage.ReadOnly = true;
            this.textBoxage.Size = new System.Drawing.Size(85, 20);
            this.textBoxage.TabIndex = 6;
            // 
            // textBoxadr
            // 
            this.textBoxadr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxadr.Location = new System.Drawing.Point(69, 364);
            this.textBoxadr.Name = "textBoxadr";
            this.textBoxadr.ReadOnly = true;
            this.textBoxadr.Size = new System.Drawing.Size(274, 20);
            this.textBoxadr.TabIndex = 7;
            // 
            // textBoxstep
            // 
            this.textBoxstep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxstep.Location = new System.Drawing.Point(627, 295);
            this.textBoxstep.Name = "textBoxstep";
            this.textBoxstep.ReadOnly = true;
            this.textBoxstep.Size = new System.Drawing.Size(85, 20);
            this.textBoxstep.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(627, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Стипендия";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Возраст";
            // 
            // labelFIO
            // 
            this.labelFIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(14, 329);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(34, 13);
            this.labelFIO.TabIndex = 12;
            this.labelFIO.Text = "ФИО";
            this.labelFIO.Click += new System.EventHandler(this.label4_Click);
            // 
            // TestButon
            // 
            this.TestButon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TestButon.Location = new System.Drawing.Point(537, 11);
            this.TestButon.Name = "TestButon";
            this.TestButon.Size = new System.Drawing.Size(75, 23);
            this.TestButon.TabIndex = 13;
            this.TestButon.Text = "TestButton";
            this.TestButon.UseVisualStyleBackColor = true;
            this.TestButon.Click += new System.EventHandler(this.TestButon_Click);
            // 
            // checkBoxEdit
            // 
            this.checkBoxEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxEdit.AutoSize = true;
            this.checkBoxEdit.Location = new System.Drawing.Point(255, 15);
            this.checkBoxEdit.Name = "checkBoxEdit";
            this.checkBoxEdit.Size = new System.Drawing.Size(147, 17);
            this.checkBoxEdit.TabIndex = 14;
            this.checkBoxEdit.Text = "Режим редактирования";
            this.checkBoxEdit.UseVisualStyleBackColor = true;
            this.checkBoxEdit.CheckedChanged += new System.EventHandler(this.checkBoxEdit_CheckedChanged);
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(93, 12);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 23);
            this.btOpen.TabIndex = 15;
            this.btOpen.Text = "Загрузить";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Стипендия";
            // 
            // textBoxstep1
            // 
            this.textBoxstep1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxstep1.Location = new System.Drawing.Point(258, 405);
            this.textBoxstep1.Name = "textBoxstep1";
            this.textBoxstep1.ReadOnly = true;
            this.textBoxstep1.Size = new System.Drawing.Size(85, 20);
            this.textBoxstep1.TabIndex = 21;
            this.textBoxstep1.Tag = "Только цифры";
            this.textBoxstep1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btClAll
            // 
            this.btClAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btClAll.Location = new System.Drawing.Point(12, 284);
            this.btClAll.Name = "btClAll";
            this.btClAll.Size = new System.Drawing.Size(126, 23);
            this.btClAll.TabIndex = 23;
            this.btClAll.Text = "Очистить список";
            this.btClAll.UseVisualStyleBackColor = true;
            this.btClAll.Click += new System.EventHandler(this.btClAll_Click);
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMain.Location = new System.Drawing.Point(492, 284);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(120, 141);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMain.TabIndex = 24;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBoxMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseClick);
            // 
            // labelPhoto
            // 
            this.labelPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPhoto.AutoSize = true;
            this.labelPhoto.Location = new System.Drawing.Point(414, 284);
            this.labelPhoto.Name = "labelPhoto";
            this.labelPhoto.Size = new System.Drawing.Size(72, 13);
            this.labelPhoto.TabIndex = 25;
            this.labelPhoto.Text = "Фотография";
            // 
            // Фотография
            // 
            this.Фотография.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Фотография.DataPropertyName = "photo";
            this.Фотография.FillWeight = 1.969027F;
            this.Фотография.HeaderText = "Фотография";
            this.Фотография.Image = ((System.Drawing.Image)(resources.GetObject("Фотография.Image")));
            this.Фотография.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Фотография.Name = "Фотография";
            this.Фотография.ReadOnly = true;
            this.Фотография.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Фотография.Width = 80;
            // 
            // FIO
            // 
            this.FIO.DataPropertyName = "FIO";
            this.FIO.FillWeight = 23.10809F;
            this.FIO.HeaderText = "ФИО";
            this.FIO.Name = "FIO";
            this.FIO.ReadOnly = true;
            this.FIO.Width = 216;
            // 
            // Адресс
            // 
            this.Адресс.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Адресс.DataPropertyName = "adres";
            this.Адресс.FillWeight = 13.19087F;
            this.Адресс.HeaderText = "Адресс";
            this.Адресс.Name = "Адресс";
            this.Адресс.ReadOnly = true;
            // 
            // Возраст
            // 
            this.Возраст.DataPropertyName = "age";
            this.Возраст.FillWeight = 13.19087F;
            this.Возраст.HeaderText = "Возраст";
            this.Возраст.Name = "Возраст";
            this.Возраст.ReadOnly = true;
            this.Возраст.Width = 60;
            // 
            // Стипендия
            // 
            this.Стипендия.DataPropertyName = "stepuha";
            this.Стипендия.FillWeight = 13.19087F;
            this.Стипендия.HeaderText = "Стипендия";
            this.Стипендия.Name = "Стипендия";
            this.Стипендия.ReadOnly = true;
            this.Стипендия.Width = 80;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.labelPhoto);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.btClAll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxstep1);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.checkBoxEdit);
            this.Controls.Add(this.TestButon);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxstep);
            this.Controls.Add(this.textBoxadr);
            this.Controls.Add(this.textBoxage);
            this.Controls.Add(this.textBoxfio);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.btRemStud);
            this.Controls.Add(this.btAddStud);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(16, 39);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет студентов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAddStud;
        private System.Windows.Forms.Button btRemStud;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.TextBox textBoxfio;
        private System.Windows.Forms.TextBox textBoxage;
        private System.Windows.Forms.TextBox textBoxadr;
        private System.Windows.Forms.TextBox textBoxstep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button TestButon;
        private System.Windows.Forms.CheckBox checkBoxEdit;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxstep1;
        private System.Windows.Forms.Button btClAll;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Label labelPhoto;
        private System.Windows.Forms.DataGridViewImageColumn Фотография;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Адресс;
        private System.Windows.Forms.DataGridViewTextBoxColumn Возраст;
        private System.Windows.Forms.DataGridViewTextBoxColumn Стипендия;
    }
}

