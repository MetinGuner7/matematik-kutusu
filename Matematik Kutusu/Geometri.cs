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
using System.IO;

namespace Matematik_Kutusu
{
    public partial class Geometri : Form
    {
        public Geometri()
        {
            InitializeComponent();
        }
        

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=sorular.accdb");
        private void Geometri_Load(object sender, EventArgs e)
        {

        }

        private void btnUcken_Click(object sender, EventArgs e)
        {
            
            pboxGeo.Image = Image.FromFile(Application.StartupPath + "\\ucgen.gif");
            lbFormul.Text = "Üçgen";
            lb1.Text = "a";
            lb2.Text = "b";
            lb3.Text = "c";
            lb4.Text = "h";
            lb5.Text = "";
            txt1.Enabled = true;
            txt2.Enabled = true;
            txt3.Enabled = true;
            txt4.Enabled = true;
            txt5.Enabled = false;
            lbToplamAlan.Text = "";
            lbCevre.Text = "Çevre";
            lbAlan.Text = "Alan";
            lb1Ust.Text = "2";
            lb2Ust.Text = "";
            lb3Ust.Text = "";
        }

        private void btnDikdortgen_Click(object sender, EventArgs e)
        {
            pboxGeo.Image = Image.FromFile(Application.StartupPath + "\\dikdortgen.gif");
            lbFormul.Text = "Dikdörtgen";
            lb1.Text = "a";
            lb2.Text = "b";
            lb3.Text = "";
            lb4.Text = "";
            lb5.Text = "";
            txt1.Enabled = true;
            txt2.Enabled = true;
            txt5.Enabled = false;
            txt3.Enabled = false;
            txt4.Enabled = false;
            lbToplamAlan.Text = "";
            lbCevre.Text = "Çevre";
            lbAlan.Text = "Alan";
            lb1Ust.Text = "2";
            lb2Ust.Text = "";
            lb3Ust.Text = "";
        }

        private void btnPaKenar_Click(object sender, EventArgs e)
        {
            pboxGeo.Image = Image.FromFile(Application.StartupPath + "\\paralel_kenar.gif");
            lbFormul.Text = "Paralel Kenar";
            lb1.Text = "a";
            lb2.Text = "b";
            lb3.Text = "h";
            lb4.Text = "";
            lb5.Text = "";
            txt1.Enabled = true;
            txt2.Enabled = true;
            txt3.Enabled = true;
            txt5.Enabled = false;
            txt4.Enabled = false;
            lbToplamAlan.Text = "";     
            lbCevre.Text = "Çevre";
            lbAlan.Text = "Alan";
            lb1Ust.Text = "2";
            lb2Ust.Text = "";
            lb3Ust.Text = "";
        }

        private void btnTrapez_Click(object sender, EventArgs e)
        {
            pboxGeo.Image = Image.FromFile(Application.StartupPath + "\\trapez.gif");
            lbFormul.Text = "Yamuk";
            lb1.Text = "a";
            lb2.Text = "b";
            lb3.Text = "c";
            lb4.Text = "d";
            lb5.Text = "h";
            txt1.Enabled = true;
            txt2.Enabled = true;
            txt3.Enabled = true;
            txt5.Enabled = true;
            txt4.Enabled = true;
            lbToplamAlan.Text = "";
            lbCevre.Text = "Çevre";
            lbAlan.Text = "Alan";
            lb1Ust.Text = "2";
            lb2Ust.Text = "";
            lb3Ust.Text = "";
        }

        private void btnDuAltigen_Click(object sender, EventArgs e)
        {
            pboxGeo.Image = Image.FromFile(Application.StartupPath + "\\duzgun_altigen.gif");
            lbFormul.Text = "Düzgün Altıgen";
            lb1.Text = "R";
            lb2.Text = "S";
            lb3.Text = "E";
            lb4.Text = "";
            lb5.Text = "";
            txt1.Enabled = true;
            txt2.Enabled = true;
            txt3.Enabled = true;
            txt5.Enabled = false;
            txt4.Enabled = false;
            lbToplamAlan.Text = "";
            lbCevre.Text = "Çevre";
            lbAlan.Text = "Alan";
            lb1Ust.Text = "2";
            lb2Ust.Text = "";
            lb3Ust.Text = "";

        }

