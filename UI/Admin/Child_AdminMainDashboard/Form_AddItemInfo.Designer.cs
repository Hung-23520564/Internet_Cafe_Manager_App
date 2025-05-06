namespace Internet_Cafe_Manager_App.UI.Admin.Child_AdminMainDashboard
{
    partial class Form_AddItemInfo
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
            temizleBtn = new Button();
            idLbl = new Label();
            baslikLbl = new Label();
            ekleBtn = new Button();
            uyariLbl = new Label();
            yoneticiChk = new CheckBox();
            sifreTxt = new TextBox();
            kayitPnl = new Panel();
            label3 = new Label();
            duzenleBtn = new Button();
            kaldirBtn = new Button();
            per_soy_lbl = new Label();
            per_pass_lbl = new Label();
            adTxt = new TextBox();
            kullaniciAdiTxt = new TextBox();
            soyadTxt = new TextBox();
            per_nick_lbl = new Label();
            per_ad_lbl = new Label();
            personelDat = new DataGridView();
            kayitPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)personelDat).BeginInit();
            SuspendLayout();
            // 
            // temizleBtn
            // 
            temizleBtn.Location = new Point(39, 153);
            temizleBtn.Margin = new Padding(3, 4, 3, 4);
            temizleBtn.Name = "temizleBtn";
            temizleBtn.Size = new Size(86, 31);
            temizleBtn.TabIndex = 16;
            temizleBtn.Text = "Temizle";
            temizleBtn.UseVisualStyleBackColor = true;
            // 
            // idLbl
            // 
            idLbl.AutoSize = true;
            idLbl.Location = new Point(198, 170);
            idLbl.Name = "idLbl";
            idLbl.Size = new Size(17, 20);
            idLbl.TabIndex = 15;
            idLbl.Text = "0";
            // 
            // baslikLbl
            // 
            baslikLbl.AutoSize = true;
            baslikLbl.Font = new Font("Segoe UI", 14.25F);
            baslikLbl.Location = new Point(90, 22);
            baslikLbl.Name = "baslikLbl";
            baslikLbl.Size = new Size(259, 32);
            baslikLbl.TabIndex = 12;
            baslikLbl.Text = "Personel Kayıt İşlemleri";
            // 
            // ekleBtn
            // 
            ekleBtn.Location = new Point(39, 439);
            ekleBtn.Margin = new Padding(3, 4, 3, 4);
            ekleBtn.Name = "ekleBtn";
            ekleBtn.Size = new Size(86, 31);
            ekleBtn.TabIndex = 9;
            ekleBtn.Text = "Ekle";
            ekleBtn.UseVisualStyleBackColor = true;
            // 
            // uyariLbl
            // 
            uyariLbl.Font = new Font("Segoe UI", 9.75F);
            uyariLbl.ForeColor = Color.Firebrick;
            uyariLbl.Location = new Point(13, 65);
            uyariLbl.Margin = new Padding(3, 21, 3, 0);
            uyariLbl.Name = "uyariLbl";
            uyariLbl.Size = new Size(373, 23);
            uyariLbl.TabIndex = 4;
            uyariLbl.Text = "Uyarı";
            uyariLbl.TextAlign = ContentAlignment.MiddleCenter;
            uyariLbl.Visible = false;
            // 
            // yoneticiChk
            // 
            yoneticiChk.AutoSize = true;
            yoneticiChk.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            yoneticiChk.Location = new Point(198, 380);
            yoneticiChk.Margin = new Padding(3, 4, 3, 4);
            yoneticiChk.Name = "yoneticiChk";
            yoneticiChk.Size = new Size(86, 24);
            yoneticiChk.TabIndex = 8;
            yoneticiChk.Text = "Yönetici";
            yoneticiChk.UseVisualStyleBackColor = true;
            // 
            // sifreTxt
            // 
            sifreTxt.Location = new Point(189, 315);
            sifreTxt.Margin = new Padding(3, 4, 3, 4);
            sifreTxt.Name = "sifreTxt";
            sifreTxt.Size = new Size(114, 27);
            sifreTxt.TabIndex = 7;
            // 
            // kayitPnl
            // 
            kayitPnl.Controls.Add(temizleBtn);
            kayitPnl.Controls.Add(idLbl);
            kayitPnl.Controls.Add(label3);
            kayitPnl.Controls.Add(baslikLbl);
            kayitPnl.Controls.Add(ekleBtn);
            kayitPnl.Controls.Add(uyariLbl);
            kayitPnl.Controls.Add(duzenleBtn);
            kayitPnl.Controls.Add(yoneticiChk);
            kayitPnl.Controls.Add(kaldirBtn);
            kayitPnl.Controls.Add(sifreTxt);
            kayitPnl.Controls.Add(per_soy_lbl);
            kayitPnl.Controls.Add(per_pass_lbl);
            kayitPnl.Controls.Add(adTxt);
            kayitPnl.Controls.Add(kullaniciAdiTxt);
            kayitPnl.Controls.Add(soyadTxt);
            kayitPnl.Controls.Add(per_nick_lbl);
            kayitPnl.Controls.Add(per_ad_lbl);
            kayitPnl.Location = new Point(744, -2);
            kayitPnl.Margin = new Padding(9, 0, 0, 0);
            kayitPnl.Name = "kayitPnl";
            kayitPnl.Padding = new Padding(9, 11, 9, 11);
            kayitPnl.Size = new Size(398, 981);
            kayitPnl.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(168, 170);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 13;
            label3.Text = "Id:";
            // 
            // duzenleBtn
            // 
            duzenleBtn.Location = new Point(157, 439);
            duzenleBtn.Margin = new Padding(3, 4, 3, 4);
            duzenleBtn.Name = "duzenleBtn";
            duzenleBtn.Size = new Size(86, 31);
            duzenleBtn.TabIndex = 11;
            duzenleBtn.Text = "Düzenle";
            duzenleBtn.UseVisualStyleBackColor = true;
            // 
            // kaldirBtn
            // 
            kaldirBtn.Location = new Point(274, 439);
            kaldirBtn.Margin = new Padding(3, 4, 3, 4);
            kaldirBtn.Name = "kaldirBtn";
            kaldirBtn.Size = new Size(86, 31);
            kaldirBtn.TabIndex = 10;
            kaldirBtn.Text = "Kaldır";
            kaldirBtn.UseVisualStyleBackColor = true;
            // 
            // per_soy_lbl
            // 
            per_soy_lbl.AutoSize = true;
            per_soy_lbl.Location = new Point(208, 223);
            per_soy_lbl.Name = "per_soy_lbl";
            per_soy_lbl.Size = new Size(57, 20);
            per_soy_lbl.TabIndex = 2;
            per_soy_lbl.Text = "Soyadı:";
            // 
            // per_pass_lbl
            // 
            per_pass_lbl.AutoSize = true;
            per_pass_lbl.Location = new Point(153, 330);
            per_pass_lbl.Name = "per_pass_lbl";
            per_pass_lbl.Size = new Size(42, 20);
            per_pass_lbl.TabIndex = 6;
            per_pass_lbl.Text = "Şifre:";
            // 
            // adTxt
            // 
            adTxt.Location = new Point(66, 208);
            adTxt.Margin = new Padding(3, 4, 3, 4);
            adTxt.Name = "adTxt";
            adTxt.Size = new Size(122, 27);
            adTxt.TabIndex = 1;
            // 
            // kullaniciAdiTxt
            // 
            kullaniciAdiTxt.Location = new Point(189, 261);
            kullaniciAdiTxt.Margin = new Padding(3, 4, 3, 4);
            kullaniciAdiTxt.Name = "kullaniciAdiTxt";
            kullaniciAdiTxt.Size = new Size(114, 27);
            kullaniciAdiTxt.TabIndex = 5;
            // 
            // soyadTxt
            // 
            soyadTxt.Location = new Point(257, 208);
            soyadTxt.Margin = new Padding(3, 4, 3, 4);
            soyadTxt.Name = "soyadTxt";
            soyadTxt.Size = new Size(114, 27);
            soyadTxt.TabIndex = 3;
            // 
            // per_nick_lbl
            // 
            per_nick_lbl.AutoSize = true;
            per_nick_lbl.Location = new Point(104, 276);
            per_nick_lbl.Name = "per_nick_lbl";
            per_nick_lbl.Size = new Size(95, 20);
            per_nick_lbl.TabIndex = 4;
            per_nick_lbl.Text = "Kullanıcı Adı:";
            // 
            // per_ad_lbl
            // 
            per_ad_lbl.AutoSize = true;
            per_ad_lbl.Location = new Point(36, 223);
            per_ad_lbl.Name = "per_ad_lbl";
            per_ad_lbl.Size = new Size(35, 20);
            per_ad_lbl.TabIndex = 0;
            per_ad_lbl.Text = "Adı:";
            // 
            // personelDat
            // 
            personelDat.AllowUserToAddRows = false;
            personelDat.AllowUserToDeleteRows = false;
            personelDat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            personelDat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            personelDat.Location = new Point(9, -2);
            personelDat.Margin = new Padding(0, 0, 9, 0);
            personelDat.Name = "personelDat";
            personelDat.ReadOnly = true;
            personelDat.RowHeadersWidth = 51;
            personelDat.RowTemplate.Height = 25;
            personelDat.Size = new Size(736, 981);
            personelDat.TabIndex = 13;
            // 
            // Form_AddItemInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 538);
            Controls.Add(kayitPnl);
            Controls.Add(personelDat);
            Name = "Form_AddItemInfo";
            Text = "Form_AddItemInfo";
            kayitPnl.ResumeLayout(false);
            kayitPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)personelDat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button temizleBtn;
        private Label idLbl;
        private Label baslikLbl;
        private Button ekleBtn;
        private Label uyariLbl;
        private CheckBox yoneticiChk;
        private TextBox sifreTxt;
        private Panel kayitPnl;
        private Label label3;
        private Button duzenleBtn;
        private Button kaldirBtn;
        private Label per_soy_lbl;
        private Label per_pass_lbl;
        private TextBox adTxt;
        private TextBox kullaniciAdiTxt;
        private TextBox soyadTxt;
        private Label per_nick_lbl;
        private Label per_ad_lbl;
        private DataGridView personelDat;
    }
}