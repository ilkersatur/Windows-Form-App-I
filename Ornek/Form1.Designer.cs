namespace Ornek
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Plaka = new System.Windows.Forms.TextBox();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.rdb_Binek = new System.Windows.Forms.RadioButton();
            this.rdb_Ticari = new System.Windows.Forms.RadioButton();
            this.cmb_Marka = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Cikar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_ResimYukle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tip = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Plaka
            // 
            this.txt_Plaka.Location = new System.Drawing.Point(66, 12);
            this.txt_Plaka.Name = "txt_Plaka";
            this.txt_Plaka.Size = new System.Drawing.Size(125, 27);
            this.txt_Plaka.TabIndex = 0;
            // 
            // txt_Model
            // 
            this.txt_Model.Location = new System.Drawing.Point(66, 78);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(125, 27);
            this.txt_Model.TabIndex = 2;
            // 
            // rdb_Binek
            // 
            this.rdb_Binek.AutoSize = true;
            this.rdb_Binek.Location = new System.Drawing.Point(45, 153);
            this.rdb_Binek.Name = "rdb_Binek";
            this.rdb_Binek.Size = new System.Drawing.Size(66, 24);
            this.rdb_Binek.TabIndex = 3;
            this.rdb_Binek.TabStop = true;
            this.rdb_Binek.Text = "Binek";
            this.rdb_Binek.UseVisualStyleBackColor = true;
            this.rdb_Binek.CheckedChanged += new System.EventHandler(this.rdb_Binek_CheckedChanged);
            // 
            // rdb_Ticari
            // 
            this.rdb_Ticari.AutoSize = true;
            this.rdb_Ticari.Location = new System.Drawing.Point(45, 183);
            this.rdb_Ticari.Name = "rdb_Ticari";
            this.rdb_Ticari.Size = new System.Drawing.Size(66, 24);
            this.rdb_Ticari.TabIndex = 4;
            this.rdb_Ticari.TabStop = true;
            this.rdb_Ticari.Text = "Ticari";
            this.rdb_Ticari.UseVisualStyleBackColor = true;
            this.rdb_Ticari.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // cmb_Marka
            // 
            this.cmb_Marka.FormattingEnabled = true;
            this.cmb_Marka.Items.AddRange(new object[] {
            "Renault",
            "BMW",
            "Volvo"});
            this.cmb_Marka.Location = new System.Drawing.Point(66, 45);
            this.cmb_Marka.Name = "cmb_Marka";
            this.cmb_Marka.Size = new System.Drawing.Size(125, 28);
            this.cmb_Marka.TabIndex = 5;
            this.cmb_Marka.SelectedIndexChanged += new System.EventHandler(this.cmb_Marka_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "ABS",
            "ASR",
            "Sun Roof",
            "DVD Player",
            "Navigation"});
            this.listBox1.Location = new System.Drawing.Point(16, 253);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(95, 144);
            this.listBox1.TabIndex = 6;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(217, 253);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(102, 144);
            this.listBox2.TabIndex = 7;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(117, 295);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(94, 29);
            this.btn_Ekle.TabIndex = 8;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Cikar
            // 
            this.btn_Cikar.Location = new System.Drawing.Point(117, 330);
            this.btn_Cikar.Name = "btn_Cikar";
            this.btn_Cikar.Size = new System.Drawing.Size(94, 29);
            this.btn_Cikar.TabIndex = 9;
            this.btn_Cikar.Text = "Çıkar";
            this.btn_Cikar.UseVisualStyleBackColor = true;
            this.btn_Cikar.Click += new System.EventHandler(this.btn_Cikar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(291, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btn_ResimYukle
            // 
            this.btn_ResimYukle.Location = new System.Drawing.Point(379, 183);
            this.btn_ResimYukle.Name = "btn_ResimYukle";
            this.btn_ResimYukle.Size = new System.Drawing.Size(94, 29);
            this.btn_ResimYukle.TabIndex = 11;
            this.btn_ResimYukle.Text = "Resim Yükle";
            this.btn_ResimYukle.UseVisualStyleBackColor = true;
            this.btn_ResimYukle.Click += new System.EventHandler(this.btn_ResimYukle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(379, 358);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(94, 29);
            this.btn_Kaydet.TabIndex = 12;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Plaka";
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(8, 81);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(52, 20);
            this.Model.TabIndex = 14;
            this.Model.Text = "Model";
            this.Model.Click += new System.EventHandler(this.Model_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Marka";
            // 
            // Tip
            // 
            this.Tip.Location = new System.Drawing.Point(19, 123);
            this.Tip.Name = "Tip";
            this.Tip.Size = new System.Drawing.Size(172, 102);
            this.Tip.TabIndex = 16;
            this.Tip.TabStop = false;
            this.Tip.Text = "Tip";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.btn_ResimYukle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Cikar);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cmb_Marka);
            this.Controls.Add(this.rdb_Ticari);
            this.Controls.Add(this.rdb_Binek);
            this.Controls.Add(this.txt_Model);
            this.Controls.Add(this.txt_Plaka);
            this.Controls.Add(this.Tip);
            this.Name = "Form1";
            this.Text = "Tip";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_Plaka;
        private TextBox txt_Model;
        private RadioButton rdb_Binek;
        private RadioButton rdb_Ticari;
        private ComboBox cmb_Marka;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button btn_Ekle;
        private Button btn_Cikar;
        private PictureBox pictureBox1;
        private Button btn_ResimYukle;
        private OpenFileDialog openFileDialog1;
        private Button btn_Kaydet;
        private Label label1;
        private Label Model;
        private Label label2;
        private GroupBox Tip;
    }
}