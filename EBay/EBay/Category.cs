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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eBuyDataSet);

        }

        private void Category_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eBuyDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.eBuyDataSet.Categories);

            categoryNameTextBox.KeyPress += Helper.CheckNameWord;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            categoriesBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            categoriesBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            categoriesBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            categoriesBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            categoriesBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            categoriesBindingSource.EndEdit();
            categoriesTableAdapter.Update(this.eBuyDataSet.Categories);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            categoriesBindingSource.EndEdit();
            categoriesTableAdapter.Update(this.eBuyDataSet.Categories);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            categoryNameTextBox.Text = "";
        }
    }
}
