namespace stok_takip
{
    partial class frmUrunekle
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
            gb_Urunekle = new GroupBox();
            btn_yeniurunekle = new Button();
            cb_kategori = new ComboBox();
            cb_urungrubu = new ComboBox();
            tb_urunadi = new TextBox();
            tb_fiyat = new TextBox();
            tb_renkkodu = new TextBox();
            tb_urunkodu = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gb_Urunekle.SuspendLayout();
            SuspendLayout();
            // 
            // gb_Urunekle
            // 
            gb_Urunekle.Controls.Add(btn_yeniurunekle);
            gb_Urunekle.Controls.Add(cb_kategori);
            gb_Urunekle.Controls.Add(cb_urungrubu);
            gb_Urunekle.Controls.Add(tb_urunadi);
            gb_Urunekle.Controls.Add(tb_fiyat);
            gb_Urunekle.Controls.Add(tb_renkkodu);
            gb_Urunekle.Controls.Add(tb_urunkodu);
            gb_Urunekle.Controls.Add(label6);
            gb_Urunekle.Controls.Add(label5);
            gb_Urunekle.Controls.Add(label4);
            gb_Urunekle.Controls.Add(label3);
            gb_Urunekle.Controls.Add(label2);
            gb_Urunekle.Controls.Add(label1);
            gb_Urunekle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            gb_Urunekle.Location = new Point(56, 51);
            gb_Urunekle.Name = "gb_Urunekle";
            gb_Urunekle.Size = new Size(326, 451);
            gb_Urunekle.TabIndex = 0;
            gb_Urunekle.TabStop = false;
            gb_Urunekle.Text = "Yeni Ürün";
            // 
            // btn_yeniurunekle
            // 
            btn_yeniurunekle.Location = new Point(142, 392);
            btn_yeniurunekle.Name = "btn_yeniurunekle";
            btn_yeniurunekle.Size = new Size(96, 38);
            btn_yeniurunekle.TabIndex = 12;
            btn_yeniurunekle.Text = "Ekle";
            btn_yeniurunekle.UseVisualStyleBackColor = true;
            btn_yeniurunekle.Click += btn_yeniurunekle_Click;
            // 
            // cb_kategori
            // 
            cb_kategori.FormattingEnabled = true;
            cb_kategori.Items.AddRange(new object[] { "Aksesuar", "Ayakkabı", "Giyim", "Ev Yaşam" });
            cb_kategori.Location = new Point(160, 293);
            cb_kategori.Name = "cb_kategori";
            cb_kategori.Size = new Size(144, 28);
            cb_kategori.TabIndex = 11;
            // 
            // cb_urungrubu
            // 
            cb_urungrubu.FormattingEnabled = true;
            cb_urungrubu.Location = new Point(160, 182);
            cb_urungrubu.Name = "cb_urungrubu";
            cb_urungrubu.Size = new Size(144, 28);
            cb_urungrubu.TabIndex = 10;
            // 
            // tb_urunadi
            // 
            tb_urunadi.Location = new Point(160, 127);
            tb_urunadi.Name = "tb_urunadi";
            tb_urunadi.Size = new Size(144, 27);
            tb_urunadi.TabIndex = 9;
            // 
            // tb_fiyat
            // 
            tb_fiyat.Location = new Point(160, 349);
            tb_fiyat.Name = "tb_fiyat";
            tb_fiyat.Size = new Size(144, 27);
            tb_fiyat.TabIndex = 8;
            // 
            // tb_renkkodu
            // 
            tb_renkkodu.Location = new Point(160, 238);
            tb_renkkodu.Name = "tb_renkkodu";
            tb_renkkodu.Size = new Size(144, 27);
            tb_renkkodu.TabIndex = 7;
            // 
            // tb_urunkodu
            // 
            tb_urunkodu.Location = new Point(160, 72);
            tb_urunkodu.Name = "tb_urunkodu";
            tb_urunkodu.Size = new Size(144, 27);
            tb_urunkodu.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(48, 352);
            label6.Name = "label6";
            label6.Size = new Size(43, 21);
            label6.TabIndex = 5;
            label6.Text = "Fiyat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(48, 296);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 4;
            label5.Text = "Kategori";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(48, 240);
            label4.Name = "label4";
            label4.Size = new Size(85, 21);
            label4.TabIndex = 3;
            label4.Text = "Renk Kodu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(48, 184);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 2;
            label3.Text = "Ürün Grubu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(48, 128);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 1;
            label2.Text = "Ürün Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(48, 72);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 0;
            label1.Text = "Ürün Kodu";
            // 
            // frmUrunekle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(510, 609);
            Controls.Add(gb_Urunekle);
            Name = "frmUrunekle";
            Text = "Ürün Ekle";
            Load += frmUrunekle_Load;
            gb_Urunekle.ResumeLayout(false);
            gb_Urunekle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_Urunekle;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_yeniurunekle;
        private ComboBox cb_kategori;
        private ComboBox cb_urungrubu;
        private TextBox tb_urunadi;
        private TextBox tb_fiyat;
        private TextBox tb_renkkodu;
        private TextBox tb_urunkodu;
    }
}