        private void btnDaire_Click(object sender, EventArgs e)
        {
            pboxGeo.Image = Image.FromFile(Application.StartupPath + "\\daire.gif");
            lbFormul.Text = "Daire";
            lb1.Text = "D";
            lb2.Text = "";
            lb3.Text = "";
            lb4.Text = "";
            lb5.Text = "";
            txt1.Enabled = true;
            txt2.Enabled = false;
            txt3.Enabled = false;
            txt5.Enabled = false;
            txt4.Enabled = false;
            lbToplamAlan.Text = "";
            lbCevre.Text = "Çevre";
            lbAlan.Text = "Alan";
            lb1Ust.Text = "2";
            lb2Ust.Text = "";
            lb3Ust.Text = "";
        }

        private void btnDaireDilimi_Click(object sender, EventArgs e)
        {
            pboxGeo.Image = Image.FromFile(Application.StartupPath + "\\daire_dilimi.gif");
            lbFormul.Text = "Daire Dilimi";
            lb1.Text = "r";
            lb2.Text = "y";
            lb3.Text = "";
            lb4.Text = "";
            lb5.Text = "";
            txt1.Enabled = true;
            txt2.Enabled = true;
            txt3.Enabled = false;
            txt5.Enabled = false;
            txt4.Enabled = false;
            lbToplamAlan.Text = "";
            lbCevre.Text = "Yay Boyu";
            lbAlan.Text = "Alan";
            lb1Ust.Text = "2";
            lb2Ust.Text = "";
            lb3Ust.Text = "";
        }

        private void btnDaireHalkasi_Click(object sender, EventArgs e)
        {
            pboxGeo.Image = Image.FromFile(Application.StartupPath + "\\daire_halkasi.gif");
            lbFormul.Text = "Daire Halkası";
            lb1.Text = "D";
            lb2.Text = "d";
            lb3.Text = "";
            lb4.Text = "";
            lb5.Text = "";
            txt1.Enabled = true;
            txt2.Enabled = true;
            txt3.Enabled = false;
            txt5.Enabled = false;
            txt4.Enabled = false;
            lbToplamAlan.Text = "";
            lbCevre.Text = "";
            lbAlan.Text = "Alan";
            lb1Ust.Text = "2";
            lb2Ust.Text = "";
            lb3Ust.Text = "";
        }

        private void btnElips_Click(object sender, EventArgs e)
        {
            pboxGeo.Image = Image.FromFile(Application.StartupPath + "\\elips.gif");
            lbFormul.Text = "Elips";
            lb1.Text = "D";
            lb2.Text = "d";
            lb3.Text = "";
            lb4.Text = "";
            lb5.Text = "";
            txt1.Enabled = true;
            txt2.Enabled = true;
            txt3.Enabled = false;
            txt5.Enabled = false;
            txt4.Enabled = false;
            lbToplamAlan.Text = "";             
            txtCevre.Enabled = true;
            lbCevre.Text = "Çevre";
            lbAlan.Text = "Alan";
            lb1Ust.Text = "2";
            lb2Ust.Text = "";
            lb3Ust.Text = "";
        }

        private void btnKoni_Click(object sender, EventArgs e)
        {
            pboxGeo.Image = Image.FromFile(Application.StartupPath + "\\koni.gif");
            lbFormul.Text = "Koni";
            lb1.Text = "R";
            lb2.Text = "H";
            lb3.Text = "";
            lb4.Text = "";
            lb5.Text = "";
            txt1.Enabled = true;
            txt2.Enabled = true;
            txt3.Enabled = false;
            txt5.Enabled = false;
            txt4.Enabled = false;
            lbToplamAlan.Text = "Toplam Alan";
            lbCevre.Text = "Yanal Alan";
            lbAlan.Text = "Hacim";
            lb1Ust.Text = "3";
            lb2Ust.Text = "2";
            lb3Ust.Text = "2";
        }

        private void KarePiramit_Click(object sender, EventArgs e)
        {
            pboxGeo.Image = Image.FromFile(Application.StartupPath + "\\kare_piramit.gif");
            lbFormul.Text = "Kare Piramit";
            lb1.Text = "A";
            lb2.Text = "H";
            lb3.Text = "";
            lb4.Text = "";
            lb5.Text = "";
            txt1.Enabled = true;
            txt2.Enabled = true;
            txt3.Enabled = false;
            txt5.Enabled = false;
            txt4.Enabled = false;
            lbToplamAlan.Text = "Toplam Alan";
            lbCevre.Text = "Yanal Alan";
            lbAlan.Text = "Hacim";
            lb1Ust.Text = "3";
            lb2Ust.Text = "2";
            lb3Ust.Text = "2";

        }

