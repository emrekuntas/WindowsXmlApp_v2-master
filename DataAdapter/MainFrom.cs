using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAdapter
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cutomer customer = new Cutomer();
            customer.MdiParent = this;
            customer.Show();


        }

        private void MainFrom_Load(object sender, EventArgs e)
        {

        }

        private void customersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Cutomer customer = new Cutomer();
            customer.MdiParent = this;
            customer.Show();
            

        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Urunler urunler = new Urunler();
            urunler.MdiParent = this;
            urunler.Show();


        }
    }
}
