using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otopark
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void AracGuncelle_btn_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           string plaka;
            plaka = lbl_Plaka.Text;
            label6.Text = dateTimePicker1.Value.ToString();
            label4.Text = dateTimePicker2.Value.ToString();
            lbl_Plaka.Text = txt_plaka.Text;
            if (txt_plaka.Text== plaka)
            {
                label5.Text = "";
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
