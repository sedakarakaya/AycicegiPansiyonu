using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AyCicegiPansiyonUyg
{
    public partial class FrmSifreGuncelle : Form
    {
        public FrmSifreGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-BAAP0H2\SQLEXPRESS;Initial Catalog=AycicegiPansiyon;Integrated Security=True;Encrypt=False");

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update AdminGiris set KullaniciAdi='" + TxtKullaniciAdi.Text + "',Sifre='" + TxtSifre.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
           
        }

        private void FrmSifreGuncelle_Load(object sender, EventArgs e)
        {

        }
    }
}
