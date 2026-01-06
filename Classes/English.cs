using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Бартова.Classes
{
    public class English : Human
    {
        private List<Phrase> Phrases { get; set; }
        private int stepAudio;
        private int StepAudio
        {
            get { return stepAudio; }
            set
            {
                stepAudio = value;
                if (stepAudio > Phrases.Count - 1)
                    stepAudio = 0;
            }
        }
        public English(string Name, string Img) : base(Name, Img)
        {
            this.Phrases = AllPhrases();
        }
        public override void Speak(Label Phrase)
        {
            Phrase.Content = Phrases[StepAudio]._Phrase;
            MainWindow.MediaPlayer.Open(new Uri(Phrases[StepAudio].Src));
            MainWindow.MediaPlayer.Play();
            StepAudio++;
        }
        public static List<Phrase> AllPhrases()
        {
            List<Phrase> allPhrases = new List<Phrase>();
            allPhrases.Add(new Phrase("Hello", @"C:\Users\ADMIN\Downloads\Human_--master\Human_--master\Voices\hello_en.mp3"));
            allPhrases.Add(new Phrase("How are you?", @"C:\Users\ADMIN\Downloads\Human_--master\Human_--master\Voices\howareyou_en.mp3"));
            allPhrases.Add(new Phrase("My name is Alexander.", @"C:\Users\ADMIN\Downloads\Human_--master\Human_--master\Voices\mynameis_en.mp3"));
            return allPhrases;
        }
    }
}