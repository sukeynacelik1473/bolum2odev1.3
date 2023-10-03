using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOLUM2_UYGULAMA_KİTAP_ODEV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKarsılastır_Click(object sender, EventArgs e)
        {
            byte sayı1, sayı2;
            sayı1 = Convert.ToByte(txtSayı1.Text);
            sayı2 = Convert.ToByte(txtSayı2.Text);
            if (sayı1 > sayı2)
            {
                MessageBox.Show("1.sayı2.sayıdan büyüktür");
            }
            if (sayı1 == sayı2)
            {
                MessageBox.Show("sayılar birbirıne eşitir");
            }
            if (sayı1 < sayı2)
            {
                MessageBox.Show("2.sayı1.sayıdan büyüktür");
            }
        }
    }
}
