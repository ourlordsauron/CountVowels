// Author : Derek Worth
// Date   : 09/22/2020
// Project: Count the number of vowels in a specific myString

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CountVowels
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

        private void btnCount_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            int length;
            string myString = txtString.Text;
            
            length = myString.Length;
            
            for (int i = 0; i < length; i++)
            {
                if (myString[i] == 'a' || myString[i] == 'e' || myString[i] == 'i' || myString[i] == 'o' || myString[i] == 'u' ||
                    myString[i] == 'A' || myString[i] == 'E' || myString[i] == 'I' || myString[i] == 'O' || myString[i] == 'U')
                {
                    count++;
                   
                }
            }
            txtCount.Text = Convert.ToString(count);
            btnReset.Visibility = Visibility.Visible;

        }

        private void txtCount_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            btnReset.Visibility = Visibility.Hidden;
            txtString.Text = "";
            txtCount.Text = "";
        }
    }
}
