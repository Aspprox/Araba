namespace Araba
{
    partial class ArabaOzellikleri
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
            this.bKaydet = new System.Windows.Forms.Button();
            this.bGoster = new System.Windows.Forms.Button();
            this.lid = new System.Windows.Forms.Label();
            this.lModel = new System.Windows.Forms.Label();
            this.lMarka = new System.Windows.Forms.Label();
            this.lKapısayi = new System.Windows.Forms.Label();
            this.lBeygirgücü = new System.Windows.Forms.Label();
            this.lArabatür = new System.Windows.Forms.Label();
            this.lMaxhiz = new System.Windows.Forms.Label();
            this.lCekis = new System.Windows.Forms.Label();
            this.lSıfıryüz = new System.Windows.Forms.Label();
            this.lAgirlik = new System.Windows.Forms.Label();
            this.lmotorhacmi = new System.Windows.Forms.Label();
            this.tId = new System.Windows.Forms.TextBox();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.cbKapı = new System.Windows.Forms.ComboBox();
            this.tbBeygir = new System.Windows.Forms.TextBox();
            this.rbBinek = new System.Windows.Forms.RadioButton();
            this.rbTicari = new System.Windows.Forms.RadioButton();
            this.tbMaxhiz = new System.Windows.Forms.TextBox();
            this.cbCekis = new System.Windows.Forms.ComboBox();
            this.tbSifiryüz = new System.Windows.Forms.TextBox();
            this.tbAgirlik = new System.Windows.Forms.TextBox();
            this.tbMotorHacmi = new System.Windows.Forms.TextBox();
            this.rtbSonuc = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bKaydet
            // 
            this.bKaydet.Location = new System.Drawing.Point(174, 349);
            this.bKaydet.Name = "bKaydet";
            this.bKaydet.Size = new System.Drawing.Size(75, 23);
            this.bKaydet.TabIndex = 0;
            this.bKaydet.Text = "Kaydet";
            this.bKaydet.UseVisualStyleBackColor = true;
            this.bKaydet.Click += new System.EventHandler(this.bKaydet_Click);
            // 
            // bGoster
            // 
            this.bGoster.Location = new System.Drawing.Point(265, 349);
            this.bGoster.Name = "bGoster";
            this.bGoster.Size = new System.Drawing.Size(75, 23);
            this.bGoster.TabIndex = 1;
            this.bGoster.Text = "Göster";
            this.bGoster.UseVisualStyleBackColor = true;
            this.bGoster.Click += new System.EventHandler(this.bGoster_Click);
            // 
            // lid
            // 
            this.lid.AutoSize = true;
            this.lid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lid.Location = new System.Drawing.Point(19, 47);
            this.lid.Name = "lid";
            this.lid.Size = new System.Drawing.Size(35, 18);
            this.lid.TabIndex = 2;
            this.lid.Text = "Id(*)";
            // 
            // lModel
            // 
            this.lModel.AutoSize = true;
            this.lModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lModel.Location = new System.Drawing.Point(16, 100);
            this.lModel.Name = "lModel";
            this.lModel.Size = new System.Drawing.Size(65, 18);
            this.lModel.TabIndex = 3;
            this.lModel.Text = "Model(*)";
            // 
            // lMarka
            // 
            this.lMarka.AutoSize = true;
            this.lMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lMarka.Location = new System.Drawing.Point(16, 73);
            this.lMarka.Name = "lMarka";
            this.lMarka.Size = new System.Drawing.Size(66, 18);
            this.lMarka.TabIndex = 4;
            this.lMarka.Text = "Marka(*)";
            // 
            // lKapısayi
            // 
            this.lKapısayi.AutoSize = true;
            this.lKapısayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lKapısayi.Location = new System.Drawing.Point(13, 126);
            this.lKapısayi.Name = "lKapısayi";
            this.lKapısayi.Size = new System.Drawing.Size(96, 18);
            this.lKapısayi.TabIndex = 5;
            this.lKapısayi.Text = "Kapı Sayısı(*)";
            // 
            // lBeygirgücü
            // 
            this.lBeygirgücü.AutoSize = true;
            this.lBeygirgücü.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lBeygirgücü.Location = new System.Drawing.Point(13, 156);
            this.lBeygirgücü.Name = "lBeygirgücü";
            this.lBeygirgücü.Size = new System.Drawing.Size(89, 18);
            this.lBeygirgücü.TabIndex = 6;
            this.lBeygirgücü.Text = "Beygir Gücü";
            // 
            // lArabatür
            // 
            this.lArabatür.AutoSize = true;
            this.lArabatür.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lArabatür.Location = new System.Drawing.Point(12, 181);
            this.lArabatür.Name = "lArabatür";
            this.lArabatür.Size = new System.Drawing.Size(80, 18);
            this.lArabatür.TabIndex = 7;
            this.lArabatür.Text = "Araba Türü";
            // 
            // lMaxhiz
            // 
            this.lMaxhiz.AutoSize = true;
            this.lMaxhiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lMaxhiz.Location = new System.Drawing.Point(13, 208);
            this.lMaxhiz.Name = "lMaxhiz";
            this.lMaxhiz.Size = new System.Drawing.Size(105, 18);
            this.lMaxhiz.TabIndex = 8;
            this.lMaxhiz.Text = "Max Hız(km/h)";
            // 
            // lCekis
            // 
            this.lCekis.AutoSize = true;
            this.lCekis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lCekis.Location = new System.Drawing.Point(16, 235);
            this.lCekis.Name = "lCekis";
            this.lCekis.Size = new System.Drawing.Size(62, 18);
            this.lCekis.TabIndex = 9;
            this.lCekis.Text = "Çekiş(*)";
            // 
            // lSıfıryüz
            // 
            this.lSıfıryüz.AutoSize = true;
            this.lSıfıryüz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSıfıryüz.Location = new System.Drawing.Point(13, 261);
            this.lSıfıryüz.Name = "lSıfıryüz";
            this.lSıfıryüz.Size = new System.Drawing.Size(63, 18);
            this.lSıfıryüz.TabIndex = 10;
            this.lSıfıryüz.Text = "0-100(s)";
            // 
            // lAgirlik
            // 
            this.lAgirlik.AutoSize = true;
            this.lAgirlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lAgirlik.Location = new System.Drawing.Point(13, 287);
            this.lAgirlik.Name = "lAgirlik";
            this.lAgirlik.Size = new System.Drawing.Size(73, 18);
            this.lAgirlik.TabIndex = 11;
            this.lAgirlik.Text = "Ağırlık(kg)";
            // 
            // lmotorhacmi
            // 
            this.lmotorhacmi.AutoSize = true;
            this.lmotorhacmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lmotorhacmi.Location = new System.Drawing.Point(12, 313);
            this.lmotorhacmi.Name = "lmotorhacmi";
            this.lmotorhacmi.Size = new System.Drawing.Size(134, 18);
            this.lmotorhacmi.TabIndex = 12;
            this.lmotorhacmi.Text = "Motor Hacmi(cm3)";
            // 
            // tId
            // 
            this.tId.Location = new System.Drawing.Point(174, 45);
            this.tId.Name = "tId";
            this.tId.Size = new System.Drawing.Size(76, 20);
            this.tId.TabIndex = 13;
            // 
            // tbMarka
            // 
            this.tbMarka.Location = new System.Drawing.Point(174, 71);
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(346, 20);
            this.tbMarka.TabIndex = 14;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(174, 98);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(346, 20);
            this.tbModel.TabIndex = 15;
            // 
            // cbKapı
            // 
            this.cbKapı.FormattingEnabled = true;
            this.cbKapı.Location = new System.Drawing.Point(174, 127);
            this.cbKapı.Name = "cbKapı";
            this.cbKapı.Size = new System.Drawing.Size(76, 21);
            this.cbKapı.TabIndex = 16;
            // 
            // tbBeygir
            // 
            this.tbBeygir.Location = new System.Drawing.Point(174, 157);
            this.tbBeygir.Name = "tbBeygir";
            this.tbBeygir.Size = new System.Drawing.Size(95, 20);
            this.tbBeygir.TabIndex = 17;
            // 
            // rbBinek
            // 
            this.rbBinek.AutoSize = true;
            this.rbBinek.Location = new System.Drawing.Point(174, 183);
            this.rbBinek.Name = "rbBinek";
            this.rbBinek.Size = new System.Drawing.Size(52, 17);
            this.rbBinek.TabIndex = 18;
            this.rbBinek.TabStop = true;
            this.rbBinek.Text = "Binek";
            this.rbBinek.UseVisualStyleBackColor = true;
            // 
            // rbTicari
            // 
            this.rbTicari.AutoSize = true;
            this.rbTicari.Location = new System.Drawing.Point(265, 183);
            this.rbTicari.Name = "rbTicari";
            this.rbTicari.Size = new System.Drawing.Size(51, 17);
            this.rbTicari.TabIndex = 19;
            this.rbTicari.TabStop = true;
            this.rbTicari.Text = "Ticari";
            this.rbTicari.UseVisualStyleBackColor = true;
            // 
            // tbMaxhiz
            // 
            this.tbMaxhiz.Location = new System.Drawing.Point(174, 206);
            this.tbMaxhiz.Name = "tbMaxhiz";
            this.tbMaxhiz.Size = new System.Drawing.Size(76, 20);
            this.tbMaxhiz.TabIndex = 20;
            // 
            // cbCekis
            // 
            this.cbCekis.FormattingEnabled = true;
            this.cbCekis.Location = new System.Drawing.Point(174, 232);
            this.cbCekis.Name = "cbCekis";
            this.cbCekis.Size = new System.Drawing.Size(95, 21);
            this.cbCekis.TabIndex = 21;
            // 
            // tbSifiryüz
            // 
            this.tbSifiryüz.Location = new System.Drawing.Point(174, 259);
            this.tbSifiryüz.Name = "tbSifiryüz";
            this.tbSifiryüz.Size = new System.Drawing.Size(95, 20);
            this.tbSifiryüz.TabIndex = 22;
            // 
            // tbAgirlik
            // 
            this.tbAgirlik.Location = new System.Drawing.Point(174, 285);
            this.tbAgirlik.Name = "tbAgirlik";
            this.tbAgirlik.Size = new System.Drawing.Size(95, 20);
            this.tbAgirlik.TabIndex = 23;
            // 
            // tbMotorHacmi
            // 
            this.tbMotorHacmi.Location = new System.Drawing.Point(174, 311);
            this.tbMotorHacmi.Name = "tbMotorHacmi";
            this.tbMotorHacmi.Size = new System.Drawing.Size(95, 20);
            this.tbMotorHacmi.TabIndex = 24;
            // 
            // rtbSonuc
            // 
            this.rtbSonuc.Location = new System.Drawing.Point(19, 394);
            this.rtbSonuc.Name = "rtbSonuc";
            this.rtbSonuc.Size = new System.Drawing.Size(756, 58);
            this.rtbSonuc.TabIndex = 25;
            this.rtbSonuc.Text = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(19, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(756, 10);
            this.label1.TabIndex = 26;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(19, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(756, 10);
            this.label2.TabIndex = 27;
            this.label2.Text = "label2";
            // 
            // ArabaOzellikleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 482);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbSonuc);
            this.Controls.Add(this.tbMotorHacmi);
            this.Controls.Add(this.tbAgirlik);
            this.Controls.Add(this.tbSifiryüz);
            this.Controls.Add(this.cbCekis);
            this.Controls.Add(this.tbMaxhiz);
            this.Controls.Add(this.rbTicari);
            this.Controls.Add(this.rbBinek);
            this.Controls.Add(this.tbBeygir);
            this.Controls.Add(this.cbKapı);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbMarka);
            this.Controls.Add(this.tId);
            this.Controls.Add(this.lmotorhacmi);
            this.Controls.Add(this.lAgirlik);
            this.Controls.Add(this.lSıfıryüz);
            this.Controls.Add(this.lCekis);
            this.Controls.Add(this.lMaxhiz);
            this.Controls.Add(this.lArabatür);
            this.Controls.Add(this.lBeygirgücü);
            this.Controls.Add(this.lKapısayi);
            this.Controls.Add(this.lMarka);
            this.Controls.Add(this.lModel);
            this.Controls.Add(this.lid);
            this.Controls.Add(this.bGoster);
            this.Controls.Add(this.bKaydet);
            this.Name = "ArabaOzellikleri";
            this.Text = "ArabaOzellikleri";
            this.Load += new System.EventHandler(this.ArabaOzellikleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bKaydet;
        private System.Windows.Forms.Button bGoster;
        private System.Windows.Forms.Label lid;
        private System.Windows.Forms.Label lModel;
        private System.Windows.Forms.Label lMarka;
        private System.Windows.Forms.Label lKapısayi;
        private System.Windows.Forms.Label lBeygirgücü;
        private System.Windows.Forms.Label lArabatür;
        private System.Windows.Forms.Label lMaxhiz;
        private System.Windows.Forms.Label lCekis;
        private System.Windows.Forms.Label lSıfıryüz;
        private System.Windows.Forms.Label lAgirlik;
        private System.Windows.Forms.Label lmotorhacmi;
        private System.Windows.Forms.TextBox tId;
        private System.Windows.Forms.TextBox tbMarka;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.ComboBox cbKapı;
        private System.Windows.Forms.TextBox tbBeygir;
        private System.Windows.Forms.RadioButton rbBinek;
        private System.Windows.Forms.RadioButton rbTicari;
        private System.Windows.Forms.TextBox tbMaxhiz;
        private System.Windows.Forms.ComboBox cbCekis;
        private System.Windows.Forms.TextBox tbSifiryüz;
        private System.Windows.Forms.TextBox tbAgirlik;
        private System.Windows.Forms.TextBox tbMotorHacmi;
        private System.Windows.Forms.RichTextBox rtbSonuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}