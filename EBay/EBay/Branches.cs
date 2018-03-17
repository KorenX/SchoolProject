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
    public partial class Branches : Form
    {
        public Branches()
        {
            InitializeComponent();
        }

        private void branchesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.branchesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eBuyDataSet);

        }

        private void Branches_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eBuyDataSet.Branches' table. You can move, or remove it, as needed.
            this.branchesTableAdapter.Fill(this.eBuyDataSet.Branches);

            branchNameTextBox.KeyPress +=Helper.CheckNameWord;
            branchAddressTextBox.KeyPress += Helper.CheckNameNumberWord;
            branchPhoneTextBox.KeyPress += Helper.CheckNumber;
            branchManagerTextBox.KeyPress += Helper.CheckNameWord;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            branchesBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            branchesBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            branchesBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            branchesBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            branchesBindingSource.AddNew();
            branchIDTextBox.Text = (this.eBuyDataSet.Branches.Rows.Count + 1).ToString();
            button8.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            branchesBindingSource.EndEdit();
            branchesTableAdapter.Update(this.eBuyDataSet.Branches);
            button8.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            branchesBindingSource.EndEdit();
            branchesTableAdapter.Update(this.eBuyDataSet.Branches);
            button8.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            branchNameTextBox.Text = "";
            branchAddressTextBox.Text = "";
            branchPhoneTextBox.Text = "";
            branchManagerTextBox.Text = "";
        }
    }
}

