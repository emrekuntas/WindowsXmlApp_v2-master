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
    public partial class Urunler : Form
    {
       

        public Urunler()
        {
            InitializeComponent();
        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nORTHWND2DataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.nORTHWND2DataSet.Products);



        }
    }
}
