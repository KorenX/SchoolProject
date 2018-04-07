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
    public partial class Senders : Form
    {
        public Senders()
        {
            InitializeComponent();
        }

        private void sendersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sendersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eBuyDataSet);

        }

        private void Senders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eBuyDataSet.Senders' table. You can move, or remove it, as needed.
            this.sendersTableAdapter.Fill(this.eBuyDataSet.Senders);

            senderCompanyTextBox.KeyPress += Helper.CheckNameWord;
            senderNameTextBox.KeyPress += Helper.CheckNameWord;
            senderPhoneTextBox.KeyPress += Helper.CheckNumber;
            senderMailTextBox.KeyPress += Helper.CheckNameNumberWordMail;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendersBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sendersBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sendersBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sendersBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sendersBindingSource.AddNew();
            senderIDTextBox.Text = (this.eBuyDataSet.Senders.Rows.Count + 1).ToString();
            button8.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sendersBindingSource.EndEdit();
            sendersTableAdapter.Update(this.eBuyDataSet.Senders);
            button8.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sendersBindingSource.EndEdit();
            sendersTableAdapter.Update(this.eBuyDataSet.Senders);
            button8.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            senderNameTextBox.Text = "";
            senderCompanyTextBox.Text = "";
            senderPhoneTextBox.Text = "";
            senderMailTextBox.Text = "";
        }
    }
}
