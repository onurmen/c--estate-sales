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
    public partial class MUSTERİ : Form
    {
        public MUSTERİ()
        {
            InitializeComponent();
        }
        OleDbConnection network = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\logindb.accdb ");
        DataTable tablo = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {

            network.Open();
            OleDbCommand inst = new OleDbCommand("insert into musteri (tc,adi,soyadi,dogum,telefon,adres) values ('" + textBox1.Text + "','" +textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')", network);
            inst.ExecuteNonQuery();
            MessageBox.Show("Müşteri eklendi");
            network.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            network.Open();
            OleDbCommand inst = new OleDbCommand("delete from musteri where id=" + textBox0.Text + "", network);
            inst.ExecuteNonQuery();
            MessageBox.Show("Müşteri silindi");
            network.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            network.Open();
            OleDbCommand inst = new OleDbCommand("UPDATE musteri set tc='"+textBox1.Text + "', adi='" + textBox2.Text + "', soyadi='" + textBox3.Text + "',dogum='"+textBox4.Text+"',telefon='"+textBox5.Text+"',adres='"+textBox6.Text+"'where id="+textBox0.Text+"",network);
            inst.ExecuteNonQuery();
            MessageBox.Show("Müşteri Güncellendi");
            network.Close();
            textBox0.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            network.Open();
            OleDbCommand inst=new OleDbCommand("select * from musteri where tc='"+textBox1.Text+"'", network);
            OleDbDataReader read=inst.ExecuteReader();
            while (read.Read())
            {
                textBox2.Text =read["adi"].ToString();
                textBox3.Text =read["soyadi"].ToString();
                textBox4.Text =read["dogum"].ToString();
                textBox5.Text =read["telefon"].ToString();
                textBox6.Text =read["adres"].ToString();
                
            }
            network.Close();
        }

        private void MUSTERİ_Load(object sender, EventArgs e)
        {
            
        }

        private void MUSTERİ_Load_1(object sender, EventArgs e)
        {
            network.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("select * from musteri", network);
            adap.Fill(tablo);
            dataGridView.DataSource = tablo;
            network.Close();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            string ara = tb_aranacak.Text;
            network.Open();
            OleDbCommand inst = new OleDbCommand("select * from musteri where adi Like '%" + ara + "%' ", network);
            OleDbDataAdapter adap = new OleDbDataAdapter(inst);
            DataSet ds = new DataSet();
            adap.Fill(ds);

            dataGridView.DataSource = ds.Tables[0];
            network.Close();
        }

        private void tb_aranacak_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            anasayfa ANASAYFA = new anasayfa();
            ANASAYFA.Show();
            this.Close();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox0.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
