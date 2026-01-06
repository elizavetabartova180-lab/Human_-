using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Бартова.Classes
{
    public class Russian : Human
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
        public Russian(string Name, string Img) : base(Name, Img)
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
            allPhrases.Add(new Phrase("Привет", @"C:\Users\ADMIN\Downloads\Human_--master\Human_--master\Voices\привет.mp3"));
            allPhrases.Add(new Phrase("Как дела?", @"C:\Users\ADMIN\Downloads\Human_--master\Human_--master\Voices\ElevenLabs_ Как дела....mp3"));
            allPhrases.Add(new Phrase("Меня зовут Александр.", @"C:\Users\ADMIN\Downloads\Human_--master\Human_--master\Voices\ElevenLabs_ Меня зов....mp3"));
            return allPhrases;
        }
    }
}
