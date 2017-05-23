using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string folder = textBox1.Text;
            Directory.CreateDirectory(folder);
            MessageBox.Show("Folder created : "+ folder);

            File.Create("comment" + new Random().Next(0, 100) + ".txt").Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name = textBox4.Text;
            string surname = textBox3.Text;
            string comment = textBox2.Text;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Path.Combine(textBox1.Text, "comments.txt"), textBox4.Text + " " + textBox3.Text + " : " + textBox2.Text);
            comboBox1.Items.Add(textBox4.Text);
            StreamWriter myStream = new StreamWriter("comment.txt");
            myStream.WriteLine(Path.Combine(textBox1.Text, "comments.txt"),textBox4.Text + " " + textBox3.Text + " : " + textBox2.Text);
            myStream.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
          textBox5.Text = textBox2.Text;
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
