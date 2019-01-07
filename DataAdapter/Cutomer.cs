using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAdapter
{
    public partial class Cutomer : Form
    {
        DataTable dt;
        DataSet ds;
        string sql;
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlServer"].ConnectionString);

        public Cutomer()
        {
            InitializeComponent();
        }

        private void Cutomer_Load(object sender, EventArgs e)
        {
            DataTable customer;
            DataRow row;

            sql = "Select * from Customers";
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.Connection = con;
            con.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            customer = getCustomerShema();
            //dataları row a atama
            while (rd.Read())
            {


                row = customer.NewRow();
                row["CustomerID"] = rd["CustomerID"];
                row["CompanyName"] = rd["CompanyName"];
                row["ContactName"] = rd["ContactName"];
                row["ContactTitle"] = rd["ContactTitle"];
                row["Address"] = rd["Address"];
                row["City"] = rd["City"];
                row["Region"] = rd["Region"];
                row["PostalCode"] = rd["PostalCode"];
                row["Country"] = rd["Country"];
                row["Phone"] = rd["Phone"];
                row["Fax"] = rd["Fax"];

                customer.Rows.Add(row);
                
            }

            dataGridView1.DataSource = customer;
            
        }
        public DataTable getCustomerShema()
        {
            DataColumn col = new DataColumn();
            dt = new DataTable();
            //customer ıd

            col.Caption = "Customer Id";
            col.ColumnName = "CustomerID";
            col.DataType = typeof(System.String);
            dt.Columns.Add(col);

            col = new DataColumn();
            col.Caption = "Company Name";
            col.ColumnName = "CompanyName";
            col.DataType = typeof(System.String);
            dt.Columns.Add(col);

            col = new DataColumn();
            col.Caption = "Contact Name";
            col.ColumnName = "ContactName";
            col.DataType = typeof(System.String);
            dt.Columns.Add(col);


            col = new DataColumn();
            col.Caption = "Contact Title";
            col.ColumnName = "ContactTitle";
            col.DataType = typeof(System.String);
            dt.Columns.Add(col);

            col = new DataColumn();
            col.Caption = "Address";
            col.ColumnName = "Address";
            col.DataType = typeof(System.String);
            dt.Columns.Add(col);


            col = new DataColumn();
            col.Caption = "City";
            col.ColumnName = "City";
            col.DataType = typeof(System.String);
            dt.Columns.Add(col);



            col = new DataColumn();
            col.Caption = "Region";
            col.ColumnName = "Region";
            col.DataType = typeof(System.String);
            dt.Columns.Add(col);

            col = new DataColumn();
            col.Caption = "PostalCode";
            col.ColumnName = "PostalCode";
            col.DataType = typeof(System.String);
            dt.Columns.Add(col);

            col = new DataColumn();
            col.Caption = "Country";
            col.ColumnName = "Country";
            col.DataType = typeof(System.String);
            dt.Columns.Add(col);

            col = new DataColumn();
            col.Caption = "Phone";
            col.ColumnName = "Phone";
            col.DataType = typeof(System.String);
            dt.Columns.Add(col);

            col = new DataColumn();
            col.Caption = "Fax";
            col.ColumnName = "Fax";
            col.DataType = typeof(System.String);
            dt.Columns.Add(col);


            return dt;
        }
    }
}
