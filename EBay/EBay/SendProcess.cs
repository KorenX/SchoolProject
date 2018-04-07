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
    public partial class SendProcess : Form
    {
        List<List<string>> items = new List<List<string>>();
        public SendProcess()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) => new Senders().ShowDialog();

        private void button3_Click(object sender, EventArgs e) => new Deals().ShowDialog();

        private void button4_Click(object sender, EventArgs e) => new Items().ShowDialog();

        private void button5_Click(object sender, EventArgs e) => new Buyers().ShowDialog();

        private void button1_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {//מספר עסקה שם סניף
            Pen p = new Pen(Brushes.Indigo, 2.5f);
            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Ariel", 20,
            FontStyle.Bold), Brushes.Black, new Point(0, 0));

            e.Graphics.DrawString("דוח משלוחים בתהליך", new Font("Ariel", 30, FontStyle.Bold), p.Brush,
            new Point(150, 100));
            e.Graphics.DrawLine(p, new Point(150, 150), new Point(575, 150));

            int i = 300;
            p = new Pen(Brushes.Black, 1.5f);
            foreach (List<string> l in items)
            {
                /*
                nice but unfitting code
                
                int n = 0;
                foreach (string s in l)
                {
                    e.Graphics.DrawString(s, new Font("Ariel", 24, FontStyle.Regular), Brushes.Black,
                    new Point(150 + n * 150, i));
                    n++;
                }*/


                //nice print dumb code

                e.Graphics.DrawString(l[0], new Font("Ariel", 24, FontStyle.Regular), Brushes.Black,
                    new Point(150 , i));
                e.Graphics.DrawString(l[1], new Font("Ariel", 24, FontStyle.Regular), Brushes.Black,
                    new Point(250, i));
                e.Graphics.DrawString(l[2], new Font("Ariel", 24, FontStyle.Regular), Brushes.Black,
                    new Point(600, i));


                e.Graphics.DrawLine(p, new Point(150, i + 50), new Point(900, i + 50));
                i += 100;
            }
        }

        private void SendProcess_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eBuyDataSet.Senders' table. You can move, or remove it, as needed.
            this.sendersTableAdapter.Fill(this.eBuyDataSet.Senders);
            // TODO: This line of code loads data into the 'eBuyDataSet.Branches' table. You can move, or remove it, as needed.
            this.branchesTableAdapter.Fill(this.eBuyDataSet.Branches);
            // TODO: This line of code loads data into the 'eBuyDataSet.Deal' table. You can move, or remove it, as needed.
            this.dealTableAdapter.Fill(this.eBuyDataSet.Deal);

            List<string> l1 = new List<string>();
            l1.Add("הזמנה");
            l1.Add("סניף");
            l1.Add("שליח");
            items.Add(l1);

            for (int i = 0; i < dealDataGridView.Rows.Count - 1; i++)
            {
                if (!(bool)dealDataGridView.Rows[i].Cells[7].Value)
                {
                    List<string> l = new List<string>();
                    l.Add(dealDataGridView.Rows[i].Cells[0].Value.ToString());
                    DataView dv = new DataView(eBuyDataSet.Branches);
                    dv.RowFilter = "BranchID="+ dealDataGridView.Rows[i].Cells[3].Value.ToString();
                    branchesDataGridView.DataSource = dv;
                    l.Add(branchesDataGridView.Rows[0].Cells[1].Value.ToString());
                    
                    try
                    {
                        int senderid = int.Parse(dealDataGridView.Rows[i].Cells[3].Value.ToString());
                        dv = new DataView(eBuyDataSet.Senders);
                        dv.RowFilter = "SenderID=" + senderid;
                        sendersDataGridView.DataSource = dv;
                        l.Add(sendersDataGridView.Rows[0].Cells[1].Value.ToString());
                    }
                    catch(Exception ex)
                    {
                        l.Add("אין");
                    }
                    items.Add(l);

                }
            }
        }

        private void dealBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dealBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eBuyDataSet);

        }
    }
}
