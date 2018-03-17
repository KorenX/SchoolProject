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
    public partial class ImportProcess : Form
    {
        Dictionary<string, int> items = new Dictionary<string, int>();
        public ImportProcess()
        {
            InitializeComponent();
        }

        private void itemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eBuyDataSet);

        }

        private void ImportProcess_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eBuyDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.eBuyDataSet.Items);
            
            for (int i = 0; i < itemsDataGridView.Rows.Count - 1; i++)
            {
                int a = int.Parse(itemsDataGridView.Rows[i].Cells[9].Value.ToString());
                int b = int.Parse(itemsDataGridView.Rows[i].Cells[7].Value.ToString());
                int sub = a - b;
                if (sub > 0)
                {
                    items.Add(itemsDataGridView.Rows[i].Cells[1].Value.ToString(), sub);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
            printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Pen p = new Pen(Brushes.Indigo, 2.5f);
            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Ariel", 20,
            FontStyle.Bold), Brushes.Black, new Point(0, 0));

            e.Graphics.DrawString("דוח מחסורים במוצרים", new Font("Ariel", 30, FontStyle.Bold), p.Brush,
            new Point(150, 100));
            e.Graphics.DrawLine(p, new Point(150, 150), new Point(575, 150));

            int i = 300;
            p = new Pen(Brushes.Black, 1.5f);
            foreach (KeyValuePair<string,int> it in items)
            {
                e.Graphics.DrawString(it.Key, new Font("Ariel", 24, FontStyle.Regular), Brushes.Black,
                    new Point(150, i));

                e.Graphics.DrawString(it.Value.ToString(), new Font("Ariel",24,FontStyle.Regular), Brushes.Black, 
                    new Point(450,i));

                e.Graphics.DrawLine(p, new Point(150, i+50), new Point(575, i+50));
                i += 100;
            }
        }

        private void button2_Click(object sender, EventArgs e) => new Items().ShowDialog();

        private void button3_Click(object sender, EventArgs e) => new Importers().ShowDialog();
        
    }
}
