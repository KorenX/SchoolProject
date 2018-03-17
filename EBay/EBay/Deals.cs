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
    public partial class Deals : Form
    {
        bool toggle = true;

        //add RowFilter for current DealID.
        public Deals()
        {
            InitializeComponent();
        }

        private void dealBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dealBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eBuyDataSet);

        }

        private void Deals_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eBuyDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.eBuyDataSet.Items);
            // TODO: This line of code loads data into the 'eBuyDataSet.Branches' table. You can move, or remove it, as needed.
            this.branchesTableAdapter.Fill(this.eBuyDataSet.Branches);
            // TODO: This line of code loads data into the 'eBuyDataSet.Buyers' table. You can move, or remove it, as needed.
            this.buyersTableAdapter.Fill(this.eBuyDataSet.Buyers);
            // TODO: This line of code loads data into the 'eBuyDataSet.DealItems' table. You can move, or remove it, as needed.
            this.dealItemsTableAdapter.Fill(this.eBuyDataSet.DealItems);
            // TODO: This line of code loads data into the 'eBuyDataSet.Deal' table. You can move, or remove it, as needed.
            this.dealTableAdapter.Fill(this.eBuyDataSet.Deal);

            for (int k = 0; k < buyersDataGridView.Rows.Count - 1; k++)
                dealBuyerIDComboBox.Items.Add(buyersDataGridView.Rows[k].Cells[0].Value);
            for (int k = 0; k < branchesDataGridView.Rows.Count - 1; k++)
                dealBranchIDComboBox.Items.Add(branchesDataGridView.Rows[k].Cells[0].Value);
            for (int k = 0; k < itemsDataGridView.Rows.Count - 1; k++)
                itemIDComboBox.Items.Add(itemsDataGridView.Rows[k].Cells[0].Value);

            itemAmountTextBox.KeyPress += Helper.CheckNumber;
            Toggle();
        }


        private void Toggle()
        {
            toggle = !toggle;
            //dealIDTextBox1.Enabled = toggle;
            itemIDComboBox.Enabled = toggle;
            itemAmountTextBox.Enabled = toggle;
            button9.Enabled = toggle;
            button10.Enabled = toggle;
            button11.Enabled = toggle;
            button12.Enabled = toggle;
            button13.Enabled = toggle;
            button14.Enabled = toggle;
            button15.Enabled = toggle;
            button16.Enabled = toggle;
            dealItemsDataGridView.Visible = toggle;
            dealIDTextBox1.Text = dealIDTextBox.Text;

            dealIDTextBox.Enabled = !toggle;
            dealBranchIDComboBox.Enabled = !toggle;
            dealBuyerIDComboBox.Enabled = !toggle;
            //dealDateDateTimePicker.Enabled = !toggle;
            dealPayedCheckBox.Enabled = !toggle;
            button7.Enabled = !toggle;
            button8.Enabled = !toggle;
            button1.Enabled = !toggle;
            button2.Enabled = !toggle;
            button3.Enabled = !toggle;
            button4.Enabled = !toggle;
            button5.Enabled = !toggle;
            button6.Enabled = !toggle;

            button17.Text = toggle ? "ערוך עסקה" : "ערוך מוצרים של העסקה";

            DataView dv = (DataView)dealItemsDataGridView.DataSource;
            dv.RowFilter = "DealId = " + dealIDTextBox.Text ;
            dealItemsDataGridView.DataSource = dv;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            dealBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dealBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dealBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dealBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dealBindingSource.AddNew();
            dealIDTextBox.Text = (this.eBuyDataSet.Deal.Rows.Count + 1).ToString();
            button8.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dealDateDateTimePicker.Value < DateTime.Now)
                return;
            dealBindingSource.EndEdit();
            dealTableAdapter.Update(this.eBuyDataSet.Deal);
            button8.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            dealBindingSource.EndEdit();
            dealTableAdapter.Update(this.eBuyDataSet.Deal);
            button8.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dealDateDateTimePicker.Value = DateTime.Now;
        }

        private void button17_Click(object sender, EventArgs e) => Toggle();

    }
}
