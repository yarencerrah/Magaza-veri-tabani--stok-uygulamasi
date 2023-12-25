namespace stok_takip
{
    partial class frmAnasayfa
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
            btnUrunara = new Button();
            btnUrunekle = new Button();
            btnUrunsil = new Button();
            btnUrunguncelle = new Button();
            SuspendLayout();
            // 
            // btnUrunara
            // 
            btnUrunara.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnUrunara.Location = new Point(117, 170);
            btnUrunara.Name = "btnUrunara";
            btnUrunara.Size = new Size(135, 65);
            btnUrunara.TabIndex = 0;
            btnUrunara.Text = "Ürün Arama";
            btnUrunara.UseVisualStyleBackColor = true;
            btnUrunara.Click += btnUrunara_Click;
            // 
            // btnUrunekle
            // 
            btnUrunekle.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnUrunekle.Location = new Point(311, 170);
            btnUrunekle.Name = "btnUrunekle";
            btnUrunekle.Size = new Size(135, 65);
            btnUrunekle.TabIndex = 1;
            btnUrunekle.Text = "Ürün Ekleme";
            btnUrunekle.UseVisualStyleBackColor = true;
            btnUrunekle.Click += btnUrunekle_Click;
            // 
            // btnUrunsil
            // 
            btnUrunsil.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnUrunsil.Location = new Point(505, 170);
            btnUrunsil.Name = "btnUrunsil";
            btnUrunsil.Size = new Size(135, 65);
            btnUrunsil.TabIndex = 2;
            btnUrunsil.Text = "Ürün Sil";
            btnUrunsil.UseVisualStyleBackColor = true;
            btnUrunsil.Click += btnUrunsil_Click;
            // 
            // btnUrunguncelle
            // 
            btnUrunguncelle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUrunguncelle.Location = new Point(699, 170);
            btnUrunguncelle.Name = "btnUrunguncelle";
            btnUrunguncelle.Size = new Size(135, 65);
            btnUrunguncelle.TabIndex = 3;
            btnUrunguncelle.Text = "Ürün Güncelle";
            btnUrunguncelle.UseVisualStyleBackColor = true;
            btnUrunguncelle.Click += btnUrunguncelle_Click;
            // 
            // frmAnasayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1005, 642);
            Controls.Add(btnUrunguncelle);
            Controls.Add(btnUrunsil);
            Controls.Add(btnUrunekle);
            Controls.Add(btnUrunara);
            Name = "frmAnasayfa";
            Text = "Ana Sayfa";
            ResumeLayout(false);
        }

        #endregion

        private Button btnUrunara;
        private Button btnUrunekle;
        private Button btnUrunsil;
        private Button btnUrunguncelle;
    }
}