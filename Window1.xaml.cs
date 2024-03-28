using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace avtorisation
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1(string role)
        {
            InitializeComponent();
            if (role == "TheMostSuccsesfullProgrammerInTheWorld")
            {
                Photo.Source = new BitmapImage(new Uri(@"C:\Users\Пользователь\Downloads\avtorisation-master\avtorisation-master\bin\Debug\Photo\maxresdefault.jpg"));
                name.Text = "Cutie pretty cute";
                post.Text = "programmer";

            }
            else if (role == "TheQueenOfClean")
            {
                Photo.Source = new BitmapImage(new Uri(@"C:\Users\Пользователь\Downloads\avtorisation-master\avtorisation-master\bin\Debug\Photo\FKEY-Anime-Artist-artist-art-девушка-7501668.jpeg"));
                name.Text = "Killing Luboff";
                post.Text = "cleaner";
            }
        }
    }
}
