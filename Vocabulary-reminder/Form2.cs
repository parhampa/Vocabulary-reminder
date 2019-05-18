using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vocabulary_reminder
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText("words.txt", textBox1.Text);
            MessageBox.Show("Your changes have been saved.");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = System.IO.File.ReadAllText("words.txt");
        }
    }
}
