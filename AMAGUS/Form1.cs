using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMAGUS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            listBox1.Items.Add("İstanbul");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_lbl_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add("İsmail");
            listBox1.Items.Add("Muhammet");
            listBox1.Items.Add("Efe");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = listBox1.Items[2].ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int count = listBox1.Items.Count;
            MessageBox.Show(count.ToString());


        }

        private void ındex_bul_Click(object sender, EventArgs e)
        {
            int index = listBox1.Items.IndexOf("Muhammet");
            
            if (index == -1)
            {
                MessageBox.Show("Böyle Bir Kişi Bulunmuyor!!");

            }
            else
            {
                MessageBox.Show(index.ToString());
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index;
            MessageBox.Show(listBox1.ToString());
           
            
        }

        private void arama_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string aramayap = arama.Text;
            if (isimBox.Items.Contains(aramayap))
            {
                lbl_arama.Text = aramayap + " Bulundu";
            }
            else
            {
                lbl_arama.Text = aramayap + " Bulunamadı";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Remove("İsmail");
            

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(1);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
