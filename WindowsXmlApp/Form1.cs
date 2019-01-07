using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace WindowsXmlApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            

            
            
        }

        

        public List<Ogrenci> olist = new List<Ogrenci>();
        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci();
            o.ID = Guid.NewGuid();
            o.Ad = textBoxAd.Text;
            o.Soyad = textBoxSoyad.Text;
            o.DogumTarih = dateTimePicker1.Value;

            if (radioButton1.Checked)
                o.Cinsiyet = Cinsiyet.Kadın;
            else if (radioButton2.Checked)
                o.Cinsiyet = Cinsiyet.Erkek;
            else
                o.Cinsiyet = Cinsiyet.Diğer;

            olist.Add(o);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = olist;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileOgrenci.Title = "Öğrenci Bilgileri Kayıt";
            saveFileOgrenci.Filter = "*.xml|*.xml";
            saveFileOgrenci.InitialDirectory = Environment.GetFolderPath
                (Environment.SpecialFolder.Desktop);

            XmlSerializer srl = new XmlSerializer(typeof(List<Ogrenci>));

            if (saveFileOgrenci.ShowDialog()==DialogResult.OK)
            {
                TextWriter tw = new StreamWriter(saveFileOgrenci.FileName);
                srl.Serialize(tw, olist);
                tw.Close();
                MessageBox.Show("Liste Kaydedildi");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Ogrenci> okunanogrenciler = new List<Ogrenci>();
            XmlSerializer srl = new XmlSerializer(typeof(List<Ogrenci>));
            if (openFileOgrenci.ShowDialog()== DialogResult.OK)
            {
                TextReader tr = new StreamReader(openFileOgrenci.FileName);
                okunanogrenciler = (List<Ogrenci>)srl.Deserialize(tr);
                tr.Close();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = okunanogrenciler;
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(@"C:\Users\iau\Desktop\aa.xml");//herhangi bir xml adresi 
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci();
            o.ID = Guid.NewGuid();
            o.Ad = textBoxAd.Text;
            o.Soyad = textBoxSoyad.Text;
            o.DogumTarih = dateTimePicker1.Value;

            if (radioButton1.Checked)
                o.Cinsiyet = Cinsiyet.Kadın;
            else if (radioButton2.Checked)
                o.Cinsiyet = Cinsiyet.Erkek;
            else
                o.Cinsiyet = Cinsiyet.Diğer;

            olist.Add(o);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = olist;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileOgrenci.Title = "Öğrenci Bilgileri Kayıt";
                saveFileOgrenci.Filter = "*.ktc|*.ktc";
                saveFileOgrenci.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (saveFileOgrenci.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fsWrite = new FileStream(saveFileOgrenci.FileName, FileMode.Create))
                    {
                        BinaryFormatter bfWrite = new BinaryFormatter();
                        bfWrite.Serialize(fsWrite, olist);
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Hata:" + ex.Message);

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                List<Ogrenci> result = new List<Ogrenci>();
                openFileOgrenci.Title = "KTC Dosyaları";
                openFileOgrenci.Filter = "*.ktc|*.ktc";
                openFileOgrenci.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (openFileOgrenci.ShowDialog()==DialogResult.OK)
                {
                    using (FileStream fsRead = new FileStream(openFileOgrenci.FileName, FileMode.Open))
                    {
                        BinaryFormatter bfRead = new BinaryFormatter();
                        result = (List<Ogrenci>)bfRead.Deserialize(fsRead);
                    }
                    MessageBox.Show("Liste Alindi");
                }
                dataGridView1.DataSource = result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
