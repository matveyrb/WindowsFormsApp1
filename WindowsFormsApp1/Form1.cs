using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mylibrary;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var property = new Music
            {
                name = textBox3.Text,
                song = textBox2.Text,
                issue = int.Parse(textBox1.Text),
                genre = comboBox1.Text
            };
            richTextBox1.Text += $" Имя артиста: {property.name} \n Название песни: {property.song} \n Год выпуска: {property.issue} \n Жанр песни: {property.genre} \n\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var property = new Music();
            richTextBox1.Text += $" Hashcode равен: {property.GetHashCode()}\n"; 
        }
    }
}
