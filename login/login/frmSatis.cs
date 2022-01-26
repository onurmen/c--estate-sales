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
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }
        OleDbConnection network = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\logindb.accdb ");
        DataTable tablo = new DataTable();

        private void frmSatis_Load(object sender, EventArgs e)
        {
            network.Open();
            OleDbCommand inst = new OleDbCommand("select * from islemler", network);
            OleDbDataAdapter adap = new OleDbDataAdapter(inst);
            adap.Fill(tablo);
            dataGridView1.DataSource = tablo;
            network.Close();

            /*baglanti.Open();
            OleDbCommand komut2 = new OleDbCommand("select * from musteri", baglanti);
            OleDbDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                cb_musteri.Items.Add(dr["adi"]);

            }
            baglanti.Close();*/

            /*baglanti.Open();
            OleDbCommand komutEv = new OleDbCommand("select * from EVLER", baglanti);
            OleDbDataReader drEv = komutEv.ExecuteReader();
            while (drEv.Read())
            {
                cb_ev.Items.Add(drEv["adres"]);
                cb_ev.Items.Add(drEv["adres"]);

            }
            baglanti.Close();*/

            network.Open();
            OleDbCommand cmd = new OleDbCommand("select * from EVLER", network);
            OleDbDataAdapter adapEv = new OleDbDataAdapter(cmd);
            DataTable tbl = new DataTable();
            tbl.Load(cmd.ExecuteReader());

            adapEv.Fill(tbl);

            cb_ev.DisplayMember = "adres";
            cb_ev.ValueMember = "ev_id";
            cb_ev.DataSource = tbl;
            network.Close();




            network.Open();
            OleDbCommand cmd22 = new OleDbCommand("select * from musteri", network);
            OleDbDataAdapter adapEv2 = new OleDbDataAdapter(cmd22);
            DataTable tbl2 = new DataTable();
            tbl2.Load(cmd.ExecuteReader());

            adapEv2.Fill(tbl2);

            cb_musteri.DisplayMember = "adi";
            cb_musteri.ValueMember = "id";
            cb_musteri.DataSource = tbl2;
            network.Close();

        }

        private void btn_rapor_Click(object sender, EventArgs e)
        {

        }

        private void btn_sat_Click(object sender, EventArgs e)
        {
            network.Open();
            OleDbCommand inst = new OleDbCommand("insert into islemler (müsteri_id,ev_id,satis_tarih,satis_bedeli) values ('" + cb_musteri.SelectedValue + "','" + cb_ev.SelectedValue + "','" + txtTarih.Text + "','" + txtBedel.Text + "')", network);
            inst.ExecuteNonQuery();
            MessageBox.Show("satis yapildi");
            network.Close();
            txtTarih.Clear();
            txtBedel.Clear();
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            anasayfa ANASAYFA = new anasayfa();
            ANASAYFA.Show();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox0.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //cb_musteri.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //cb_ev.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            cb_musteri.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cb_ev.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            txtTarih.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtBedel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            network.Open();
            OleDbCommand inst = new OleDbCommand("delete from islemler where satis_id=" + textBox0.Text + "", network);
            inst.ExecuteNonQuery();
            MessageBox.Show("Satis silindi");
            network.Close();
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            network.Open();
            OleDbCommand inst = new OleDbCommand("UPDATE islemler set müsteri_id='" + cb_musteri.SelectedValue + "', ev_id='" + cb_ev.SelectedValue + "', satis_tarih='" + txtTarih.Text + "',satis_bedeli='" + txtBedel.Text + "' where satis_id=" + textBox0.Text + "", network);
            inst.ExecuteNonQuery();
            MessageBox.Show("Satis Güncellendi");
            network.Close();
        }
    }
}
