
namespace login
{
    partial class frmSatis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_sat = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.txtBedel = new System.Windows.Forms.TextBox();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.cb_musteri = new System.Windows.Forms.ComboBox();
            this.cb_ev = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_rapor = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox0 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(776, 187);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_sat
            // 
            this.btn_sat.BackColor = System.Drawing.SystemColors.Info;
            this.btn_sat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_sat.Location = new System.Drawing.Point(364, 334);
            this.btn_sat.Name = "btn_sat";
            this.btn_sat.Size = new System.Drawing.Size(159, 34);
            this.btn_sat.TabIndex = 1;
            this.btn_sat.Text = "Satış Yap";
            this.btn_sat.UseVisualStyleBackColor = false;
            this.btn_sat.Click += new System.EventHandler(this.btn_sat_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.SystemColors.Info;
            this.btn_sil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sil.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_sil.Location = new System.Drawing.Point(364, 393);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(159, 34);
            this.btn_sil.TabIndex = 1;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.BackColor = System.Drawing.SystemColors.Info;
            this.btn_güncelle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_güncelle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_güncelle.Location = new System.Drawing.Point(364, 448);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(159, 34);
            this.btn_güncelle.TabIndex = 1;
            this.btn_güncelle.Text = "Güncelle";
            this.btn_güncelle.UseVisualStyleBackColor = false;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // txtBedel
            // 
            this.txtBedel.Location = new System.Drawing.Point(160, 489);
            this.txtBedel.Name = "txtBedel";
            this.txtBedel.Size = new System.Drawing.Size(125, 27);
            this.txtBedel.TabIndex = 2;
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(160, 430);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(125, 27);
            this.txtTarih.TabIndex = 2;
            // 
            // cb_musteri
            // 
            this.cb_musteri.FormattingEnabled = true;
            this.cb_musteri.Location = new System.Drawing.Point(160, 316);
            this.cb_musteri.Name = "cb_musteri";
            this.cb_musteri.Size = new System.Drawing.Size(151, 28);
            this.cb_musteri.TabIndex = 3;
            // 
            // cb_ev
            // 
            this.cb_ev.FormattingEnabled = true;
            this.cb_ev.Location = new System.Drawing.Point(160, 373);
            this.cb_ev.Name = "cb_ev";
            this.cb_ev.Size = new System.Drawing.Size(151, 28);
            this.cb_ev.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Müşteri ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(54, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ev ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(54, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Satış Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(54, 492);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Satış Bedeli";
            // 
            // btn_rapor
            // 
            this.btn_rapor.BackColor = System.Drawing.SystemColors.Info;
            this.btn_rapor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_rapor.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_rapor.Location = new System.Drawing.Point(629, 248);
            this.btn_rapor.Name = "btn_rapor";
            this.btn_rapor.Size = new System.Drawing.Size(159, 34);
            this.btn_rapor.TabIndex = 5;
            this.btn_rapor.Text = "Rapor";
            this.btn_rapor.UseVisualStyleBackColor = false;
            this.btn_rapor.Click += new System.EventHandler(this.btn_rapor_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.Info;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_back.Location = new System.Drawing.Point(617, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(171, 34);
            this.btn_back.TabIndex = 41;
            this.btn_back.Text = "Anasayfa";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(54, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "ID";
            // 
            // textBox0
            // 
            this.textBox0.Location = new System.Drawing.Point(160, 278);
            this.textBox0.Name = "textBox0";
            this.textBox0.Size = new System.Drawing.Size(125, 27);
            this.textBox0.TabIndex = 42;
            // 
            // frmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox0);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_rapor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_ev);
            this.Controls.Add(this.cb_musteri);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.txtBedel);
            this.Controls.Add(this.btn_güncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_sat);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSatis";
            this.Text = "frmSatis";
            this.Load += new System.EventHandler(this.frmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_sat;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.TextBox txtBedel;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.ComboBox cb_musteri;
        private System.Windows.Forms.ComboBox cb_ev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_rapor;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox0;
    }
}