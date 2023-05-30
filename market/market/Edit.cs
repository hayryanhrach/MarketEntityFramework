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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new market.Main().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int marketid = 0;
            if (UIMethods.IsNumber(textBox6.Text))
            {
                marketid = int.Parse(textBox6.Text);
            }
            else
            {
                MessageBox.Show("Կոդը պետք է լինի թիվ");
            }
            
            if (this.textBox5.Text!=""&& this.textBox7.Text != ""&& this.textBox3.Text != ""&& this.textBox10.Text != ""&& this.textBox6.Text != "")
            {
                BL.EditSelectedRow(id, textBox5.Text, textBox7.Text, textBox3.Text, textBox10.Text, marketid );
                textBox5.Text = "";
                textBox7.Text = "";
                textBox3.Text = "";
                textBox10.Text = "";
                textBox6.Text = "";
            }
        }
    }
}
