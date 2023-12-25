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
    public partial class frmUrunara : Form
    {
        public frmUrunara()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server= localHost; port= 5432; Database= LCWaikikiDepo; user Id= postgres; password= 615434");
        private void frmUrunara_Load(object sender, EventArgs e)
        {
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from urun.urun", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void tb_Urunkodu_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            NpgsqlDataAdapter komut = new NpgsqlDataAdapter("select * from urun.urun where urunkodu like '%" + tb_Urunkodu.Text + "%'", baglanti);
            komut.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
