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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }
        OleDbConnection network = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\logindb.accdb ");
        DataTable tablo = new DataTable();
        DataTable tablo2 = new DataTable();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            network.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("select * from EVLER", network);
            adap.Fill(tablo);
            dataGridView.DataSource = tablo;
            network.Close();
        }


        private void btn_cık_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_musteri_Click(object sender, EventArgs e)
        {
            Form mus = new MUSTERİ();
            mus.Show();
            this.Close();
        }


        private void btn_ev_Click(object sender, EventArgs e)
        {
            Form EV = new EV();
            EV.Show();
            this.Close();
        }

        private void kullanıcıŞifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSifremiUnuttum sifremiUnuttum = new frmSifremiUnuttum();
            sifremiUnuttum.Show();
            this.Close();
        }

        private void müşteriKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form mus = new MUSTERİ();
            mus.Show();
            this.Close();
        }

        private void evKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form EV = new EV();
            EV.Show();
            this.Close();
        }

        private void btn_satis_Click(object sender, EventArgs e)
        {
            frmSatis frmSat = new frmSatis();
            frmSat.Show();
            this.Close();
        }

        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSatis frmSat = new frmSatis();
            frmSat.Show();
            this.Close();
        }
    }
}
