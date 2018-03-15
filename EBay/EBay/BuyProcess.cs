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

    }
}
