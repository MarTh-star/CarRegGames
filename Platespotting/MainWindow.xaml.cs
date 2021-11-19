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

namespace Platespotting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        SaveTheNumber save = new SaveTheNumber();
        private static string GetRandomLetters()
        {
            Random r = new Random();
            string okLetters = "ABCDEFGHJKLMNPRSTUWXYX";
            string letters = "";
            for (int i = 0; i < 3; i++)
            {
                int index = r.Next(okLetters.Length);
                letters += okLetters[index].ToString();
            }
            return letters;
        }

        private static string GetRandomNumbers()
        {
            Random n = new Random();
            string numbers = "";
            for (int i = 0; i < 3; i++)
            {
                numbers += n.Next(0, 9);
            }
 
            return numbers;
        }

        private void plateButton_Click(object sender, RoutedEventArgs e)
        {
            regNrBox.Content = GetRandomLetters() + " " + GetRandomNumbers();
            save.IsNrGood(regNrBox.Content.ToString());
            savedNr.Text = save.currentRegNumber;
        }
    }
}
