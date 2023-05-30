using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLmarket;

namespace UImarket
{
    public partial class AddMarket : Form
    {
        BL blmarket = new BL();
        public AddMarket()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {          
            blmarket.AddMarketToDB(textBox4.Text);
            textBox4.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new market.Main().Show();
        }
    }
}
