using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Customer
{






    public partial class Form1 : Form
    {


        DataKey ds;
        DataTable dt;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = getCustomerShema();



        }
        public DataTable getCustomerShema()
        {
            DataColumn col = new DataColumn();
            dt = new DataTable();
            //customer ıd
            
            col.Caption = "Customer Id";
            col.ColumnName = "CustomerID";
            col.DataType = typeof(System.Int32);
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
            col.Caption = "Adress";
            col.ColumnName = "Adress";
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

            
            return dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
