using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class girisekran : Form
    {
        public girisekran()
        {
            InitializeComponent();
        }
        public static String Ku_adi;
        OleDbConnection network = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=logindb.accdb");
        OleDbCommand cmd;
        OleDbDataReader dr;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string ad = textKullanici.Text;
            string parola = textSifre.Text;
            cmd = new OleDbCommand();
            network.Open();
            cmd.Connection = network;
            cmd.CommandText = "SELECT *FROM KULLANICI WHERE kullanici='" + ad + "' AND sifre='" + parola + "'";
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                Ku_adi = dr["kullanici"].ToString();
                anasayfa ANASAYFA = new anasayfa();
                ANASAYFA.Show();
                

            }
            else
            {
                label3.Text = "Kullanıcı Adı veya  Şifre Hatalı!!!";
            }
            
            network.Close();


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSifremiUnuttum frm = new frmSifremiUnuttum();
            frm.ShowDialog();
        
        }

        private void btnYenikullanici_Click(object sender, EventArgs e)
        {
            frmYeniKullanici frm = new frmYeniKullanici();
            frm.ShowDialog();
        }

        private void girisekran_Load(object sender, EventArgs e)
        {

        }
    }
}
