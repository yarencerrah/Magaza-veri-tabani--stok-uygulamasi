namespace stok_takip
{
    partial class frmUrunguncelle
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
            label1 = new Label();
            urunkodu = new TextBox();
            dataGridView1 = new DataGridView();
            btnguncelle = new Button();
            label2 = new Label();
            yenifiyat = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(68, 109);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 0;
            label1.Text = "Ürün Kodu";
            // 
            // urunkodu
            // 
            urunkodu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            urunkodu.Location = new Point(159, 109);
            urunkodu.Name = "urunkodu";
            urunkodu.Size = new Size(127, 29);
            urunkodu.TabIndex = 1;
            urunkodu.TextChanged += urunkodu_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(359, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(611, 308);
            dataGridView1.TabIndex = 2;
            // 
            // btnguncelle
            // 
            btnguncelle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnguncelle.Location = new Point(874, 435);
            btnguncelle.Name = "btnguncelle";
            btnguncelle.Size = new Size(96, 38);
            btnguncelle.TabIndex = 3;
            btnguncelle.Text = "Güncelle";
            btnguncelle.UseVisualStyleBackColor = true;
            btnguncelle.Click += btnguncelle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(68, 201);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 4;
            label2.Text = "Yeni Fiyat";
            // 
            // yenifiyat
            // 
            yenifiyat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            yenifiyat.Location = new Point(159, 200);
            yenifiyat.Name = "yenifiyat";
            yenifiyat.Size = new Size(127, 29);
            yenifiyat.TabIndex = 5;
            yenifiyat.TextChanged += yenifiyat_TextChanged;
            // 
            // frmUrunguncelle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1039, 657);
            Controls.Add(yenifiyat);
            Controls.Add(label2);
            Controls.Add(btnguncelle);
            Controls.Add(dataGridView1);
            Controls.Add(urunkodu);
            Controls.Add(label1);
            Name = "frmUrunguncelle";
            Text = "Ürün Güncelle";
            Load += frmUrunguncelle_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox urunkodu;
        private DataGridView dataGridView1;
        private Button btnguncelle;
        private Label label2;
        private TextBox yenifiyat;
    }
}