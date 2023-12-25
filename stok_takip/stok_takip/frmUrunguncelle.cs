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
    public partial class frmUrunguncelle : Form
    {
        public frmUrunguncelle()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server= localHost; port= 5432; Database= LCWaikikiDepo; user Id= postgres; password= 615434");

        private void frmUrunguncelle_Load(object sender, EventArgs e)
        {
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from urun.urun", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void urunkodu_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            NpgsqlDataAdapter komut = new NpgsqlDataAdapter("select * from urun.urun where urunkodu like '%" + urunkodu.Text + "%'", baglanti);
            komut.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void yenifiyat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("update urun.urun set fiyat=@p1 where urunkodu=@p2", baglanti);
            komut.Parameters.AddWithValue("@p2", urunkodu.Text);
            komut.Parameters.AddWithValue("@p1", yenifiyat.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Ürün güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }
    }
}
