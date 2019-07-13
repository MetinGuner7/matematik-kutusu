using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Matematik_Kutusu
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=sorular.accdb");

        int saat, saniye, dakika,dogru=0,yanlis=0,soruSayisi=0;
        String kontrol;
        Random rnd = new Random();
        int id ;

        public void soruCek(int rnd)
        {
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("Select * From sorular where id="+rnd,baglanti);
            OleDbDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                rchSoru.Text= oku["soru"].ToString();
                btnA.Text = oku["cevapA"].ToString();
                btnB.Text = oku["cevapB"].ToString();
                btnC.Text = oku["cevapC"].ToString();
                btnD.Text = oku["cevapD"].ToString();
                btnE.Text = oku["cevapE"].ToString();
                kontrol = oku["cvpDogru"].ToString();
            }
            oku.Close();
                
            baglanti.Close();
        }
        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Start();
            id = rnd.Next(1, 11);
            soruCek(id);
            soruSayisi++;

            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnE.Enabled = true;

            btnA.BackColor = Color.LightSeaGreen;
            btnB.BackColor = Color.LightSeaGreen;
            btnC.BackColor = Color.LightSeaGreen;
            btnD.BackColor = Color.LightSeaGreen;
            btnE.BackColor = Color.LightSeaGreen;


            
            btnBasla.Text = "İLERİ";

            if (dakika >= 20 || soruSayisi == 20)
            {
                timer1.Stop();
                btnBasla.Enabled = false;
                lbPuan.Text = "Puan Tablosu";
                lbDogrular.Text = "Doğrular";
                lbYanlislar.Text = "Yanlışlar";
                lbdogru.Text = dogru.ToString();
                lbyanlis.Text = yanlis.ToString();

                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnE.Enabled = false;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (saniye < 59) saniye++;

            else
            {
                saniye = 0;
                if (dakika < 59) dakika++;
                
                else{
                    dakika = 0;
                    if (saat < 24) saat++;
                    else saat = 0;
                }
            }
            lbZaman.Text = saat.ToString() + " : " + dakika.ToString() + " : " + saniye.ToString();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            
            timer1.Interval = 1000;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;

            btnA.BackColor = Color.AliceBlue;
            btnB.BackColor = Color.LightSeaGreen;
            btnC.BackColor = Color.LightSeaGreen;
            btnD.BackColor = Color.LightSeaGreen;
            btnE.BackColor = Color.LightSeaGreen;

            if (kontrol==btnA.Text)
            {
                dogru++;
            }
            else
            {
                yanlis++;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.BackColor = Color.LightSeaGreen;
            btnB.BackColor = Color.AliceBlue;
            btnC.BackColor = Color.LightSeaGreen;
            btnD.BackColor = Color.LightSeaGreen;
            btnE.BackColor = Color.LightSeaGreen;

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;

            if (kontrol == btnB.Text)
            {
                dogru++;
            }
            else
            {
                yanlis++;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;

            btnA.BackColor = Color.LightSeaGreen;
            btnB.BackColor = Color.LightSeaGreen;
            btnC.BackColor = Color.AliceBlue;
            btnD.BackColor = Color.LightSeaGreen;
            btnE.BackColor = Color.LightSeaGreen;

            if (kontrol == btnC.Text)
            {
                dogru++;
            }
            else
            {
                yanlis++;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;

            btnA.BackColor = Color.LightSeaGreen;
            btnB.BackColor = Color.LightSeaGreen;
            btnC.BackColor = Color.LightSeaGreen;
            btnD.BackColor = Color.AliceBlue;
            btnE.BackColor = Color.LightSeaGreen;

            if (kontrol == btnD.Text)
            {
                dogru++;
            }
            else
            {
                yanlis++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rchSoru.Text == "")
            {
                id = rnd.Next(1, 11);
                soruCek(id);
            }
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;

            btnA.BackColor = Color.LightSeaGreen;
            btnB.BackColor = Color.LightSeaGreen;
            btnC.BackColor = Color.LightSeaGreen;
            btnD.BackColor = Color.LightSeaGreen;
            btnE.BackColor = Color.AliceBlue;

            if (kontrol == btnE.Text)
            {
                dogru++;
            }
            else
            {
                yanlis++;
            }
        }

    }
}
