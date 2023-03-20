namespace TelefonRehberi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            label2 = new Label();
            btnGiris = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(199, 266);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnGiris);
            groupBox2.Controls.Add(txtSifre);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtKullaniciAdi);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(217, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(369, 266);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kullanıcı Giriş Bilgileri";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 240);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 32);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı :";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(122, 29);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(201, 27);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(122, 61);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(201, 27);
            txtSifre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 64);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "Şifre :";
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(22, 96);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(301, 29);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "Sistem Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 290);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Giriş Ekranı";
           // Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private Button btnGiris;
        private TextBox txtSifre;
        private Label label2;
        private TextBox txtKullaniciAdi;
        private Label label1;
    }
}