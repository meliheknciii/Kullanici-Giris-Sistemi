using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox1.Items.Add(textBox2.Text);
            listBox1.Items.Add(maskedTextBox1.Text);
            listBox1.Items.Add(maskedTextBox2.Text);
            comboBox1.Items.Add(textBox3.Text);
            //dateTimePicker1.Text
            MessageBox.Show("Teşekkür Ederiz.");
        }
    }
}
