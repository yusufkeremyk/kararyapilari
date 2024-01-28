using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace karar_yapilari_egzersiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2, prj, ort;
            string durum;
            s1 = Convert.ToDouble(textBox1.Text);
            s2= Convert.ToDouble(textBox2.Text);
            prj= Convert.ToDouble(textBox3.Text);

            ort = (s1 + s2 + prj) / 3;
            if ( ort >= 50 )
            {
                durum = "Geçti!";
            }
            else
            {
                durum = "Geçemedi!";
            }
            textBox4.Text = ort.ToString("0.00") + " - " + durum;
        }
    }
}
