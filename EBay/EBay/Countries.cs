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
    public partial class Countries : Form
    {
        public Countries()
        {
            InitializeComponent();
        }

        private void countriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.countriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eBuyDataSet);

        }

        private void Countries_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eBuyDataSet.Countries' table. You can move, or remove it, as needed.
            this.countriesTableAdapter.Fill(this.eBuyDataSet.Countries);

            countryNameTextBox.KeyPress += Helper.CheckNameWord;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            countriesBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            countriesBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            countriesBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            countriesBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            countriesBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            countriesBindingSource.EndEdit();
            countriesTableAdapter.Update(this.eBuyDataSet.Countries);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            countriesBindingSource.EndEdit();
            countriesTableAdapter.Update(this.eBuyDataSet.Countries);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            countryNameTextBox.Text = "";
        }
    }
}
