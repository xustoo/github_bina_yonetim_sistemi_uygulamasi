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

namespace Bina_yönetim_uygulaması
{
    public partial class frdegistir : Form
    {
        //  Mysql bağlantı kodları.
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        /*  textboxlara eski şifre ve yeni şifrenin girilmesiyle eski şifrenin database de olan şifre ile 
        sorgulanıp doğrulanması ve eğer veri doğruysa yeni şifrenin eski şifre yerine geçmesi.    */
        public frdegistir()
        {
            InitializeComponent();
        }
        //  Sql bağlantıları ve şifre değişim işlerinin sql de sorgu ve güncelleme yapılarak ayarlanması.
        private void btnDegistir_Click(object sender, EventArgs e)
        {
            con = new MySqlConnection("Server=localhost;Database=Binayonetim;Uid=root;Pwd=123123;");
            string pass = txtEskisifre.Text;
            string newpass = txtYenisifre.Text;
            string user = "Admin";
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;


            cmd.CommandText = "SELECT * FROM kullanicibilgileri where KullaniciAdi='" + user + "' AND Sifre='" + pass + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                con.Open();

                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE kullanicibilgileri set KullaniciAdi ='" + user + "', Sifre='" + newpass + "'  where KullaniciAdi='" + user + "'";


                cmd.ExecuteNonQuery();

                MessageBox.Show("Başarıyla değiştirildi");
            }
            else
            {
                MessageBox.Show("Eski sifrenizi yanlış girdiniz.");
            }
            con.Close();

        }
        //  Menüye dönme butonu.
        private void btnMenu_Click(object sender, EventArgs e)
        {
            frMenu fr = new frMenu();
            fr.Show();
            this.Hide();
        }
    }
}