        private void btnKup_Click(object sender, EventArgs e)
        {
            pboxGeo.Image = Image.FromFile(Application.StartupPath + "\\kup.gif");
            lbFormul.Text = "Küp";
            lb1.Text = "A";
            lb2.Text = "";
            lb3.Text = "";
            lb4.Text = "";
            lb5.Text = "";
            txt1.Enabled = true;
            txt2.Enabled = false;
            txt3.Enabled = false;
            txt5.Enabled = false;
            txt4.Enabled = false;
            lbToplamAlan.Text = "";  
            lbCevre.Text = "Yüzey Alan";
            lbAlan.Text = "Hacim";
            lb1Ust.Text = "3";
            lb2Ust.Text = "2";
            lb3Ust.Text = "";
        }

        private void btnKure_Click(object sender, EventArgs e)
        {
            pboxGeo.Image = Image.FromFile(Application.StartupPath + "\\kure.gif");
            lbFormul.Text = "Küre";
            lb1.Text = "R";
            lb2.Text = "";
            lb3.Text = "";
            lb4.Text = "";
            lb5.Text = "";
            txt1.Enabled = true;
            txt2.Enabled = false;
            txt3.Enabled = false;
            txt5.Enabled = false;
            txt4.Enabled = false;
            lbToplamAlan.Text = "";
            lbCevre.Text = "Yüzey Alan";
            lbAlan.Text = "Hacim";
            lb1Ust.Text = "3";
            lb2Ust.Text = "2";
            lb3Ust.Text = "";
        }

