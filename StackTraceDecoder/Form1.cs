using System;
using System.Windows.Forms;
using Gapotchenko.Eazfuscator.NET.SDK;

namespace StackTraceDecoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = SymbolDecoder.Decode(textBox2.Text, textBox1.Text);
        }
    }
}