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
    public partial class Creators : Form
    {
        public Creators()
        {
            InitializeComponent();
        }

        private void creatorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.creatorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eBuyDataSet);

        }

        private void Creators_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eBuyDataSet.Countries' table. You can move, or remove it, as needed.
            this.countriesTableAdapter.Fill(this.eBuyDataSet.Countries);
            // TODO: This line of code loads data into the 'eBuyDataSet.Creators' table. You can move, or remove it, as needed.
            this.creatorsTableAdapter.Fill(this.eBuyDataSet.Creators);

            creatorNameTextBox.KeyPress += Helper.CheckNameWord;

            for (int i = 0; i < countriesDataGridView.Rows.Count; i++)
                creatorCountryComboBox.Items.Add(countriesDataGridView.Rows[i].Cells[0].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            creatorsBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            creatorsBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            creatorsBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            creatorsBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            creatorsBindingSource.AddNew();
            creatorIDTextBox.Text = (this.eBuyDataSet.Creators.Rows.Count + 1).ToString();
            button8.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            creatorsBindingSource.EndEdit();
            creatorsTableAdapter.Update(this.eBuyDataSet.Creators);
            button8.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            creatorsBindingSource.EndEdit();
            creatorsTableAdapter.Update(this.eBuyDataSet.Creators);
            button8.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            creatorNameTextBox.Text = "";
            creatorCountryTextBox.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(this.eBuyDataSet.Creators);
                dv.RowFilter = "CreatorName Like '%" + textBox1.Text + "%' OR CreatorID = " + int.Parse(textBox1.Text);
                creatorsDataGridView.DataSource = dv;
            }
            catch (Exception)
            {
                DataView dv = new DataView(this.eBuyDataSet.Creators);
                dv.RowFilter = "CreatorName Like '%" + textBox1.Text + "%'";
                creatorsDataGridView.DataSource = dv;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            creatorsDataGridView.DataSource = new DataView(this.eBuyDataSet.Creators);
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(this.eBuyDataSet.Creators);
            dv.RowFilter = "CreatorCountry Like '%" + textBox2.Text + "%'";
            creatorsDataGridView.DataSource = dv;
        }
        private void button11_Click(object sender, EventArgs e) { }
    }
}

