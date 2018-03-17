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
    public partial class Importers : Form
    {
        public Importers()
        {
            InitializeComponent();
        }

        private void importersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.importersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eBuyDataSet);

        }


        private void Importers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eBuyDataSet.Buyers' table. You can move, or remove it, as needed.
            this.buyersTableAdapter.Fill(this.eBuyDataSet.Buyers);
            // TODO: This line of code loads data into the 'eBuyDataSet.Branches' table. You can move, or remove it, as needed.
            this.branchesTableAdapter.Fill(this.eBuyDataSet.Branches);
            // TODO: This line of code loads data into the 'eBuyDataSet.Importers' table. You can move, or remove it, as needed.
            this.importersTableAdapter.Fill(this.eBuyDataSet.Importers);
            importPhoneTextBox.KeyPress += Helper.CheckNumber;
            importNameTextBox.KeyPress += Helper.CheckNameWord;
            importAddressTextBox.KeyPress += Helper.CheckNameNumberWord;
            importMailTextBox.KeyPress += Helper.CheckNameNumberWordMail;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            importersBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            importersBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            importersBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            importersBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            importersBindingSource.AddNew();
            importIDTextBox.Text = (this.eBuyDataSet.Importers.Rows.Count + 1).ToString();
            button8.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!Helper.CheckMail(importMailTextBox.Text))
            {
                MessageBox.Show("Mail doesn't fit the format");
                return;
            }
            importersBindingSource.EndEdit();
            importersTableAdapter.Update(this.eBuyDataSet.Importers);
            button8.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!Helper.CheckMail(importMailTextBox.Text))
            {
                MessageBox.Show("Mail doesn't fit the format");
                return;
            }
            importersBindingSource.EndEdit();
            importersTableAdapter.Update(this.eBuyDataSet.Importers);
            button8.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            importNameTextBox.Text = "";
            importAddressTextBox.Text = "";
            importPhoneTextBox.Text = "";
            importMailTextBox.Text = "";
        }
    }
}
