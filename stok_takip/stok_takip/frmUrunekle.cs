using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stok_takip
{
    public partial class frmUrunekle : Form
    {
        public frmUrunekle()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server= localHost; port= 5432; Database= LCWaikikiDepo; user Id= postgres; password= 615434");

        private void frmUrunekle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from urungrubu", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_urungrubu.DisplayMember = "urungrubu";
            cb_urungrubu.ValueMember = "urungrubuID";
            cb_urungrubu.DataSource = dt;
            baglanti.Close();
        }

        private void btn_yeniurunekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into urun.urun (urunkodu, urunadi, \"urungrubuID\", renkkodu, kategori, fiyat) values (@p1, @p2, @p3, @p4, @p5, @p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", tb_urunkodu.Text);
            komut.Parameters.AddWithValue("@p2", tb_urunadi.Text);
            komut.Parameters.AddWithValue("@p3", cb_urungrubu.SelectedValue.ToString());
            komut.Parameters.AddWithValue("@p4", tb_renkkodu.Text);
            komut.Parameters.AddWithValue("@p5", cb_kategori.SelectedValue.ToString());
            komut.Parameters.AddWithValue("@p6", tb_fiyat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
