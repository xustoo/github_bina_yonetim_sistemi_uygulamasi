using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Bina_yönetim_uygulaması
{
    public partial class frDairecs : Form
    {
        // Mysql bağlantı kodları.
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        // Ana form da seçilen daireyi parametre atayarak o dairenin bulunduğu satırdaki verileri görüntüleme.
        public frDairecs(string secilenDaire)
        {
            InitializeComponent();
            Verilerigoster(secilenDaire);

        }


        //  Daire formu açıldığında seçilen daireye ait bilgilerin textboxlara yazdırılması ve mysql girişi.
        private void Verilerigoster(string secilenDaire)
        {
            con = new MySqlConnection("Server=localhost;Database=binayonetim;Uid=root;Pwd=123123;");



            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM kisibilgiler where Daire='" + secilenDaire + "'";
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtAd.Text = dr["Ad"].ToString();
                txtSoyad.Text = dr["Soyad"].ToString();
                txtDaireno.Text = dr["Daire"].ToString();
                txtTel.Text = dr["Telefon"].ToString();
                txtBorç.Text = dr["Borc"].ToString();

            }
            con.Close();






        }


        private void frDairecs_Load(object sender, EventArgs e)
        {

        }
        //  Ana sayfaya dönüş butonu.
        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            frAna fr = new frAna();
            fr.Show();
            this.Hide();
        }
    }
}