        private void btnSilindir_Click(object sender, EventArgs e)
        {
            pboxGeo.Image = Image.FromFile(Application.StartupPath + "\\silindir.gif");
            lbFormul.Text = "Silindir";
            lb1.Text = "D";
            lb2.Text = "H";
            lb3.Text = "";
            lb4.Text = "";
            lb5.Text = "";
            txt1.Enabled = true;
            txt2.Enabled = true;
            txt3.Enabled = false;
            txt5.Enabled = false;
            txt4.Enabled = false;
            lbToplamAlan.Text = "Toplam Alan";
            lbCevre.Text = "Yüzey Alan";
            lbAlan.Text = "Hacim";
            lb1Ust.Text = "3";
            lb2Ust.Text = "2";
            lb3Ust.Text = "2";
        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            double a, b, c, h, d, pi=3.14;
            bool kontrol;

            if (lbFormul.Text == "Üçgen")
            {
                kontrol = Double.TryParse(txt1.Text, out a);
                kontrol = Double.TryParse(txt2.Text, out b);
                kontrol = Double.TryParse(txt3.Text, out c);
                kontrol = Double.TryParse(txt4.Text, out h);

                txtCevre.Text = Convert.ToString(a + b + c);
                txtAlan.Text = Convert.ToString(c * h / 2);
            }
            if (lbFormul.Text == "Paralel Kenar")
            {
                kontrol = Double.TryParse(txt1.Text, out a);
                kontrol = Double.TryParse(txt2.Text, out b);
                kontrol = Double.TryParse(txt3.Text, out h);

                txtCevre.Text = Convert.ToString((a + b) *2 );
                txtAlan.Text = Convert.ToString(a * h);
            }
            if (lbFormul.Text == "Dikdörtgen")
            {
                kontrol = Double.TryParse(txt1.Text, out a);
                kontrol = Double.TryParse(txt2.Text, out b);

                txtCevre.Text = Convert.ToString((a + b)*2);
                txtAlan.Text = Convert.ToString(a * b);
            }
            if (lbFormul.Text == "Yamuk")
            {
                kontrol = Double.TryParse(txt1.Text, out a);
                kontrol = Double.TryParse(txt2.Text, out b);
                kontrol = Double.TryParse(txt3.Text, out c);
                kontrol = Double.TryParse(txt4.Text, out d);
                kontrol = Double.TryParse(txt5.Text, out h);

                txtCevre.Text = Convert.ToString(a + b + c + d);
                txtAlan.Text = Convert.ToString((a +b ) * h / 2);
            }
            if (lbFormul.Text == "Düzgün Altıgen") //yapılmadı Unutma ???
            {
                kontrol = Double.TryParse(txt1.Text, out a);
                kontrol = Double.TryParse(txt2.Text, out b);
                kontrol = Double.TryParse(txt3.Text, out c);
                if (b > 0)
                {
                     txtCevre.Text = Convert.ToString(Math.Round((b / Math.Sqrt(3)), 2));
                     txtAlan.Text = Convert.ToString(Math.Round((0.866 * Math.Pow(b, 2)), 2));
                    }
                else if (a > 0)
                {
                    double kok = 3, us = 3, bolunen = 1, bolen = 2;
                    txtCevre.Text = Convert.ToString(Math.Round((b / Math.Sqrt(3)), 2));
                    txtAlan.Text = Convert.ToString(Math.Round(((Math.Pow(kok, (bolunen / us)) / bolen) * (a * a)), 2));
                }
                else if (c > 0)
                {
                    
                    txtCevre.Text = Convert.ToString(Math.Round((b / Math.Sqrt(3)), 2));
                    txtAlan.Text = Convert.ToString(Math.Round((0.866 * Math.Pow(b, 2)), 2));
                }
                
            }
            if (lbFormul.Text == "Daire")
            {
                kontrol = Double.TryParse(txt1.Text, out a);

                txtCevre.Text = Convert.ToString(pi * a);
                txtAlan.Text = Convert.ToString(pi * (a*a) / 4 );
            }
            if (lbFormul.Text == "Daire Dilimi")
            {
                kontrol = Double.TryParse(txt1.Text, out a);
                kontrol = Double.TryParse(txt2.Text, out b);

                txtCevre.Text = Convert.ToString(Math.Round((pi * a * b / 180),2));
                txtAlan.Text = Convert.ToString(Math.Round((pi * (a * a) * b / 360),2));
            }
            if (lbFormul.Text == "Daire Halkası")
            {
                kontrol = Double.TryParse(txt1.Text, out a);
                kontrol = Double.TryParse(txt2.Text, out b);

                txtAlan.Text = Convert.ToString(Math.Round(((a*a)-(b*b)) * pi / 4, 2));
            }
            if (lbFormul.Text == "Elips")
            {
                kontrol = Double.TryParse(txt1.Text, out a);
                kontrol = Double.TryParse(txt2.Text, out b);

                txtCevre.Text = Convert.ToString(Math.Round((a + b) * pi / 2, 2));
                txtAlan.Text = Convert.ToString(Math.Round(a* b* pi / 4, 2));
            }
            if (lbFormul.Text == "Koni")
            {
                kontrol = Double.TryParse(txt1.Text, out a);
                kontrol = Double.TryParse(txt2.Text, out b);

                txtCevre.Text = Convert.ToString(Math.Round(pi * a * Math.Sqrt(((a*a)+(b*b))), 2)); //Yanal ALan
                txtAlan.Text = Convert.ToString(Math.Round(pi * (a*a) * b / 3, 2));//Hacim
                txtToplamAlan.Text = Convert.ToString(Math.Round(pi * a *( Math.Sqrt(((a * a) + (b * b))) +a), 2)); //Toplam ALan
            }
            if (lbFormul.Text == "Kare Piramit")
            {
                kontrol = Double.TryParse(txt1.Text, out a);
                kontrol = Double.TryParse(txt2.Text, out b);

                txtCevre.Text = Convert.ToString(Math.Round(a * Math.Sqrt(4 * (b * b) + (a*a)), 2)); //Yanal ALan
                txtAlan.Text = Convert.ToString(Math.Round( (a * a) * b / 3, 2));//Hacim
                txtToplamAlan.Text = Convert.ToString(Math.Round(a * (Math.Sqrt(4 * (b * b) + (a*a))+ a), 2)); //Toplam ALan
            }
            if (lbFormul.Text == "Küp")
            {
                kontrol = Double.TryParse(txt1.Text, out a);

                txtCevre.Text = Convert.ToString(6 * (a*a));
                txtAlan.Text = Convert.ToString(a * a * a);
            }
            if (lbFormul.Text == "Küre")
            {
                kontrol = Double.TryParse(txt1.Text, out a);

                txtCevre.Text = Convert.ToString(4 * pi * (a*a));
                txtAlan.Text = Convert.ToString((double)4/3 * (pi * Math.Pow(a,3)));
            }
            if (lbFormul.Text == "Silindir")
            {
                kontrol = Double.TryParse(txt1.Text, out a);
                kontrol = Double.TryParse(txt2.Text, out b);

                txtCevre.Text = Convert.ToString(pi * a * b);
                txtAlan.Text = Convert.ToString(pi * b * Math.Pow(a, 2) / 4);
                txtToplamAlan.Text = Convert.ToString(pi * a * (b + a / 2));
            }
        }

    }
}
