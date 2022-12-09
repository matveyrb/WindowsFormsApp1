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
                labelName = textBox6.Text,
                foundingDate = dateTimePicker1.Value.ToString("yyyy-MM-dd")
            };

            info birth = new info();
            birth.place = textBox4.Text;
            birth.yearOfBirth = int.Parse(textBox5.Text);
            richTextBox1.Text += $"Место рождения артиста: {birth.place} \nДата рождения артиста: {birth.yearOfBirth} \n\n";
            richTextBox2.Text += $"Название лейбла: {property.labelName} \nДата основания: {property.foundingDate} \n\n";

            richTextBox1.Text += $" Имя артиста: {property.name} \n Название песни: {property.song} \n Год выпуска: {property.issue} \n Жанр песни: {property.genre} \n\n";
            if(textBox3.Text == String.Empty)
            {
                Music playlist = new Music("Нет имени артиста\n", "Нет названия песни\n");
                richTextBox1.Text = playlist.name;
             }
            if (textBox2.Text == String.Empty)
            {
                Music playlist = new Music("Нет имени артиста\n", "Нет названия песни\n");
                richTextBox1.Text = playlist.song;
            }
            if (comboBox1.Text == String.Empty)
            {
                Music playlist = new Music("Нет имени артиста\n", "Нет названия песни\n");
                richTextBox1.Text = playlist.genre;
            }
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
            richTextBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var property = new Music();
            richTextBox1.Text += $" Hashcode равен: {property.GetHashCode()}\n"; 
        }
        List<Music> msc = new List<Music>();
        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Music.BackColor;
            Font = Music.FontText;
            msc.Add(new Music("Алла Пугачева", "Миллион алых роз","1", DateTime.Parse("2022-07-05")));
            listBox1.DataSource = msc;
            listBox1.DisplayMember = "number";
            textBox8.DataBindings.Add("Text", msc, "name");
            textBox9.DataBindings.Add("Text", msc, "song");
            textBox10.DataBindings.Add("Text", msc, "genre");
            textBox7.DataBindings.Add("Text", msc, "number");
            dateTimePicker2.DataBindings.Add("Value", msc, "foundingDate");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            msc.Add(new Music() {name = textBox3.Text, song = textBox2.Text, number = textBox11.Text, foundingDate = dateTimePicker1.Value.ToString()});
            listBox1.DataSource = null;
            listBox1.DataSource = msc;
            listBox1.DisplayMember = "number";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Music pht = new Music(openFileDialog1.FileName);
                pht.ShowPhoto(pictureBox1);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
