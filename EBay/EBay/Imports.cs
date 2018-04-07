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
    public partial class Imports : Form
    {
        public Imports()
        {
            InitializeComponent();
        }

        private void importBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.importBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eBuyDataSet);

        }
        bool toggle = true;


        private void Imports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eBuyDataSet.Importers' table. You can move, or remove it, as needed.
            this.importersTableAdapter.Fill(this.eBuyDataSet.Importers);
            // TODO: This line of code loads data into the 'eBuyDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.eBuyDataSet.Items);
            // TODO: This line of code loads data into the 'eBuyDataSet.ImportItems' table. You can move, or remove it, as needed.
            this.importItemsTableAdapter.Fill(this.eBuyDataSet.ImportItems);
            // TODO: This line of code loads data into the 'eBuyDataSet.Import' table. You can move, or remove it, as needed.
            this.importTableAdapter.Fill(this.eBuyDataSet.Import);

            itemAmountTextBox.KeyPress += Helper.CheckNumber;
            itemAmountGotTextBox.KeyPress += Helper.CheckNumber;

            for (int k = 0; k < itemsDataGridView.Rows.Count - 1; k++)
                itemIDComboBox.Items.Add(itemsDataGridView.Rows[k].Cells[0].Value);
            for (int k = 0; k < importersDataGridView.Rows.Count - 1; k++)
                importerIDComboBox.Items.Add(importersDataGridView.Rows[k].Cells[0].Value);

            Toggle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            importBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            importBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            importBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            importBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            importBindingSource.AddNew();
            importIDTextBox.Text = (this.eBuyDataSet.Import.Rows.Count + 1).ToString();
            button8.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            importBindingSource.EndEdit();
            importTableAdapter.Update(this.eBuyDataSet.Import);
            button8.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            importBindingSource.EndEdit();
            importTableAdapter.Update(this.eBuyDataSet.Import);
            button8.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            importItemsBindingSource.MoveFirst();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            importItemsBindingSource.MoveNext();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            importItemsBindingSource.MovePrevious();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            importItemsBindingSource.MoveLast();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            importItemsBindingSource.AddNew();
            importIDTextBox1.Text = importIDTextBox.Text;
            button9.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(itemAmountGotTextBox.Text) > int.Parse(itemAmountTextBox.Text))
                {
                    MessageBox.Show("can't get more than what was requested");
                    return;
                }

                DataView dv = new DataView(eBuyDataSet.DealItems);
                dv.RowFilter = "ItemID=" + itemIDComboBox.SelectedText + " AND ImportID=" + importIDTextBox1.Text;
                dataGridView1.DataSource = dv;
                if (dataGridView1.Rows.Count > 0)
                {
                    MessageBox.Show("ItemID and ImportID combination already exists");
                    return;
                }
                importItemsBindingSource.EndEdit();
                importItemsTableAdapter.Update(this.eBuyDataSet.ImportItems);
                button8.Enabled = false;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("must fill all textboxes");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("something went terribly wrong");
                return;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(itemAmountGotTextBox.Text) > int.Parse(itemAmountTextBox.Text))
                {
                    MessageBox.Show("can't get more than what was requested");
                    return;
                }

                DataView dv = new DataView(eBuyDataSet.DealItems);
                dv.RowFilter = "ItemID=" + itemIDComboBox.SelectedText + " AND ImportID=" + importIDTextBox1.Text;
                dataGridView1.DataSource = dv;
                if (dataGridView1.Rows.Count > 0)
                {
                    MessageBox.Show("ItemID and ImportID combination already exists");
                    return;
                }
                importItemsBindingSource.EndEdit();
                importItemsTableAdapter.Update(this.eBuyDataSet.ImportItems);
                button8.Enabled = false;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("must fill all textboxes");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("something went terribly wrong");
                return;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            itemAmountTextBox.Text = "";
            itemAmountGotTextBox.Text = "";
        }

        private void itemIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(eBuyDataSet.Items);
            dv.RowFilter = "ItemID=" + itemIDComboBox.SelectedItem.ToString();
            itemsDataGridView1.DataSource = dv;
            foreach (DataGridViewRow dr in itemsDataGridView1.Rows)
            {
                try
                {
                    label1.Text = dr.Cells[1].Value.ToString();
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void Toggle()
        {
            toggle = !toggle;
            //dealIDTextBox1.Enabled = toggle;
            itemIDComboBox.Enabled = toggle;
            itemAmountTextBox.Enabled = toggle;
            itemAmountGotTextBox.Enabled = toggle;
            button9.Enabled = toggle;
            button10.Enabled = toggle;
            button11.Enabled = toggle;
            button12.Enabled = toggle;
            button13.Enabled = toggle;
            button14.Enabled = toggle;
            button15.Enabled = toggle;
            button16.Enabled = toggle;
            importItemsDataGridView.Visible = toggle;
            importIDTextBox1.Text = importIDTextBox.Text;

            //importIDTextBox.Enabled = !toggle;
            importerIDComboBox.Enabled = !toggle;
            importPaidCheckBox.Enabled = !toggle;
            importDateDateTimePicker.Enabled = !toggle;
            //dealDateDateTimePicker.Enabled = !toggle;
            button7.Enabled = !toggle;
            button8.Enabled = !toggle;
            button1.Enabled = !toggle;
            button2.Enabled = !toggle;
            button3.Enabled = !toggle;
            button4.Enabled = !toggle;
            button5.Enabled = !toggle;
            button6.Enabled = !toggle;

            button17.Text = toggle ? "ערוך הזמנה" : "ערוך מוצרים של הזמנה";

            DataView dv = new DataView(this.eBuyDataSet.DealItems);
            dv.RowFilter = "DealId = " + importIDTextBox.Text;
            importItemsDataGridView.DataSource = dv;

        }

        private void button17_Click(object sender, EventArgs e) => Toggle();
    }
}
