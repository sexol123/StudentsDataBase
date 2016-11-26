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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.btRemStud.Enabled = false;
            this.btRemStud.Location = new System.Drawing.Point(93, 12);
            this.btRemStud.Name = "btRemStud";
            this.btRemStud.Size = new System.Drawing.Size(75, 23);
            this.btRemStud.TabIndex = 1;
            this.btRemStud.Text = "Удалить";
            this.btRemStud.UseVisualStyleBackColor = true;
            this.btRemStud.Click += new System.EventHandler(this.btRemStud_Click);
            // 
            // btPrint
            // 
            this.btPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btPrint.Enabled = false;
            this.btPrint.Location = new System.Drawing.Point(12, 406);
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
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 220;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(600, 223);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged_1);
            this.dataGridView1.VisibleChanged += new System.EventHandler(this.dataGridView1_VisibleChanged);
            // 
            // textBoxfio
            // 
            this.textBoxfio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxfio.Location = new System.Drawing.Point(112, 295);
            this.textBoxfio.Name = "textBoxfio";
            this.textBoxfio.ReadOnly = true;
            this.textBoxfio.Size = new System.Drawing.Size(274, 20);
            this.textBoxfio.TabIndex = 5;
            this.textBoxfio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxage
            // 
            this.textBoxage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxage.Location = new System.Drawing.Point(112, 373);
            this.textBoxage.Name = "textBoxage";
            this.textBoxage.ReadOnly = true;
            this.textBoxage.Size = new System.Drawing.Size(85, 20);
            this.textBoxage.TabIndex = 6;
            // 
            // textBoxadr
            // 
            this.textBoxadr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxadr.Location = new System.Drawing.Point(112, 334);
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
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Возраст";
            // 
            // labelFIO
            // 
            this.labelFIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(112, 279);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(34, 13);
            this.labelFIO.TabIndex = 12;
            this.labelFIO.Text = "ФИО";
            this.labelFIO.Click += new System.EventHandler(this.label4_Click);
            // 
            // TestButon
            // 
            this.TestButon.Location = new System.Drawing.Point(530, 12);
            this.TestButon.Name = "TestButon";
            this.TestButon.Size = new System.Drawing.Size(75, 23);
            this.TestButon.TabIndex = 13;
            this.TestButon.Text = "TestButton";
            this.TestButon.UseVisualStyleBackColor = true;
            this.TestButon.Click += new System.EventHandler(this.TestButon_Click);
            // 
            // checkBoxEdit
            // 
            this.checkBoxEdit.AutoSize = true;
            this.checkBoxEdit.Location = new System.Drawing.Point(188, 16);
            this.checkBoxEdit.Name = "checkBoxEdit";
            this.checkBoxEdit.Size = new System.Drawing.Size(147, 17);
            this.checkBoxEdit.TabIndex = 14;
            this.checkBoxEdit.Text = "Режим редактирования";
            this.checkBoxEdit.UseVisualStyleBackColor = true;
            this.checkBoxEdit.CheckedChanged += new System.EventHandler(this.checkBoxEdit_CheckedChanged);
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(530, 406);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 23);
            this.btOpen.TabIndex = 15;
            this.btOpen.Text = "Загрузить";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Стипендия";
            // 
            // textBoxstep1
            // 
            this.textBoxstep1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxstep1.Location = new System.Drawing.Point(301, 373);
            this.textBoxstep1.Name = "textBoxstep1";
            this.textBoxstep1.ReadOnly = true;
            this.textBoxstep1.Size = new System.Drawing.Size(85, 20);
            this.textBoxstep1.TabIndex = 21;
            this.textBoxstep1.Tag = "Только цифры";
            this.textBoxstep1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btClAll
            // 
            this.btClAll.Location = new System.Drawing.Point(443, 11);
            this.btClAll.Name = "btClAll";
            this.btClAll.Size = new System.Drawing.Size(75, 23);
            this.btClAll.TabIndex = 23;
            this.btClAll.Text = "Очистить";
            this.btClAll.UseVisualStyleBackColor = true;
            this.btClAll.Click += new System.EventHandler(this.btClAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет студентов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}

