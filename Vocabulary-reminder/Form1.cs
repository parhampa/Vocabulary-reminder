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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width,
                                   Screen.PrimaryScreen.WorkingArea.Height - this.Height);

            try
            {
                
                int counter = 0;
                string line;
                // Read the file and display it line by line.
                System.IO.StreamReader file =
                   new System.IO.StreamReader("words.txt");
                while ((line = file.ReadLine()) != null)
                {
                    counter++;
                    label1.Text = line;
                }
                
                file.Close();
            }
            catch
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

                int counter = 0;
                string line;
                // Read the file and display it line by line.
                System.IO.StreamReader file =
                   new System.IO.StreamReader("words.txt");
                while ((line = file.ReadLine()) != null)
                {
                    counter++;
                }
                file.Close();

                Random r = new Random();
                int n = r.Next(counter);
                // Read the file and display it line by line.
                System.IO.StreamReader file1 =
                   new System.IO.StreamReader("words.txt");
                for (int i=0;i<n+1;i++)
                {
                    line = file1.ReadLine();
                }
                label1.Text = line;
                file1.Close();
            }
            catch
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2=new Form2();
            f2.ShowDialog();

        }
    }
}