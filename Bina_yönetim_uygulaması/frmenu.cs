﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bina_yönetim_uygulaması
{
    public partial class frMenu : Form
    {
        public frMenu()
        {
            InitializeComponent();
        }
        //  Ana sayfaya dönme butonu.
        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            frAna fr = new frAna();
            fr.Show();
            this.Hide();
        }
        //  Kayıt formuna gitme butonu.
        private void btnKayıt_Click(object sender, EventArgs e)
        {
            frKayıt fr = new frKayıt();
            fr.Show();
            this.Hide();
        }
        //  Kullanıcı bilgilerine gitme butonu.
        private void btnBilgiler_Click(object sender, EventArgs e)
        {
            frBilgiler fr = new frBilgiler();
            fr.Show();
            this.Hide();
        }



        private void frMenu_Load(object sender, EventArgs e)
        {


        }
        //  Hakkımızdaki bilgileri Messagebox da görme butonu.
        private void btnHakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bina-Yönetim uygulaması 2023 tarihinde 2 öğrenci tarafından yapılmıştır.Kullandığınız için teşekkür ederiz.");
        }
        //  Şifre değiştirme formuna gitme butonu.
        private void btnSifredegistir_Click(object sender, EventArgs e)
        {
            frdegistir fr = new frdegistir();
            fr.Show();
            this.Hide();
        }
    }
}
