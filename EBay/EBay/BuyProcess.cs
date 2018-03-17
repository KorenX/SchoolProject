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
    public partial class BuyProcess : Form
    {
        public BuyProcess()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) => new Buyers().ShowDialog();

        private void button2_Click(object sender, EventArgs e) => new Items().ShowDialog();

        private void button3_Click(object sender, EventArgs e) => new Creators().ShowDialog();

        private void button4_Click(object sender, EventArgs e) => new Importers().ShowDialog();

        private void button5_Click(object sender, EventArgs e) => new Category().ShowDialog();

        private void button6_Click(object sender, EventArgs e) => new Countries().ShowDialog();

        private void button7_Click(object sender, EventArgs e) => new Branches().ShowDialog();

        private void button8_Click(object sender, EventArgs e) => new Deals().ShowDialog();

        
    }
}
