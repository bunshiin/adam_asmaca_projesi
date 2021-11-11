using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMOGUS
{
    public partial class Form1 : Form
    {
        int random_sayi;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        char[] alfabe = new char[29];
        string[] sehirler = new string[5];
        private void Form1_Load(object sender, EventArgs e)
        {
            sehirler[0] = "Sivas";
            sehirler[1] = "Ankara";
            sehirler[2] = "İstanbul";
            sehirler[3] = "Samsun";
            sehirler[4] = "Ağrı";

            
            random_sayi = rand.Next(sehirler.Length);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            alfabe = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ".Trim().ToCharArray();
            for (int i = 0; i < alfabe.Length; i++)
            {
                Button btn = new Button();

                btn.Text = alfabe[i].ToString();
                flowLayoutPanel1.Controls.Add(btn);
                startgame_btn.Enabled = false;
            }
            for (int i = 0; i < sehirler[random_sayi].Length; i++)
            {
                TextBox harf = new TextBox();
                harf.Width = 21;
                harf.Height = 20;
                
                flowLayoutPanel2.Controls.Add(harf);

            }



        }
    }
}
