using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace otopark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // this.IsMdiContainer = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            con.Open();
            SqlCommand komut = new SqlCommand();
            //komut.CommandText = "select * from Kullanici where kuladi='" + txtkuladi.Text + " ' and sifre= '" + txtsifre.Text + "'";
            komut.CommandText = "SELECT * FROM kullanici where kullaniciad='" + txt_kulladı.Text + "' AND sifre='" + txt_sifre.Text + "'";
            komut.Connection = con;
            SqlDataReader dr = komut.ExecuteReader();


            if (dr.HasRows)
            {
                bool adminMi;
                if (txt_kulladı.Text == "admin")
                {
                    adminMi = true;

                }
                else
                {
                    adminMi = false;
                }

                Form2 form = new Form2 ();   
                form.ShowDialog();

            }
            else
            {
                MessageBox.Show("hatalı kullanıcı adı veya şifre");
            }




            con.Close();
            // Form2 form2 = new Form2();
            // form2.ShowDialog();

            // form2.MdiParent = this;
            // form2.Show();

        }
    }
}
