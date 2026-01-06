using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Human_Бартова.Classes
{
     public abstract class Human
    {
        public string Name { get; set; }
        public string Img { get; set; }
        public Human(string Name, string Img)
        {
            this.Name = Name;
            this.Img = Img;
        }
        public abstract void Speak(Label Phrase);
    }
}
