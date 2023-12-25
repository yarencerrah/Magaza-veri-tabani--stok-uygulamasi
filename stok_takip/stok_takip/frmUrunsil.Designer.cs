namespace stok_takip
{
    partial class frmUrunsil
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
            urunsil = new Label();
            tb_urunsil = new TextBox();
            dataGridView1 = new DataGridView();
            btn_urunsil = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // urunsil
            // 
            urunsil.AutoSize = true;
            urunsil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            urunsil.Location = new Point(38, 140);
            urunsil.Name = "urunsil";
            urunsil.Size = new Size(85, 21);
            urunsil.TabIndex = 0;
            urunsil.Text = "Ürün Kodu";
            // 
            // tb_urunsil
            // 
            tb_urunsil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_urunsil.Location = new Point(138, 140);
            tb_urunsil.Name = "tb_urunsil";
            tb_urunsil.Size = new Size(121, 29);
            tb_urunsil.TabIndex = 1;
            tb_urunsil.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 205);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(677, 313);
            dataGridView1.TabIndex = 2;
            // 
            // btn_urunsil
            // 
            btn_urunsil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_urunsil.Location = new Point(601, 534);
            btn_urunsil.Name = "btn_urunsil";
            btn_urunsil.Size = new Size(89, 35);
            btn_urunsil.TabIndex = 3;
            btn_urunsil.Text = "Sil";
            btn_urunsil.UseVisualStyleBackColor = true;
            btn_urunsil.Click += btn_urunsil_Click;
            // 
            // frmUrunsil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(749, 670);
            Controls.Add(btn_urunsil);
            Controls.Add(dataGridView1);
            Controls.Add(tb_urunsil);
            Controls.Add(urunsil);
            Name = "frmUrunsil";
            Text = "Ürün Sil";
            Load += frmUrunsil_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label urunsil;
        private TextBox tb_urunsil;
        private DataGridView dataGridView1;
        private Button btn_urunsil;
    }
}