using Frazioni;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace somma_list_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fraction f1 = Fraction.Parse(textBox1.Text);
            listBox1.Items.Add(f1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(f1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
