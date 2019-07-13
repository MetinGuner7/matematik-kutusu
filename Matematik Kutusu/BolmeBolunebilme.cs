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
    public partial class BolmeBolunebilme : Form
    {
        public BolmeBolunebilme()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Her çift sayı 2 ile tam bölünür. Tek sayılar 2 ile tam bölünemeyip 1 kalanını verir.", "2 ile bölünebilme");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int bolunen,bolen,kalan;
            lbHata.Text = "";

            bool onay = Int32.TryParse(txtBolunen.Text, out bolunen);
            bool onay1 = Int32.TryParse(txtBolen.Text, out bolen);
            if (bolen > 0)
            {
                lbSonuc.Text = Convert.ToString(bolunen / bolen);
                kalan = bolunen % bolen;
                lbKalan.Text = Convert.ToString(kalan);
                if (kalan > 0)
                {
                    lbKalan.ForeColor = Color.Red;
                }
                else
                {
                    lbKalan.ForeColor = Color.Green;
                }

            }
            else
            {
                lbHata.Text = "Yanlış bir değer girdiniz !!!";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rakamlarının toplamı 3 ün katı olan sayı 3 ile tam bölünür. Kalan, rakamlar toplamının 3 ile bölümünden kalana eşittir.", "3 ile bölünebilme");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bir sayının son iki basamağı 4 ün katı ise bu sayı 4 e tam bölünür. Kalan son iki basamağında belirtilen sayının 4 ile bölümüne eşittir.", "4 ile bölünebilme");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bir sayının son iki rakamında 0 veya 5 bulunuyorsa o sayı 5 ile tam bölünür. Aksi halde kalan son basamağın 5 ile bölümünden kalana eşittir.", "5 ile bölünebilme");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eğer bir sayı 2 veya 3 e tam bölünüyorsa 6 ya da tam bölünür.", "6 ile bölünebilme");
        }
        private void button4_Click(object sender, EventArgs e)
        {
         MessageBox.Show("1, 3 ve 2 sayıları bir sayının sırasıyla birler, onlar ve yüzler basamağıyla sırayla çarpılır. Çıkan üçlü grupların toplamlarının farkı, o sayının 7 ile bölümünden kalana eşittir.", "7 ile bölünebilme");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bir sayının son üç basamağının oluşturduğu sayı 8 ile tam bölünüyorsa o sayı 8 ile tam bölünür. Kalan o sayının son üç basamağının oluşturan sayının 8 ile bölümünden kalana eşittir.", "8 ile bölünebilme");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rakamlarının toplamı 9 un katı olan sayı 9 ile tam bölünür. Kalan, rakamlar toplamının 9 ile bölümünden kalana eşittir.", "9 ile bölünebilme");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bir sayının son rakamı 0 ise o sayı 10 ile tam bölünür. Değil ise o sayının 10 ile bölümünden kalan, o sayının son (birler) basamağındaki rakama eşittir.", "10 ile bölünebilme");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("abcdef gibi bir sayının 11 ile bölümünden kalanı bulmak için birler basamağından itibaren birer atlanarak toplanır. Çıkan iki ayrı değerin farkının 11 ile bölümünden kalan, sayının 11 ile bölümünden kalana eşittir.", "11 ile bölünebilme");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uyarı: Aralarında asal sayılara tam bölünebilen bir sayı bu sayıların çarpımına da tam bölünür.\n 2 ve 3 ile bölünebilen sayılar 6 ile, \n2 ve 5 ile bölünebilen sayılar 10 ile,\n3 ve 4 ile bölünebilen sayılar 12 ile,\n3 ve 5 ile bölünebilen sayılar 15 ile,\n2 ve 9 ile bölünebilen sayılar 18 ile,\n4 ve 5 ile bölünebilen sayılar 20 ile,\n2 ve 11 ile bölünebilen sayılar 22 ile,\n3 ve 8 ile bölünebilen sayılar 24 ile,\n4 ve 9 ile bölünebilen sayılar 36 ile,\n5 ve 9 ile bölünebilen sayılar 45 ile,﻿﻿﻿﻿﻿﻿", "Aralarında Asal sayıya Bölünen Sayılar");

        }
    }
}
