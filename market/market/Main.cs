using BLmarket;
using DBData;
using UImarket;

namespace market
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();            
            dataGridView1.DataSource = new BL().FromDBToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddProduct().Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AddMarket().Show();
            this.Hide();
        }
        public  void SelectedRow(object sender, EventArgs e)
        {
           dataGridView2.DataSource=BL.SelectedRowToList(dataGridView1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.Show();
            this.Hide();
            if (BL.SelectedRowToList(dataGridView2).Count ==1)
            {   edit.id = BL.SelectedRowToList(dataGridView2)[0].ID;
                edit.textBox5.Text = BL.SelectedRowToList(dataGridView2)[0].PrdName;
                edit.textBox7.Text = BL.SelectedRowToList(dataGridView2)[0].MUnit;
                edit.textBox3.Text = BL.SelectedRowToList(dataGridView2)[0].Price;
                edit.textBox10.Text = BL.SelectedRowToList(dataGridView2)[0].Rem;
                edit.textBox6.Text = BL.SelectedRowToList(dataGridView2)[0].MarketID.ToString();           
            } 
            else
            {
                edit.Hide();
                this.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (BL.SelectedRowToList(dataGridView2).Count == 1)
            {
                BL.DeleteSelectedRow(dataGridView2);
                dataGridView1.DataSource = new BL().FromDBToList();
                dataGridView2.DataSource = "";
            }      
        }
      

        private void button8_Click_1(object sender, EventArgs e)
        {
            new AllMarkets().Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          comboBox1.DataSource = BL.MarketsFromDBToList();
        }
    }
}