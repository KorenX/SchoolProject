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
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
        }

        private void itemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eBuyDataSet);

        }

        private void Items_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eBuyDataSet.Importers' table. You can move, or remove it, as needed.
            this.importersTableAdapter.Fill(this.eBuyDataSet.Importers);
            // TODO: This line of code loads data into the 'eBuyDataSet.Creators' table. You can move, or remove it, as needed.
            this.creatorsTableAdapter.Fill(this.eBuyDataSet.Creators);
            // TODO: This line of code loads data into the 'eBuyDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.eBuyDataSet.Categories);
            // TODO: This line of code loads data into the 'eBuyDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.eBuyDataSet.Items);


            //implemented for loop for the sake of my senity (something had gone wrong and I thought it would save it. It didn't :<)
            int i = 0, j = 0;
            while(true)
            {
                if (j == creatorsDataGridView.Rows.Count-1)
                    goto a;
                creatorIDComboBox.Items.Add(creatorsDataGridView.Rows[j].Cells[0].Value);
                j++;
            }
            a:
            while (true)
            {
                if (i == categoriesDataGridView.Rows.Count-1)
                    goto b;
                categoryComboBox.Items.Add(categoriesDataGridView.Rows[i].Cells[0].Value);
                i++;
            }
            b:
            for (int k = 0; k < importersDataGridView.Rows.Count-1; k++)
                importIDComboBox.Items.Add(importersDataGridView.Rows[k].Cells[0].Value);
            //trying to show the name but have ID as Value, ask Inna 

            itemNameTextBox.KeyPress += Helper.CheckNameWord;
            itemDiscriptionTextBox.KeyPress += Helper.CheckNameNumberWord;
            itemCostTextBox.KeyPress += Helper.CheckNumber;
            itemQuantityTextBox.KeyPress += Helper.CheckNumber;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            itemsBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            itemsBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            itemsBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            itemsBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            itemsBindingSource.AddNew();
            itemIDTextBox.Text = (this.eBuyDataSet.Items.Rows.Count + 1).ToString();
            button8.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            itemsBindingSource.EndEdit();
            itemsTableAdapter.Update(this.eBuyDataSet.Items);
            button8.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            itemsBindingSource.EndEdit();
            itemsTableAdapter.Update(this.eBuyDataSet.Items);
            button8.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            itemNameTextBox.Text = "";
            itemDiscriptionTextBox.Text = "";
            categoryTextBox.Text = "";
            creatorIDTextBox.Text = "";
            importIDTextBox.Text = "";
            itemCostTextBox.Text = "";
            itemQuantityTextBox.Text = "";
            itemPicTextBox.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(this.eBuyDataSet.Items);
                dv.RowFilter = "ItemName Like '%" + textBox1.Text + "%' OR ItemID = " + int.Parse(textBox1.Text);
                itemsDataGridView.DataSource = dv;
            }
            catch (Exception)
            {
                DataView dv = new DataView(this.eBuyDataSet.Items);
                dv.RowFilter = "ItemName Like '%" + textBox1.Text + "%'";
                itemsDataGridView.DataSource = dv;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            itemsDataGridView.DataSource = new DataView(this.eBuyDataSet.Items);
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(this.eBuyDataSet.Items);
            dv.RowFilter = "Category Like '%" + textBox2.Text + "%'";
            itemsDataGridView.DataSource = dv;
        }
    }
}
