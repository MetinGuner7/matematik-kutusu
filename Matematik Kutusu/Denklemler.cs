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
    public partial class Denklemler : Form
    {
        public Denklemler()
        {
            InitializeComponent();
        }
        private void Denklemler_Closing(object sender, FormClosingEventArgs e)
        {

            Menu menu = new Menu();
            menu.Show();
        }
        
    }
}
