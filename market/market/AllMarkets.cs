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
using DBData;
using UImarket;

namespace UImarket
{
    public partial class AllMarkets : Form
    {
        public AllMarkets()
        {
            InitializeComponent();
            dataGridView1.DataSource = BL.MarketsFromDBToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new market.Main().Show();
        }
    }
}
