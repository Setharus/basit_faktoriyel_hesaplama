using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi, sonuc = 1;
            sayi = Convert.ToInt32(txtSayi.Text);

            for (int i = 1; i <= sayi; i++)
            {
                sonuc *= i;
            }
            lblSonuc.Text = sonuc.ToString();
        }
    }
}
