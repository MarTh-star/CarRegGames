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

namespace BlackJack
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
        
        public void GetRandomNumbers()
        {
            int[] regNr = new int[3];
            Random n = new Random();
            for (int i = 0; i < 3; i++)
            {
                regNr[i] = n.Next(0, 9);
            }
            lblCode1.Content = regNr[0];
            lblCode2.Content = regNr[1];
            lblCode3.Content = regNr[2];

            if (!(bool)chk1.IsChecked)
            {
                int points1 = Convert.ToInt32(lblCode1.Content) + Convert.ToInt32(lblTotal1.Content);
                lblTotal1.Content = points1;
            }

            if (!(bool)chk2.IsChecked)
            {
                int points2 = Convert.ToInt32(lblCode2.Content) + Convert.ToInt32(lblTotal2.Content);
                lblTotal2.Content = points2;
            }


            if (!(bool)chk3.IsChecked)
            {
                int points3 = Convert.ToInt32(lblCode3.Content) + Convert.ToInt32(lblTotal3.Content);
                lblTotal3.Content = points3;
            }



            }

        private void betButton_Click(object sender, RoutedEventArgs e)
        {
            GetRandomNumbers();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            lblCode1.Content = "0";
            lblCode2.Content = "0";
            lblCode3.Content = "0";

            lblTotal1.Content = "0";
            lblTotal2.Content = "0";
            lblTotal3.Content = "0";

            chk1.IsChecked = false;
            chk2.IsChecked = false;
            chk3.IsChecked = false;

        }
    }
}
