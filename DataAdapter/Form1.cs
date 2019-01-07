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
using System.IO;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Soap;



namespace DataAdapter
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlServer"].ConnectionString);

        DataSet ds=new DataSet();
        SqlDataAdapter adap = new SqlDataAdapter();
        DataTable tbl;
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            tbl = new DataTable("Customer");
            ds.Tables.Add(tbl);

            tbl = new DataTable("Employees");
            ds.Tables.Add(tbl);

            tbl = new DataTable("Products");
            ds.Tables.Add(tbl);

            tbl = new DataTable("Orders");
            ds.Tables.Add(tbl);

            tbl = new DataTable("OrderDetails");
            ds.Tables.Add(tbl);

            
        }

        private void xMLOlarakAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "XML Olarak Kaydet";
            saveFileDialog1.Filter = "*.xml|*.xml";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath
                (Environment.SpecialFolder.Desktop);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ds.WriteXml(saveFileDialog1.FileName);

            }
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select*from Customers";
            cmd.Connection = con;
            adap.SelectCommand = cmd;
            adap.Fill(ds.Tables["Customer"]);
            dataGridView1.DataSource = ds.Tables["Customer"];
        }

        private void serilizeEtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select*from Employees";
            cmd.Connection = con;
            adap.SelectCommand = cmd;
            adap.Fill(ds.Tables["Employees"]);
            dataGridView1.DataSource = ds.Tables["Employees"];
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select*from Products";
            cmd.Connection = con;
            adap.SelectCommand = cmd;
            adap.Fill(ds.Tables["Products"]);
            dataGridView1.DataSource = ds.Tables["Products"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
               
             
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select*from Orders";
            cmd.Connection = con;
            adap.SelectCommand = cmd;
            adap.Fill(ds.Tables["Orders"]);
            dataGridView1.DataSource = ds.Tables["Orders"];
        }

        private void orderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select*from [Order Details]";
            cmd.Connection = con;
            adap.SelectCommand = cmd;
            adap.Fill(ds.Tables["OrderDetails"]);
            dataGridView1.DataSource = ds.Tables["OrderDetails"];
        }

        private void jSONOlarakAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            saveFileDialog1.Title = "JSON Olarak Kaydet";
            saveFileDialog1.Filter = "*.json|*.json";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath
                (Environment.SpecialFolder.Desktop);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string output = JsonConvert.SerializeObject(dataGridView1.DataSource);
                File.WriteAllText(saveFileDialog1.FileName, output);
            }
            
        }

        private void sOAPOlarakAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "SOAP Olarak Kaydet";
            saveFileDialog1.Filter = "*.dat|*.dat";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath
                (Environment.SpecialFolder.Desktop);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (FileStream tw = new FileStream(saveFileDialog1.FileName, FileMode.Append))
                {
                    SoapFormatter soap = new SoapFormatter();
                    soap.Serialize(tw, ds.Tables["Customer"]);
                    MessageBox.Show("liste kaydedildi.");
                } 
                
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
