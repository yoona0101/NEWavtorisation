using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
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
using static System.Net.WebRequestMethods;

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
                Photo.Source = new BitmapImage(new Uri(@"C:\Users\Пользователь\Downloads\Без названия.png"));
                name.Text = "Малышко Кьютик Петровна";
                post.Text = "программист";

            }
            else if (role == "TheQueenOfClean")
            {
                Photo.Source = new BitmapImage(new Uri(@"C:\Users\Пользователь\Downloads\avtorisation-master\avtorisation-master\bin\Debug\Photo\FKEY-Anime-Artist-artist-art-девушка-7501668.jpeg"));
                name.Text = "Убийстова Любовь Вячеславовна";
                post.Text = "уборщик";
            }
            
        }
        private void calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime? selectedDate = calendar1.SelectedDate;

            MessageBox.Show(selectedDate.Value.Date.ToShortDateString());
        }

        /*private async void FileOpen(object sender, RoutedEventArgs e, string role)
        {
            if (role == "TheMostSuccsesfullProgrammerInTheWorld")
            {
                /StreamReader sr = new StreamReader("programmer.txt");
                Singleton.programmer = sr.ReadToEnd();/
                string path = "programmer.txt";
                // асинхронное чтение
                using (StreamReader reader = new StreamReader(path))
                {
                    string text = await reader.ReadToEndAsync();
                    text = textFIle.Text;
                }
            }
            else if (role == "TheQueenOfClean")
            {

            }
        }*/

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("В разработке");
        }
    }
}
