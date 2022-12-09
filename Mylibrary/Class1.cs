using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mylibrary
{
    public class Music
    {
        public string number { get; set; }
        public string song { get; set; }
        private string Name;
        public string name
        {
            get => Name;
            set
            {
                if ((value != "") && (value[0] == value.ToLower()[0]))
                {
                    Name = value.ToUpper()[0] + value.Substring(1);
                }
                else Name = value;
            }
        }
        private int Issue;
        public int issue
        {
            get 
            {
                return Issue; 
            }
            set
            {
                if (value >= 1980 && value <= 2022) Issue = value;
                else return;
            }
        }
        public string genre { get; } = "Хип хоп";
        public string foundingDate { get; set; }
        public string labelName;
        public string foto;

        public Music() : this("Нет имени артиста", "Нет названия песни")
        { }
        public Music(string addName, string addSong) : this(addName, addSong, 0) 
        { } 
        public Music(string name, string song, int issue)
        {
            this.name = name; this.song = song; this.issue = issue;   
        }
        public Music(string name, string song, string number, DateTime foundingDate)
        {
            this.song = song;
            this.name = name;
            this.number = number;
            this.foundingDate = foundingDate.ToString();
        }
        public Music(string foto)
        {
            this.foto = foto;
        }
        public string area;
        public Boolean typeOfArea;
        public void typeR()
        {
            if (typeOfArea)
            {
                this.area = "Spotify";
            }
            else
                this.area = "Yandex music";
        }
        public void ShowPhoto(PictureBox box)
        {
            Graphics h = Graphics.FromHwnd(box.Handle);
            h.DrawImage(Image.FromFile(this.foto), new Rectangle(0, 0, box.Width, box.Height));
        }

        public static readonly Color BackColor;
        public static readonly Font FontText;
        
       
        static Music()
        {
            DateTime now = DateTime.Now;
            if (now.DayOfWeek == DayOfWeek.Friday || now.DayOfWeek == DayOfWeek.Monday)
            {
                BackColor = Color.Green;
                FontText = new Font("Times New Roman", 10, FontStyle.Bold);
            }
            else
            {
                BackColor = Color.Purple;
                FontText = new Font("Arial", 13, FontStyle.Italic);
            }
        }
        public void WriteFile(string path)
        {
            StreamWriter writer = new StreamWriter(path + ".txt");
            writer.WriteLine("Номер: " + this.number + "\nИмя артиста: " + this.name + "\nНазвание песни: " + this.song + "\nЖанр песни: " +
                this.genre + "Дата выхода: " + this.issue.ToString() + this.area);
        }
    }


    public struct info
    {
        public string place;
        public int yearOfBirth;
    }
}
