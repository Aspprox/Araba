using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Araba;
using Araba.Classes;

namespace Araba
{
    public partial class ArabaOzellikleri : Form
    {
        Araba araba;
        string[] kapisayisi = new string[3]
        {
            "2",
            "4",
            "5"
        };

        string[] cekis = new string[3]
        {
            "Ön",
            "Arka",
            "Dört"
        };
        public ArabaOzellikleri()
        {
            InitializeComponent();
        }

       

        private void bKaydet_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tId.Text) || (String.IsNullOrWhiteSpace(tbMarka.Text) || (String.IsNullOrWhiteSpace(tbModel.Text)
                || (cbKapı.SelectedIndex == 0) || (cbCekis.SelectedIndex == 0))))
            {
                MessageBox.Show("Lütfen * ile belirtilmiş zorunlu alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                araba.Id = Convert.ToInt32(tId.Text); 
                araba.Marka = (tbMarka.Text);
                araba.Model = (tbModel.Text);
                araba.KapıSayısı = (cbKapı.SelectedIndex);
                araba.BeygirGücü = (tbBeygir.Text);
                araba.MaxHız = Convert.ToInt32(tbMaxhiz.Text);
                araba.Çekiş = (cbCekis.Text);
                araba.SıfırYüz = Convert.ToInt32(tbSifiryüz.Text);
                araba.Agırlık = Convert.ToInt32(tbAgirlik.Text);
                araba.MotorHacmi = Convert.ToInt32(tbMotorHacmi.Text);
                if (rbBinek.Checked)
                {
                    araba.ArabaTürü = ArabaTürüEnum.Binek;
                }
                if (rbTicari.Checked)
                {
                    araba.ArabaTürü = ArabaTürüEnum.Ticari;
                }
                else
                {
                    MessageBox.Show("Lütfen bir araba türü belirtiniz.");
                }
                MessageBox.Show("Araba objesi oluşturuldu.", "Bilgilendirme", MessageBoxButtons.OK);

            }
        }

        private void bGoster_Click(object sender, EventArgs e)
        {
            if (araba != null)
            {
                string line = "Id: " + araba.Id + ", ";
                line += "Marka: " + araba.Marka + ", ";
                line += "Model: " + araba.Model + ", ";
                line += "Kapı Sayısı: " + araba.KapıSayısı + ", ";
                line += "Beygir Gücü: " + araba.BeygirGücü + ", ";
                line += "Max Hız: " + araba.MaxHız + ", ";
                line += "Çekiş: " + araba.Çekiş + ", ";
                line += "0-100" + araba.SıfırYüz + ", ";
                line += "Ağırlık: " + araba.Agırlık + ", ";
                line += "Motor Hacmi: " + araba.MotorHacmi + ", ";
                line += "Araba Türü: " + araba.ArabaTürü + ", ";
                rtbSonuc.Text = line;
            } 
        }

        private void ArabaOzellikleri_Load(object sender, EventArgs e)
        {
            cbKapı.Items.AddRange(kapisayisi);
            cbCekis.Items.AddRange(cekis);
            cbKapı.Items.Insert(0, "--Seçiniz--");
            cbCekis.Items.Insert(0, "--Seçiniz--");
            cbCekis.SelectedIndex = 0;
            cbKapı.SelectedIndex = 0;
        }

    
    }
}
