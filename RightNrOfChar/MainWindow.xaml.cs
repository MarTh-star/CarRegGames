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

namespace RightNrOfChar
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

        public void checkRight(string inputText)
        {
            if (inputText.Length == 7 && Char.IsWhiteSpace(inputText[3]))
            {
                MessageBox.Show("The sign has the right amount of characters and format.");
            } 
            else
            {
                MessageBox.Show("The sign has the wrong amount of characters and/or wrong format.");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            checkRight(inputBox.Text);
        }
    }
}
