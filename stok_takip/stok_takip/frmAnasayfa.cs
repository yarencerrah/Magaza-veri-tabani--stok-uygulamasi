using Npgsql;

namespace stok_takip
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server= localHost; port= 5432; Database= LCWaikikiDepo; user Id= postgres; password= 615434");

        private void btnUrunara_Click(object sender, EventArgs e)
        {
            frmUrunara ara = new frmUrunara();
            ara.ShowDialog();
        }

        private void btnUrunekle_Click(object sender, EventArgs e)
        {
            frmUrunekle ekle = new frmUrunekle();
            ekle.ShowDialog();
        }

        private void btnUrunsil_Click(object sender, EventArgs e)
        {
            frmUrunsil sil = new frmUrunsil();
            sil.ShowDialog();
        }

        private void btnUrunguncelle_Click(object sender, EventArgs e)
        {
            frmUrunguncelle guncelle= new frmUrunguncelle();
            guncelle.ShowDialog();
        }
    }
}