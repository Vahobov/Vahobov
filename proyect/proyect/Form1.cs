using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyect
{
    public partial class Form1 : Form
    {
        Server server;
        Cook cook;
        
        public Form1()
        {
            InitializeComponent();
            server = new Server();
            cook = new Cook();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        int orderCount = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            Cooked = false;
            try
            {
                if (orderCount <= 8)
                {
                    if (comboBox1.Items.Count >null)
                    {
                        server.Receive("Cotumer " + orderCount, new Order(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), comboBox1.SelectedItem.ToString()));
                        label4.Text = server.Inspect();

                    }
                    else
                    {
                        server.Receive("Cotumer " + orderCount, new Order(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), "Not Dring"));
                        label4.Text = server.Inspect();
                    }
                }
                else
                {
                    MessageBox.Show("tanho yak stol ba 8 nafa shishta metoned");

                }
            }
            catch
            {
                MessageBox.Show("Hatolig hatolig???");
            }

            orderCount++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (orderCount > 0)
                {
                    if (!Cooked)
                    {
                        cook.PripareFoot();
                        server.Serve(this);
                        Cooked = true;
                    }
                    else
                    {
                        MessageBox.Show("qayta pshrshni iloji yuq");
                    }
                }
                else
                {
                    MessageBox.Show("pishrish uchun zakaz qlishkerak");
                }
            }
            catch { MessageBox.Show("Hatolig hatolig???"); }
        }

        private void button2_Click(object sender, EventArgs e)
        
        {if (orderCount > 0)
            {
                Cooked = false;
                server.Send();
            }
            else
            {
                MessageBox.Show("menyu dan zakaz qiling");
            }
        }
        bool Cooked = false;
        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
