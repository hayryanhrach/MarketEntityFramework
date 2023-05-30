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
using UImarket;

namespace UImarket
{
    public partial class AddProduct : Form
    {
        BL blmarket =new BL();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int producttid = 0;
            if (UIMethods.IsNumber(textBox6.Text))
            {
                producttid = int.Parse(textBox6.Text);
            }
            else
            {
                MessageBox.Show("Կոդը պետք է լինի թիվ");
            }
            blmarket.AddProductToDB(textBox5.Text, textBox7.Text, textBox3.Text, textBox10.Text, producttid);
            textBox5.Clear();
            textBox7.Clear();
            textBox3.Clear();
            textBox10.Clear();
            textBox6.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new market.Main().Show();
        }
    }
}
