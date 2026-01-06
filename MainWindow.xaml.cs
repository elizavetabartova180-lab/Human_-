using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Human_Бартова.Classes;

namespace Human_Бартова
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MediaPlayer MediaPlayer = new MediaPlayer();
        private Classes.Russian Russian = new Classes.Russian("Александр", @"C:\Users\ADMIN\Downloads\Human_--master\Human_--master\Images\ic_russian.png");
        private Classes.English English = new Classes.English("Alex", @"C:\Users\ADMIN\Downloads\Human_--master\Human_--master\Images\ic_english.png");
        public MainWindow()
        {
            InitializeComponent();
            parent.Children.Add(new Elements.Item(Russian));
            parent.Children.Add(new Elements.Item(English));
        }
    }
}
