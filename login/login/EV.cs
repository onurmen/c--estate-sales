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
    public partial class EV : Form
    {
        public EV()
        {
            InitializeComponent();
        }
        OleDbConnection network = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=logindb.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
            network.Open();
            OleDbCommand inst = new OleDbCommand("insert into EVLER(adres,katsayi,odasayi,durum,binayasi,fiyat,metrekaresi,esyali,aidat) values ('" + tx_adres.Text + "','" + cb_kat.Text + "','" + cb_oda.Text + "','" + cb_durum.Text + "','" + cb_binayas.Text + "','" + tx_fiyat.Text + "','"+tx_mt.Text+"','"+tx_esya.Text+"','"+tx_aidat.Text+"')", network);
            inst.ExecuteNonQuery();
            MessageBox.Show("Ev bilgileri eklendi");
            network.Close();
            tx_adres.Clear();
            tx_fiyat.Clear();
            tx_mt.Clear();
            tx_esya.Clear();
            tx_aidat.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            network.Open();
            OleDbCommand inst = new OleDbCommand("delete from EVLER where ev_id=" + tb_id.Text + "", network);
            inst.ExecuteNonQuery();
            MessageBox.Show("Ev bilgileri silindi");
            network.Close();
            tx_adres.Clear();
            tx_fiyat.Clear();
            tx_mt.Clear();
            tx_esya.Clear();
            //tx_aidat.Clear();
        }
        DataTable tablo = new DataTable();
        private void EV_Load(object sender, EventArgs e)
        {
            network.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("select * from EVLER", network);
            adap.Fill(tablo);
            dataGridView.DataSource = tablo;
            network.Close();
        }

        private void cb_oda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_binayas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_durum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_kat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            string ara = tb_aranacak.Text;
            network.Open();
            OleDbCommand inst = new OleDbCommand("select * from EVLER where adres Like '%" + ara + "%' ", network);
            OleDbDataAdapter adap = new OleDbDataAdapter(inst);
            DataSet ds = new DataSet();
            adap.Fill(ds);

            dataGridView.DataSource = ds.Tables[0];
            network.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            anasayfa ANASAYFA = new anasayfa();
            ANASAYFA.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            network.Open();
            OleDbCommand inst = new OleDbCommand ("update EVLER set adres='" + tx_adres.Text + "', katsayi='" + cb_kat.Text + "', odasayi='" + cb_oda.Text + "', durum='" + cb_durum.Text + "', binayasi='" + cb_binayas.Text + "', fiyat='" + tx_fiyat.Text + "', metrekaresi='" + tx_mt.Text + "', esyali='" + tx_esya.Text + "', aidat='" + tx_aidat.Text + "' where ev_id=" + tb_id.Text + "", network);
            inst.ExecuteNonQuery();
            MessageBox.Show("Ev Güncellendi");
            network.Close();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_id.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            tx_adres.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            cb_kat.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            cb_oda.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            cb_durum.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            cb_binayas.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
            tx_fiyat.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
            tx_mt.Text = dataGridView.CurrentRow.Cells[7].Value.ToString();
            tx_esya.Text = dataGridView.CurrentRow.Cells[8].Value.ToString();
            tx_aidat.Text = dataGridView.CurrentRow.Cells[9].Value.ToString();
        }
    }
}
