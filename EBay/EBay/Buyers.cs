using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBay
{
    public partial class Buyers : Form
    {
        public Buyers()
        {
            InitializeComponent();
        }

        private void buyersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.buyersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eBuyDataSet);

        }

        private void Buyers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eBuyDataSet.Buyers' table. You can move, or remove it, as needed.
            this.buyersTableAdapter.Fill(this.eBuyDataSet.Buyers);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buyersBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buyersBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buyersBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buyersBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buyersBindingSource.AddNew();
            buyerIDTextBox.Text = (this.eBuyDataSet.Buyers.Rows.Count+1).ToString();
            button8.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buyersBindingSource.EndEdit();
            buyersTableAdapter.Update(this.eBuyDataSet.Buyers);
            button8.Enabled = false;
        }

        private void Clear(object sender, EventArgs e)
        {
            buyerNameTextBox.Text = "";
            buyerAddressTextBox.Text = "";
            buyerPhoneTextBox.Text = "";
            buyerMailTextBox.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(this.eBuyDataSet.Buyers);
                dv.RowFilter = "BuyerName Like '%" + textBox1.Text + "%' OR BuyerID = " + int.Parse(textBox1.Text);
                buyersDataGridView.DataSource = dv;
            }
            catch (Exception)
            {
                DataView dv = new DataView(this.eBuyDataSet.Buyers);
                dv.RowFilter = "BuyerName Like '%" + textBox1.Text + "%'";
                buyersDataGridView.DataSource = dv;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            buyersDataGridView.DataSource = new DataView(this.eBuyDataSet.Buyers);
            textBox1.Text = "";
        }
    }
}
