
namespace login
{
    partial class frmSifremiUnuttum
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
            this.tb_eskiSifre = new System.Windows.Forms.TextBox();
            this.tb_yeniSifre = new System.Windows.Forms.TextBox();
            this.tb_yeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_eskiSifre
            // 
            this.tb_eskiSifre.Location = new System.Drawing.Point(240, 37);
            this.tb_eskiSifre.Name = "tb_eskiSifre";
            this.tb_eskiSifre.Size = new System.Drawing.Size(122, 27);
            this.tb_eskiSifre.TabIndex = 0;
            // 
            // tb_yeniSifre
            // 
            this.tb_yeniSifre.Location = new System.Drawing.Point(240, 84);
            this.tb_yeniSifre.Name = "tb_yeniSifre";
            this.tb_yeniSifre.Size = new System.Drawing.Size(122, 27);
            this.tb_yeniSifre.TabIndex = 0;
            // 
            // tb_yeniSifreTekrar
            // 
            this.tb_yeniSifreTekrar.Location = new System.Drawing.Point(240, 131);
            this.tb_yeniSifreTekrar.Name = "tb_yeniSifreTekrar";
            this.tb_yeniSifreTekrar.Size = new System.Drawing.Size(122, 27);
            this.tb_yeniSifreTekrar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(109, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eski Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(109, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yeni Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(109, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yeni Şifre Tekrar";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(240, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Şifre Değiştir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_back.Location = new System.Drawing.Point(418, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(171, 34);
            this.btn_back.TabIndex = 41;
            this.btn_back.Text = "Anasayfa";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // frmSifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(601, 263);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_yeniSifreTekrar);
            this.Controls.Add(this.tb_yeniSifre);
            this.Controls.Add(this.tb_eskiSifre);
            this.Name = "frmSifremiUnuttum";
            this.Text = "frmSifremiUnuttum";
            this.Load += new System.EventHandler(this.frmSifremiUnuttum_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_eskiSifre;
        private System.Windows.Forms.TextBox tb_yeniSifre;
        private System.Windows.Forms.TextBox tb_yeniSifreTekrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_back;
    }
}