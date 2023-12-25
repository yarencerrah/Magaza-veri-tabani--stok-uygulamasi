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
    public partial class frmUrunsil : Form
    {
        public frmUrunsil()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server= localHost; port= 5432; Database= LCWaikikiDepo; user Id= postgres; password= 615434");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            NpgsqlDataAdapter komut = new NpgsqlDataAdapter("select * from urun.urun where urunkodu like '%" + tb_urunsil.Text + "%'", baglanti);
            komut.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void frmUrunsil_Load(object sender, EventArgs e)
        {
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from urun.urun", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btn_urunsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("delete from urun.urun where urunkodu=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", tb_urunsil.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from urun.urun", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            MessageBox.Show("Ürün silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
