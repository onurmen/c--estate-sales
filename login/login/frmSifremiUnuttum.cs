using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace login
{
    public partial class frmSifremiUnuttum : Form
    {
        public frmSifremiUnuttum()
        {
            InitializeComponent();
        }
        OleDbConnection network = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\logindb.accdb ");
        DataTable tablo = new DataTable();

        private void frmSifremiUnuttum_Load(object sender, EventArgs e)
        {

        }

        private void frmSifremiUnuttum_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Ku_adi;
            Ku_adi = girisekran.Ku_adi;


            string sifreVT = "";
            string eskiSifre = tb_eskiSifre.Text;
            string yeniSifre = tb_yeniSifre.Text;
            string yeniSifreTekrar = tb_yeniSifreTekrar.Text;
            

            network.Open();
            OleDbCommand ints = new OleDbCommand("select * from KULLANICI where kullanici='" + Ku_adi.ToString() + "'", network);
            OleDbDataReader read = ints.ExecuteReader();
            while (read.Read())
            {
                sifreVT= read["sifre"].ToString();
            }
            network.Close();

            if(sifreVT== eskiSifre)
            {
                if(yeniSifre== yeniSifreTekrar)
                {
                    network.Open();
                    OleDbCommand inst2 = new OleDbCommand("UPDATE KULLANICI set sifre='" + yeniSifre.ToString() + "'where kullanici='" + Ku_adi + "'", network);
                    inst2.ExecuteNonQuery();
                    MessageBox.Show("KULLANICI Sifre Değiştirildi");
                    network.Close();
                    anasayfa ANASAYFA = new anasayfa();
                    ANASAYFA.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Yeni sifre ve tekrar sifre aynı değilll !!!!");
                }
            }
            else
            {
                MessageBox.Show("Eski Sifre Hatalı");
            }
        }
    }
}
