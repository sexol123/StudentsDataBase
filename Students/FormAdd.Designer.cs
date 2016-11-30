namespace Students
{
    partial class FormAdd
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
            this.labelFIO = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxadr = new System.Windows.Forms.TextBox();
            this.textBoxfio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseButon = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxage = new System.Windows.Forms.ComboBox();
            this.comboBoxstep = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btaddphoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFIO
            // 
            this.labelFIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(178, 14);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(34, 13);
            this.labelFIO.TabIndex = 18;
            this.labelFIO.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Возраст";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Адрес";
            // 
            // textBoxadr
            // 
            this.textBoxadr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxadr.Location = new System.Drawing.Point(178, 69);
            this.textBoxadr.Name = "textBoxadr";
            this.textBoxadr.Size = new System.Drawing.Size(274, 20);
            this.textBoxadr.TabIndex = 15;
            // 
            // textBoxfio
            // 
            this.textBoxfio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxfio.Location = new System.Drawing.Point(178, 30);
            this.textBoxfio.Name = "textBoxfio";
            this.textBoxfio.Size = new System.Drawing.Size(274, 20);
            this.textBoxfio.TabIndex = 13;
            this.textBoxfio.TextChanged += new System.EventHandler(this.textBoxfio_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Стипендия";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CloseButon
            // 
            this.CloseButon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButon.Location = new System.Drawing.Point(377, 170);
            this.CloseButon.Name = "CloseButon";
            this.CloseButon.Size = new System.Drawing.Size(75, 23);
            this.CloseButon.TabIndex = 21;
            this.CloseButon.Text = "Закрыть";
            this.CloseButon.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxage
            // 
            this.comboBoxage.AutoCompleteCustomSource.AddRange(new string[] {
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26"});
            this.comboBoxage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxage.FormattingEnabled = true;
            this.comboBoxage.Items.AddRange(new object[] {
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26"});
            this.comboBoxage.Location = new System.Drawing.Point(178, 108);
            this.comboBoxage.Name = "comboBoxage";
            this.comboBoxage.Size = new System.Drawing.Size(56, 21);
            this.comboBoxage.TabIndex = 23;
            // 
            // comboBoxstep
            // 
            this.comboBoxstep.FormattingEnabled = true;
            this.comboBoxstep.Items.AddRange(new object[] {
            "320",
            "480",
            "520",
            "640",
            "720",
            "810",
            "900"});
            this.comboBoxstep.Location = new System.Drawing.Point(350, 108);
            this.comboBoxstep.Name = "comboBoxstep";
            this.comboBoxstep.Size = new System.Drawing.Size(102, 21);
            this.comboBoxstep.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(34, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btaddphoto
            // 
            this.btaddphoto.Location = new System.Drawing.Point(34, 166);
            this.btaddphoto.Name = "btaddphoto";
            this.btaddphoto.Size = new System.Drawing.Size(104, 27);
            this.btaddphoto.TabIndex = 0;
            this.btaddphoto.Text = "Выбрать фото";
            this.btaddphoto.UseVisualStyleBackColor = true;
            this.btaddphoto.Click += new System.EventHandler(this.btaddphoto_Click);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 211);
            this.Controls.Add(this.btaddphoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxstep);
            this.Controls.Add(this.comboBoxage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CloseButon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxadr);
            this.Controls.Add(this.textBoxfio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление студента";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxadr;
        private System.Windows.Forms.TextBox textBoxfio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseButon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxage;
        private System.Windows.Forms.ComboBox comboBoxstep;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btaddphoto;
    }
}