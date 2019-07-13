using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematik_Kutusu
{
    public partial class EbobEkok : Form
    {
        int ebob=1, ekok=1;
        public EbobEkok()
        {
            InitializeComponent();
        }

        private void cbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bolen,sayi1,sayi2;

            bool kontrol = Int32.TryParse(cbox1.SelectedItem.ToString(), out bolen);
            kontrol = Int32.TryParse(txtSayi1.Text, out sayi1);
            kontrol = Int32.TryParse(txtSayi2.Text, out sayi2);

            //sayılar 1 olunca işleme girmesin
            if (sayi1 > 1 || sayi2 > 1)
              {
             //iki sayıdan biri yada ikisi comboboxtan seçilen sayıya bölünüyosa if e girsin
                   if (sayi1 % bolen == 0 || sayi2 % bolen == 0)
                   {
            //birinci sayı combobextan gelen sayıya tam bolunuyorsa altaki labele yazılsın
                        if (sayi1 % bolen == 0)
                        {
                            lb1Sayi1.Text = Convert.ToString(sayi1 / bolen);
                        }
                        else
                        {
                            lb1Sayi1.Text = Convert.ToString(sayi1);
                        }
            //ikinci sayı combobextan gelen sayıya tam bolunuyorsa altaki labele yazılsın
                        if (sayi2 % bolen == 0)
                        {
                            lb1Sayi2.Text = Convert.ToString(sayi2 / bolen);
                        }
                        else
                        {
                            lb1Sayi2.Text = Convert.ToString(sayi2);
                        }
                       cbox1.Enabled = false;
                   }
            //iki sayıda seçilen sayıya tam bölünmüyorsa kullanıcı başka sayı seçmesi için uyarılsın
                   else
                   {
                        MessageBox.Show(sayi1 + " sayisi ve " + sayi2 + " sayisi " + bolen + " sayisina tam bölünmediği için başka bir asal çarpan deneyiniz !");
                   }
            //İki sayıda ortak bölünüyorsa ebob değişkeni içine atılsın
                   if (sayi1 % bolen == 0 && sayi2 % bolen == 0)
                   {
                       ebob *= bolen;
                       pbox1.Visible = true;
                   }
              }
            else
            {
                lbSonuc.Text = Convert.ToString(ebob);
            }
        }

        private void cbox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bolen, sayi1, sayi2;

            bool kontrol = Int32.TryParse(cbox2.SelectedItem.ToString(), out bolen);
            kontrol = Int32.TryParse(lb1Sayi1.Text, out sayi1);
            kontrol = Int32.TryParse(lb1Sayi2.Text, out sayi2);

            if (sayi1 > 1 || sayi2 > 1)
            {
                if (sayi1 % bolen == 0 || sayi2 % bolen == 0)
                   {

                        if (sayi1 % bolen == 0)
                        {
                            lb2Sayi1.Text = Convert.ToString(sayi1 / bolen);
                        }
                        else
                        {
                            lb2Sayi1.Text = Convert.ToString(sayi1);
                        }
                        if (sayi2 % bolen == 0)
                        {
                            lb2Sayi2.Text = Convert.ToString(sayi2 / bolen);
                        }
                        else
                        {
                            lb2Sayi2.Text = Convert.ToString(sayi2);
                        }
                        cbox2.Enabled = false;
                   }
                //iki sayıda seçilen sayıya tam bölünmüyorsa kullanıcı başka sayı seçmesi için uyarılsın
                else
                {
                    MessageBox.Show(sayi1 + " sayisi ve " + sayi2 + " sayisi " + bolen + " sayisina tam bölünmediği için başka bir asal çarpan deneyiniz !");
                }
                //İki sayıda ortak bölünüyorsa ebob değişkeni içine atılsın
                if (sayi1 % bolen == 0 && sayi2 % bolen == 0)
                {
                    ebob *= bolen;
                    pbox2.Visible = true;
                }
            }
            else
            {
                lbSonuc.Text = Convert.ToString(ebob);
            }
        }

        private void cbox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bolen, sayi1, sayi2;

            bool kontrol = Int32.TryParse(cbox3.SelectedItem.ToString(), out bolen);
            kontrol = Int32.TryParse(lb2Sayi1.Text, out sayi1);
            kontrol = Int32.TryParse(lb2Sayi2.Text, out sayi2);

            if (sayi1 > 1 || sayi2 > 1)
            {
                if (sayi1 % bolen == 0 || sayi2 % bolen == 0)
                {
                    if (sayi1 % bolen == 0)
                    {
                        lb3Sayi1.Text = Convert.ToString(sayi1 / bolen);
                    }
                    else
                    {
                        lb3Sayi1.Text = Convert.ToString(sayi1);
                    }
                    if (sayi2 % bolen == 0)
                    {
                        lb3Sayi2.Text = Convert.ToString(sayi2 / bolen);
                    }
                    else
                    {
                        lb3Sayi2.Text = Convert.ToString(sayi2);
                    }
             cbox3.Enabled = false;
                   }
            //iki sayıda seçilen sayıya tam bölünmüyorsa kullanıcı başka sayı seçmesi için uyarılsın
                   else
                   {
                        MessageBox.Show(sayi1 + " sayisi ve " + sayi2 + " sayisi " + bolen + " sayisina tam bölünmediği için başka bir asal çarpan deneyiniz !");
                   }
            //İki sayıda ortak bölünüyorsa ebob değişkeni içine atılsın
                   if (sayi1 % bolen == 0 && sayi2 % bolen == 0)
                   {
                       ebob *= bolen;
                       pbox3.Visible = true;
                   }
              }
            else
            {
                lbSonuc.Text = Convert.ToString(ebob);
            }
        }

        private void cbox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bolen, sayi1, sayi2;

            bool kontrol = Int32.TryParse(cbox4.SelectedItem.ToString(), out bolen);
            kontrol = Int32.TryParse(lb3Sayi1.Text, out sayi1);
            kontrol = Int32.TryParse(lb3Sayi2.Text, out sayi2);

            if (sayi1 > 1 || sayi2 > 1)
            {
                 if (sayi1 % bolen == 0 || sayi2 % bolen == 0)
                {
                    if (sayi1 % bolen == 0)
                    {
                        lb4Sayi1.Text = Convert.ToString(sayi1 / bolen);
                    }
                    else
                    {
                        lb4Sayi1.Text = Convert.ToString(sayi1);
                    }
                    if (sayi2 % bolen == 0)
                    {
                        lb4Sayi2.Text = Convert.ToString(sayi2 / bolen);
                    }
                    else
                    {
                        lb4Sayi2.Text = Convert.ToString(sayi2);
                    }
                cbox4.Enabled = false;
                   }
                //iki sayıda seçilen sayıya tam bölünmüyorsa kullanıcı başka sayı seçmesi için uyarılsın
                else
                {
                    MessageBox.Show(sayi1 + " sayisi ve " + sayi2 + " sayisi " + bolen + " sayisina tam bölünmediği için başka bir asal çarpan deneyiniz !");
                }
                //İki sayıda ortak bölünüyorsa ebob değişkeni içine atılsın
                if (sayi1 % bolen == 0 && sayi2 % bolen == 0)
                {
                    ebob *= bolen;
                    pbox4.Visible = true;
                }
             }
            else
            {
                lbSonuc.Text = Convert.ToString(ebob);
            }
        }
        private void cbox5_SelectedIndexChanged(object sender, EventArgs e)
        {
             int bolen, sayi1, sayi2;

            bool kontrol = Int32.TryParse(cbox5.SelectedItem.ToString(), out bolen);
            kontrol = Int32.TryParse(lb4Sayi1.Text, out sayi1);
            kontrol = Int32.TryParse(lb4Sayi2.Text, out sayi2);

            if (sayi1 > 1 || sayi2 > 1)
            {
                if (sayi1 % bolen == 0 || sayi2 % bolen == 0)
                {
                        if (sayi1 % bolen == 0)
                        {
                            lb5Sayi1.Text = Convert.ToString(sayi1 / bolen);
                        }
                        else
                        {
                            lb5Sayi1.Text = Convert.ToString(sayi1);
                        }
                        if (sayi2 % bolen == 0)
                        {
                            lb5Sayi2.Text = Convert.ToString(sayi2 / bolen);
                        }
                        else
                        {
                            lb5Sayi2.Text = Convert.ToString(sayi2);
                        }
                 cbox5.Enabled = false;
                 }
                //iki sayıda seçilen sayıya tam bölünmüyorsa kullanıcı başka sayı seçmesi için uyarılsın
                else
                {
                    MessageBox.Show(sayi1 + " sayisi ve " + sayi2 + " sayisi " + bolen + " sayisina tam bölünmediği için başka bir asal çarpan deneyiniz !");
                }
                //İki sayıda ortak bölünüyorsa ebob değişkeni içine atılsın
                if (sayi1 % bolen == 0 && sayi2 % bolen == 0)
                {
                    ebob *= bolen;
                    pbox5.Visible = true;
                }
            }
            else
            {
                lbSonuc.Text = Convert.ToString(ebob);
            }
        }
        private void cbox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bolen, sayi1, sayi2;

            bool kontrol = Int32.TryParse(cbox6.SelectedItem.ToString(), out bolen);
            kontrol = Int32.TryParse(lb5Sayi1.Text, out sayi1);
            kontrol = Int32.TryParse(lb5Sayi2.Text, out sayi2);

            if (sayi1 > 1 || sayi2 > 1)
            { 
                if (sayi1 % bolen == 0 || sayi2 % bolen == 0)
                {
                        if (sayi1 % bolen == 0)
                        {
                            lb6Sayi1.Text = Convert.ToString(sayi1 / bolen);
                        }
                        else
                        {
                            lb6Sayi1.Text = Convert.ToString(sayi1);
                        }
                        if (sayi2 % bolen == 0)
                        {
                            lb6Sayi2.Text = Convert.ToString(sayi2 / bolen);
                        }
                        else
                        {
                            lb6Sayi2.Text = Convert.ToString(sayi2);
                        }
                  cbox6.Enabled = false;
                }
                //iki sayıda seçilen sayıya tam bölünmüyorsa kullanıcı başka sayı seçmesi için uyarılsın
                else
                {
                    MessageBox.Show(sayi1 + " sayisi ve " + sayi2 + " sayisi " + bolen + " sayisina tam bölünmediği için başka bir asal çarpan deneyiniz !");
                }
                //İki sayıda ortak bölünüyorsa ebob değişkeni içine atılsın
                if (sayi1 % bolen == 0 && sayi2 % bolen == 0)
                {
                    ebob *= bolen;
                    pbox6.Visible = true;
                }
            }
            else
            {
                lbSonuc.Text = Convert.ToString(ebob);
            }
        }

        private void cbox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bolen, sayi1, sayi2;

            bool kontrol = Int32.TryParse(cbox7.SelectedItem.ToString(), out bolen);
            kontrol = Int32.TryParse(lb6Sayi1.Text, out sayi1);
            kontrol = Int32.TryParse(lb6Sayi2.Text, out sayi2);

            if (sayi1 > 1 || sayi2 > 1)
            {
                if (sayi1 % bolen == 0 || sayi2 % bolen == 0)
                {
                    if (sayi1 % bolen == 0)
                    {
                        lb7Sayi1.Text = Convert.ToString(sayi1 / bolen);
                    }
                    else
                    {
                        lb7Sayi1.Text = Convert.ToString(sayi1);
                    }
                    if (sayi2 % bolen == 0)
                    {
                        lb7Sayi2.Text = Convert.ToString(sayi2 / bolen);
                    }
                    else
                    {
                        lb7Sayi2.Text = Convert.ToString(sayi2);
                    }
                    cbox7.Enabled = false;
                }
                //iki sayıda seçilen sayıya tam bölünmüyorsa kullanıcı başka sayı seçmesi için uyarılsın
                else
                {
                    MessageBox.Show(sayi1 + " sayisi ve " + sayi2 + " sayisi " + bolen + " sayisina tam bölünmediği için başka bir asal çarpan deneyiniz !");
                }
                //İki sayıda ortak bölünüyorsa ebob değişkeni içine atılsın
                if (sayi1 % bolen == 0 && sayi2 % bolen == 0)
                {
                    ebob *= bolen;
                    pbox7.Visible = true;
                }
            }
            else
            {
                lbSonuc.Text = Convert.ToString(ebob);
            }
        }

        private void cbox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bolen, sayi1, sayi2;

            bool kontrol = Int32.TryParse(cbox8.SelectedItem.ToString(), out bolen);
            kontrol = Int32.TryParse(lb7Sayi1.Text, out sayi1);
            kontrol = Int32.TryParse(lb7Sayi2.Text, out sayi2);

            if (sayi1 > 1 || sayi2 > 1)
            {
                if (sayi1 % bolen == 0 || sayi2 % bolen == 0)
                {
                    if (sayi1 % bolen == 0)
                    {
                        lb8Sayi1.Text = Convert.ToString(sayi1 / bolen);
                    }
                    else
                    {
                        lb8Sayi1.Text = Convert.ToString(sayi1);
                    }
                    if (sayi2 % bolen == 0)
                    {
                        lb8Sayi2.Text = Convert.ToString(sayi2 / bolen);
                    }
                    else
                    {
                        lb8Sayi2.Text = Convert.ToString(sayi2);
                    }
                    cbox8.Enabled = false;
                }
                //iki sayıda seçilen sayıya tam bölünmüyorsa kullanıcı başka sayı seçmesi için uyarılsın
                else
                {
                    MessageBox.Show(sayi1 + " sayisi ve " + sayi2 + " sayisi " + bolen + " sayisina tam bölünmediği için başka bir asal çarpan deneyiniz !");
                }
                //İki sayıda ortak bölünüyorsa ebob değişkeni içine atılsın
                if (sayi1 % bolen == 0 && sayi2 % bolen == 0)
                {
                    ebob *= bolen;
                    pbox8.Visible = true;
                }
            }
            else
            {
                lbSonuc.Text = Convert.ToString(ebob);
            }
        }

        private void cbox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bolen, sayi1, sayi2;

            bool kontrol = Int32.TryParse(cbox9.SelectedItem.ToString(), out bolen);
            kontrol = Int32.TryParse(lb8Sayi1.Text, out sayi1);
            kontrol = Int32.TryParse(lb8Sayi2.Text, out sayi2);

            if (sayi1 > 1 || sayi2 > 1)
            {
                if (sayi1 % bolen == 0 || sayi2 % bolen == 0)
                {
                    if (sayi1 % bolen == 0)
                    {
                        lb9Sayi1.Text = Convert.ToString(sayi1 / bolen);
                    }
                    else
                    {
                        lb9Sayi1.Text = Convert.ToString(sayi1);
                    }
                    if (sayi2 % bolen == 0)
                    {
                        lb9Sayi2.Text = Convert.ToString(sayi2 / bolen);
                    }
                    else
                    {
                        lb9Sayi2.Text = Convert.ToString(sayi2);
                    }
                    cbox9.Enabled = false;
                }
                //iki sayıda seçilen sayıya tam bölünmüyorsa kullanıcı başka sayı seçmesi için uyarılsın
                else
                {
                    MessageBox.Show(sayi1 + " sayisi ve " + sayi2 + " sayisi " + bolen + " sayisina tam bölünmediği için başka bir asal çarpan deneyiniz !");
                }
                //İki sayıda ortak bölünüyorsa ebob değişkeni içine atılsın
                if (sayi1 % bolen == 0 && sayi2 % bolen == 0)
                {
                    ebob *= bolen;
                    pbox9.Visible = true;
                }
            }
            else
            {
                lbSonuc.Text = Convert.ToString(ebob);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bolen, sayi1, sayi2;

            bool kontrol = Int32.TryParse(cbox01.SelectedItem.ToString(), out bolen);
            kontrol = Int32.TryParse(txtSayi01.Text, out sayi1);
            kontrol = Int32.TryParse(txtSayi02.Text, out sayi2);

            //sayılar 1 olunca işleme girmesin
            if (sayi1 > 1 || sayi2 > 1)
            {
                //iki sayıdan biri yada ikisi comboboxtan seçilen sayıya bölünüyosa if e girsin
                if (sayi1 % bolen == 0 || sayi2 % bolen == 0)
                {
                    //birinci sayı combobextan gelen sayıya tam bolunuyorsa altaki labele yazılsın
                    if (sayi1 % bolen == 0)
                    {
                        lb1Sayi01.Text = Convert.ToString(sayi1 / bolen);
                    }
                    else
                    {
                        lb1Sayi01.Text = Convert.ToString(sayi1);
                    }
                    //ikinci sayı combobextan gelen sayıya tam bolunuyorsa altaki labele yazılsın
                    if (sayi2 % bolen == 0)
                    {
                        lb1Sayi02.Text = Convert.ToString(sayi2 / bolen);
                    }
                    else
                    {
                        lb1Sayi02.Text = Convert.ToString(sayi2);
                    }
                    cbox01.Enabled = false;
                    ekok *= bolen;
                    pbox01.Visible = true;
                }
                //iki sayıda seçilen sayıya tam bölünmüyorsa kullanıcı başka sayı seçmesi için uyarılsın
                else
                {
                    MessageBox.Show(sayi1 + " sayisi ve " + sayi2 + " sayisi " + bolen + " sayisina tam bölünmediği için başka bir asal çarpan deneyiniz !");
                }
            }
            else
            {
                lbSonuc0.Text = Convert.ToString(ekok);
            }
        }

        private void cbox02_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bolen, sayi1, sayi2;

            bool kontrol = Int32.TryParse(cbox02.SelectedItem.ToString(), out bolen);
            kontrol = Int32.TryParse(lb1Sayi01.Text, out sayi1);
            kontrol = Int32.TryParse(lb1Sayi02.Text, out sayi2);

            //sayılar 1 olunca işleme girmesin
            if (sayi1 > 1 || sayi2 > 1)
            {
                //iki sayıdan biri yada ikisi comboboxtan seçilen sayıya bölünüyosa if e girsin
                if (sayi1 % bolen == 0 || sayi2 % bolen == 0)
                {
                    //birinci sayı combobextan gelen sayıya tam bolunuyorsa altaki labele yazılsın
                    if (sayi1 % bolen == 0)
                    {
                        lb2Sayi01.Text = Convert.ToString(sayi1 / bolen);
                    }
                    else
                    {
                        lb2Sayi01.Text = Convert.ToString(sayi1);
                    }
                    //ikinci sayı combobextan gelen sayıya tam bolunuyorsa altaki labele yazılsın
                    if (sayi2 % bolen == 0)
                    {
                        lb2Sayi02.Text = Convert.ToString(sayi2 / bolen);
                    }
                    else
                    {
                        lb2Sayi02.Text = Convert.ToString(sayi2);
                    }
                    cbox02.Enabled = false;
                    ekok *= bolen;
                    pbox02.Visible = true;
                }
                //iki sayıda seçilen sayıya tam bölünmüyorsa kullanıcı başka sayı seçmesi için uyarılsın
                else
                {
                    MessageBox.Show(sayi1 + " sayisi ve " + sayi2 + " sayisi " + bolen + " sayisina tam bölünmediği için başka bir asal çarpan deneyiniz !");
                }
            }
            else
            {
                lbSonuc0.Text = Convert.ToString(ekok);
            }
        }

        private void cbox03_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bolen, sayi1, sayi2;

            bool kontrol = Int32.TryParse(cbox03.SelectedItem.ToString(), out bolen);
            kontrol = Int32.TryParse(lb2Sayi01.Text, out sayi1);
            kontrol = Int32.TryParse(lb2Sayi02.Text, out sayi2);

            //sayılar 1 olunca işleme girmesin
            if (sayi1 > 1 || sayi2 > 1)
            {
                //iki sayıdan biri yada ikisi comboboxtan seçilen sayıya bölünüyosa if e girsin
                if (sayi1 % bolen == 0 || sayi2 % bolen == 0)
                {
                    //birinci sayı combobextan gelen sayıya tam bolunuyorsa altaki labele yazılsın
                    if (sayi1 % bolen == 0)
                    {
                        lb3Sayi01.Text = Convert.ToString(sayi1 / bolen);
                    }
                    else
                    {
                        lb3Sayi01.Text = Convert.ToString(sayi1);
                    }
                    //ikinci sayı combobextan gelen sayıya tam bolunuyorsa altaki labele yazılsın
                    if (sayi2 % bolen == 0)
                    {
                        lb3Sayi02.Text = Convert.ToString(sayi2 / bolen);
                    }
                    else
                    {
                        lb3Sayi02.Text = Convert.ToString(sayi2);
                    }
                    cbox03.Enabled = false;
                    ekok *= bolen;
                    pbox03.Visible = true;
                }
                //iki sayıda seçilen sayıya tam bölünmüyorsa kullanıcı başka sayı seçmesi için uyarılsın
                else
                {
                    MessageBox.Show(sayi1 + " sayisi ve " + sayi2 + " sayisi " + bolen + " sayisina tam bölünmediği için başka bir asal çarpan deneyiniz !");
                }
            }
            else
            {
                lbSonuc0.Text = Convert.ToString(ekok);
            }
        }

        private void cbox04_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bolen, sayi1, sayi2;

            bool kontrol = Int32.TryParse(cbox04.SelectedItem.ToString(), out bolen);
            kontrol = Int32.TryParse(lb3Sayi01.Text, out sayi1);
            kontrol = Int32.TryParse(lb3Sayi02.Text, out sayi2);

            //sayılar 1 olunca işleme girmesin
            if (sayi1 > 1 || sayi2 > 1)
            {
                //iki sayıdan biri yada ikisi comboboxtan seçilen sayıya bölünüyosa if e girsin
                if (sayi1 % bolen == 0 || sayi2 % bolen == 0)
                {
                    //birinci sayı combobextan gelen sayıya tam bolunuyorsa altaki labele yazılsın
                    if (sayi1 % bolen == 0)
                    {
                        lb4Sayi01.Text = Convert.ToString(sayi1 / bolen);
                    }
                    else
                    {
                        lb4Sayi01.Text = Convert.ToString(sayi1);
                    }
                    //ikinci sayı combobextan gelen sayıya tam bolunuyorsa altaki labele yazılsın
                    if (sayi2 % bolen == 0)
                    {
                        lb4Sayi02.Text = Convert.ToString(sayi2 / bolen);
                    }
                    else
                    {
                        lb4Sayi02.Text = Convert.ToString(sayi2);
                    }
                    cbox04.Enabled = false;
                    ekok *= bolen;
                    pbox04.Visible = true;
                }
                //iki sayıda seçilen sayıya tam bölünmüyorsa kullanıcı başka sayı seçmesi için uyarılsın
                else
                {
                    MessageBox.Show(sayi1 + " sayisi ve " + sayi2 + " sayisi " + bolen + " sayisina tam bölünmediği için başka bir asal çarpan deneyiniz !");
                }
            }
            else
            {
                lbSonuc0.Text = Convert.ToString(ekok);
            }
        }

        private void cbox05_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bolen, sayi1, sayi2;

            bool kontrol = Int32.TryParse(cbox05.SelectedItem.ToString(), out bolen);
            kontrol = Int32.TryParse(lb4Sayi01.Text, out sayi1);
            kontrol = Int32.TryParse(lb4Sayi02.Text, out sayi2);

            //sayılar 1 olunca işleme girmesin
            if (sayi1 > 1 || sayi2 > 1)
            {
                //iki sayıdan biri yada ikisi comboboxtan seçilen sayıya bölünüyosa if e girsin
                if (sayi1 % bolen == 0 || sayi2 % bolen == 0)
                {
                    //birinci sayı combobextan gelen sayıya tam bolunuyorsa altaki labele yazılsın
                    if (sayi1 % bolen == 0)
                    {
                        lb5Sayi01.Text = Convert.ToString(sayi1 / bolen);
                    }
                    else
                    {
                        lb5Sayi01.Text = Convert.ToString(sayi1);
                    }
                    //ikinci sayı combobextan gelen sayıya tam bolunuyorsa altaki labele yazılsın
                    if (sayi2 % bolen == 0)
                    {
                        lb5Sayi02.Text = Convert.ToString(sayi2 / bolen);
                    }
                    else
                    {
                        lb5Sayi02.Text = Convert.ToString(sayi2);
                    }
                    cbox05.Enabled = false;
                    ekok *= bolen;
                    pbox05.Visible = true;
                }
                //iki sayıda seçilen sayıya tam bölünmüyorsa kullanıcı başka sayı seçmesi için uyarılsın
                else
                {
                    MessageBox.Show(sayi1 + " sayisi ve " + sayi2 + " sayisi " + bolen + " sayisina tam bölünmediği için başka bir asal çarpan deneyiniz !");
                }
            }
            else
            {
                lbSonuc0.Text = Convert.ToString(ekok);
            }
        }

        private void cbox06_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bolen, sayi1, sayi2;

            bool kontrol = Int32.TryParse(cbox06.SelectedItem.ToString(), out bolen);
            kontrol = Int32.TryParse(lb5Sayi01.Text, out sayi1);
            kontrol = Int32.TryParse(lb5Sayi02.Text, out sayi2);

            //sayılar 1 olunca işleme girmesin
            if (sayi1 > 1 || sayi2 > 1)
            {
                //iki sayıdan biri yada ikisi comboboxtan seçilen sayıya bölünüyosa if e girsin
                if (sayi1 % bolen == 0 || sayi2 % bolen == 0)
                {
                    //birinci sayı combobextan gelen sayıya tam bolunuyorsa altaki labele yazılsın
                    if (sayi1 % bolen == 0)
                    {
                        lb6Sayi01.Text = Convert.ToString(sayi1 / bolen);
                    }
                    else
                    {
                        lb6Sayi01.Text = Convert.ToString(sayi1);
                    }
                    //ikinci sayı combobextan gelen sayıya tam bolunuyorsa altaki labele yazılsın
                    if (sayi2 % bolen == 0)
                    {
                        lb6Sayi02.Text = Convert.ToString(sayi2 / bolen);
                    }
                    else
                    {
                        lb6Sayi02.Text = Convert.ToString(sayi2);
                    }
                    cbox06.Enabled = false;
                    ekok *= bolen;
                    pbox06.Visible = true;
                }
                //iki sayıda seçilen sayıya tam bölünmüyorsa kullanıcı başka sayı seçmesi için uyarılsın
                else
                {
                    MessageBox.Show(sayi1 + " sayisi ve " + sayi2 + " sayisi " + bolen + " sayisina tam bölünmediği için başka bir asal çarpan deneyiniz !");
                }
            }
            else
            {
                lbSonuc0.Text = Convert.ToString(ekok);
            }
        }

        private void cbox07_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bolen, sayi1, sayi2;

            bool kontrol = Int32.TryParse(cbox07.SelectedItem.ToString(), out bolen);
            kontrol = Int32.TryParse(lb6Sayi01.Text, out sayi1);
            kontrol = Int32.TryParse(lb6Sayi02.Text, out sayi2);

            //sayılar 1 olunca işleme girmesin
            if (sayi1 > 1 || sayi2 > 1)
            {
                //iki sayıdan biri yada ikisi comboboxtan seçilen sayıya bölünüyosa if e girsin
                if (sayi1 % bolen == 0 || sayi2 % bolen == 0)
                {
                    //birinci sayı combobextan gelen sayıya tam bolunuyorsa altaki labele yazılsın
                    if (sayi1 % bolen == 0)
                    {
                        lb7Sayi01.Text = Convert.ToString(sayi1 / bolen);
                    }
                    else
                    {
                        lb7Sayi01.Text = Convert.ToString(sayi1);
                    }
                    //ikinci sayı combobextan gelen sayıya tam bolunuyorsa altaki labele yazılsın
                    if (sayi2 % bolen == 0)
                    {
                        lb7Sayi02.Text = Convert.ToString(sayi2 / bolen);
                    }
                    else
                    {
                        lb7Sayi02.Text = Convert.ToString(sayi2);
                    }
                    cbox07.Enabled = false;
                    ekok *= bolen;
                    pbox07.Visible = true;
                }
                //iki sayıda seçilen sayıya tam bölünmüyorsa kullanıcı başka sayı seçmesi için uyarılsın
                else
                {
                    MessageBox.Show(sayi1 + " sayisi ve " + sayi2 + " sayisi " + bolen + " sayisina tam bölünmediği için başka bir asal çarpan deneyiniz !");
                }
            }
            else
            {
                lbSonuc0.Text = Convert.ToString(ekok);
            }
        }

        private void cbox08_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bolen, sayi1, sayi2;

            bool kontrol = Int32.TryParse(cbox08.SelectedItem.ToString(), out bolen);
            kontrol = Int32.TryParse(lb7Sayi01.Text, out sayi1);
            kontrol = Int32.TryParse(lb7Sayi02.Text, out sayi2);

            //sayılar 1 olunca işleme girmesin
            if (sayi1 > 1 || sayi2 > 1)
            {
                //iki sayıdan biri yada ikisi comboboxtan seçilen sayıya bölünüyosa if e girsin
                if (sayi1 % bolen == 0 || sayi2 % bolen == 0)
                {
                    //birinci sayı combobextan gelen sayıya tam bolunuyorsa altaki labele yazılsın
                    if (sayi1 % bolen == 0)
                    {
                        lb8Sayi01.Text = Convert.ToString(sayi1 / bolen);
                    }
                    else
                    {
                        lb8Sayi01.Text = Convert.ToString(sayi1);
                    }
                    //ikinci sayı combobextan gelen sayıya tam bolunuyorsa altaki labele yazılsın
                    if (sayi2 % bolen == 0)
                    {
                        lb8Sayi02.Text = Convert.ToString(sayi2 / bolen);
                    }
                    else
                    {
                        lb8Sayi02.Text = Convert.ToString(sayi2);
                    }
                    cbox08.Enabled = false;
                    ekok *= bolen;
                    pbox08.Visible = true;
                }
                //iki sayıda seçilen sayıya tam bölünmüyorsa kullanıcı başka sayı seçmesi için uyarılsın
                else
                {
                    MessageBox.Show(sayi1 + " sayisi ve " + sayi2 + " sayisi " + bolen + " sayisina tam bölünmediği için başka bir asal çarpan deneyiniz !");
                }
            }
            else
            {
                lbSonuc0.Text = Convert.ToString(ekok);
            }
        }

        private void cbox09_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bolen, sayi1, sayi2;

            bool kontrol = Int32.TryParse(cbox09.SelectedItem.ToString(), out bolen);
            kontrol = Int32.TryParse(lb8Sayi01.Text, out sayi1);
            kontrol = Int32.TryParse(lb8Sayi02.Text, out sayi2);

            //sayılar 1 olunca işleme girmesin
            if (sayi1 > 1 || sayi2 > 1)
            {
                //iki sayıdan biri yada ikisi comboboxtan seçilen sayıya bölünüyosa if e girsin
                if (sayi1 % bolen == 0 || sayi2 % bolen == 0)
                {
                    //birinci sayı combobextan gelen sayıya tam bolunuyorsa altaki labele yazılsın
                    if (sayi1 % bolen == 0)
                    {
                        lb9Sayi01.Text = Convert.ToString(sayi1 / bolen);
                    }
                    else
                    {
                        lb9Sayi01.Text = Convert.ToString(sayi1);
                    }
                    //ikinci sayı combobextan gelen sayıya tam bolunuyorsa altaki labele yazılsın
                    if (sayi2 % bolen == 0)
                    {
                        lb9Sayi02.Text = Convert.ToString(sayi2 / bolen);
                    }
                    else
                    {
                        lb9Sayi02.Text = Convert.ToString(sayi2);
                    }
                    cbox09.Enabled = false;
                    ekok *= bolen;
                    pbox09.Visible = true;
                }
                //iki sayıda seçilen sayıya tam bölünmüyorsa kullanıcı başka sayı seçmesi için uyarılsın
                else
                {
                    MessageBox.Show(sayi1 + " sayisi ve " + sayi2 + " sayisi " + bolen + " sayisina tam bölünmediği için başka bir asal çarpan deneyiniz !");
                }
            }
            else
            {
                lbSonuc0.Text = Convert.ToString(ekok);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("-EBOB'un adı üstünde: En Büyük Ortak Bölen"
                +"\n-Yani sayıların bölenlerini bulacağız, ortak olanlarını bulacağız, bunlardan en büyük olanı EBOB'tur."
                +"\n-İki veya daha fazla çokluğun ortak bölenlerinin en büyüğüdür. Doğal olarak sorularda bütünü parçalamamızı istiyorsa EBOB kullanma ihtimalimiz yüksek."
                +"\n-Aralarında asal sayıların ebob'ları 1'dir. ( EBOB (16,35) = 1 )"
                +"\n-İki sayının çarpımı, EBOB'ları ile EKOK'larının çarpımına eşittir");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-İki ya da daha fazla doğal sayının ortak katlarının en küçüğüne bu sayıların en küçük ortak katı, kısaca EKOK'u denir."
            + "\n-# EKOK'un adı üstünde: En Küçük Ortak Kat"
            + "\n-İki veya daha fazla çokluğu ortak katlarının en büyüğüdür.Doğal olarak sorularda parçalardan bütüne gitmemiz istiyorsa ekok kullanma ihtimalimiz yüksek."
            + "\n-İki sayının çarpımı, EBOB'ları ile EKOK'larının çarpımına eşittir");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bidonlarda,varillerde,şişelerde,çuvallarda,kaplarda bulunan malzemeler,daha küçük başka kaplara aktarılıyorsa","EBOB");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tarlanın etrafına eşit aralıklarla kaç ağaç dikilir ?", "EBOB");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dikdörtgen şeklindeki kartondan küçük kare kartonlar elde etmek", "EBOB");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cevizler,fındıklar,şekerler,bilyeler sayılıyorsa veya bunlar sayıldıktan sonra artan oluyorsa", "EKOK");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gemiler,arabalar,yarışçılar beraber yola çıkıp bir yerde karşılaşıyorsa veya kaç gün sonra,kaç yıl sonra karşılaşırlar", "EKOK");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sınıfta öğrenciler sıralara oturuyorlarsa veya bunlardan ayakta kalanlar oluyorsa", "EKOK"); 
        }
      }

    }
