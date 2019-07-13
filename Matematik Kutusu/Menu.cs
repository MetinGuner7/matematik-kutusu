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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Close();
            
            Geometri yeni = new Geometri();
            yeni.Show();
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Close();

            KokluSayilar yeni = new KokluSayilar();
            yeni.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Close();

            Denklemler yeni = new Denklemler();
            yeni.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Close();

            Problemler yeni = new Problemler();
            yeni.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Close();

            BolmeBolunebilme yeni = new BolmeBolunebilme();
            yeni.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Close();

            EbobEkok yeni = new EbobEkok();
            yeni.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Close();

            Test yeni = new Test();
            yeni.ShowDialog();
        }
    }
}
