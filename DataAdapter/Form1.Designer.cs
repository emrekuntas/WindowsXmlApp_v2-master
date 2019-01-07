namespace DataAdapter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xMLOlarakAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONOlarakAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOAPOlarakAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serilizeEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLOlarakAktarToolStripMenuItem,
            this.jSONOlarakAktarToolStripMenuItem,
            this.sOAPOlarakAktarToolStripMenuItem,
            this.serilizeEtToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 92);
            // 
            // xMLOlarakAktarToolStripMenuItem
            // 
            this.xMLOlarakAktarToolStripMenuItem.Name = "xMLOlarakAktarToolStripMenuItem";
            this.xMLOlarakAktarToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.xMLOlarakAktarToolStripMenuItem.Text = "XML Olarak Aktar";
            this.xMLOlarakAktarToolStripMenuItem.Click += new System.EventHandler(this.xMLOlarakAktarToolStripMenuItem_Click);
            // 
            // jSONOlarakAktarToolStripMenuItem
            // 
            this.jSONOlarakAktarToolStripMenuItem.Name = "jSONOlarakAktarToolStripMenuItem";
            this.jSONOlarakAktarToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.jSONOlarakAktarToolStripMenuItem.Text = "JSON Olarak Aktar";
            this.jSONOlarakAktarToolStripMenuItem.Click += new System.EventHandler(this.jSONOlarakAktarToolStripMenuItem_Click);
            // 
            // sOAPOlarakAktarToolStripMenuItem
            // 
            this.sOAPOlarakAktarToolStripMenuItem.Name = "sOAPOlarakAktarToolStripMenuItem";
            this.sOAPOlarakAktarToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.sOAPOlarakAktarToolStripMenuItem.Text = "SOAP Olarak Aktar";
            this.sOAPOlarakAktarToolStripMenuItem.Click += new System.EventHandler(this.sOAPOlarakAktarToolStripMenuItem_Click);
            // 
            // serilizeEtToolStripMenuItem
            // 
            this.serilizeEtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.personelToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.orderDetailsToolStripMenuItem});
            this.serilizeEtToolStripMenuItem.Name = "serilizeEtToolStripMenuItem";
            this.serilizeEtToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.serilizeEtToolStripMenuItem.Text = "Tabloları Al";
            this.serilizeEtToolStripMenuItem.Click += new System.EventHandler(this.serilizeEtToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.customerToolStripMenuItem.Text = "Customers";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.personelToolStripMenuItem.Text = "Employees";
            this.personelToolStripMenuItem.Click += new System.EventHandler(this.personelToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.ordersToolStripMenuItem.Text = "Orders";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // orderDetailsToolStripMenuItem
            // 
            this.orderDetailsToolStripMenuItem.Name = "orderDetailsToolStripMenuItem";
            this.orderDetailsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.orderDetailsToolStripMenuItem.Text = "Order Details";
            this.orderDetailsToolStripMenuItem.Click += new System.EventHandler(this.orderDetailsToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xMLOlarakAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONOlarakAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sOAPOlarakAktarToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem serilizeEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderDetailsToolStripMenuItem;
    }
}

