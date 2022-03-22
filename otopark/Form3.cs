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
using System.Collections;

namespace otopark
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection();
        List<kisi> liste = new List<kisi>();
        private void Kaydet_btn_Click(object sender, EventArgs e)
        {


            if (txt_aboneno.Text != "" && txtad.Text != "" && txtsoyad.Text != "" && txt_plaka.Text != "") 
            {
                con.Open();

                
                kisi yenikisi = new kisi();
                yenikisi.tc = txt_aboneno.Text; 
                yenikisi.ad = txtad.Text;
                yenikisi.soyad = txtsoyad.Text;
                yenikisi.plaka = txt_plaka.Text;
                liste.Add(yenikisi);


                SqlCommand komut = new SqlCommand();
                komut.CommandText = "insert into Kisi values(@p1,@p2,@p3,@p4)"; 
                komut.Parameters.AddWithValue("@p1", yenikisi.tc);
                komut.Parameters.AddWithValue("@p2", yenikisi.ad);
                komut.Parameters.AddWithValue("@p3", yenikisi.soyad);
                komut.Connection = con;

                komut.ExecuteNonQuery();
                MessageBox.Show("kayıt eklendi");

            }
            else
            {
                MessageBox.Show("boş alan bırakmayınız");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        }

        private void Sorgulla_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") 
            {
                liste.Clear(); 
                con.Open();
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "select * from kisi where aboneid" + textBox1.Text; 
                komut.Connection = con;
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {

                    kisi yenikisi = new kisi();
                    yenikisi.kisi_id = dr["kisi_id"].ToString(); ; 
                    yenikisi.tc = dr["tc"].ToString();
                    yenikisi.ad = dr["ad"].ToString();
                    yenikisi.soyad = dr["soyad"].ToString();
                    liste.Add(yenikisi);

                }
                else
                {
                    MessageBox.Show("aradığınız tc bulunamadı");
                }
                con.Close();
                dataGridView1.DataSource = null;
                

            }
            else
            {
                MessageBox.Show("lütfen bir tc değeri giriniz");
            }










            //    bool durum;
            //  con.Open();
            //  SqlCommand komut = new SqlCommand();
            // komut.CommandText = "select * from Kisi where aboneid=" + txt_aboneno.Text;
            //  komut.Connection = con;
            //  SqlDataReader dr = komut.ExecuteReader();
            //   durum = dr.HasRows;
            //   con.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1) 
            {
                kisi yenikisi = (kisi)dataGridView1.SelectedRows[0].DataBoundItem;

                txt_aboneno.Text = yenikisi.kisi_id.ToString(); 
                txt_plaka.Text = yenikisi.tc;
                txtad.Text = yenikisi.ad;
                txtsoyad.Text = yenikisi.soyad;

            }
        }

        private void guncelle_btn_Click(object sender, EventArgs e)
        {
            if (txt_aboneno.Text != "" && txt_plaka.Text != "" && txtad.Text != "" && txtsoyad.Text != "")  
                                                                                                 
            {
                kisi yenikisi = new kisi();
                yenikisi.kisi_id = (txt_aboneno.Text); 
                yenikisi.tc = txt_plaka.Text;
                yenikisi.ad = txtad.Text;
                yenikisi.soyad = txtsoyad.Text;


                con.Open();

                SqlCommand komut = new SqlCommand();

                komut.CommandText = "update Kisi set plaka=@p1, ad=@p2, soyad=@p3 where kisi_id =@p4"; 
                
                komut.Parameters.AddWithValue("@p1", yenikisi.plaka);
                komut.Parameters.AddWithValue("@p2", yenikisi.ad);
                komut.Parameters.AddWithValue("@p3", yenikisi.soyad);
                komut.Parameters.AddWithValue("@p4", yenikisi.kisi_id);
                komut.Connection = con;
                komut.ExecuteNonQuery();
                MessageBox.Show("kayıt güncellendi");

            }
            else
            {
                MessageBox.Show("Güncellemek için kayıt seçmelisiniz");
            }

            con.Close();
           


            
        }
    }
}
