using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        int[] mas = new int[100];
        private void button1_Click(object sender, EventArgs e)
        {
            {
                Random rnd = new Random();
                string i1 = "";
                for (int i = 0; i < 30; i++)
                {
                    mas[i] = rnd.Next(30);
                    i1 = "mas[" + i.ToString() + "] = " + mas[i].ToString();
                    listBox1.Items.Insert(i, i1);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 30; i++)
            {
                if (mas[i] % 7 == 1 || mas[i] % 7 == 2 || mas[i] % 7 == 5)
                {
                    listBox2.Items.Add(mas[i]);
                }
            }
        }
    }

}
