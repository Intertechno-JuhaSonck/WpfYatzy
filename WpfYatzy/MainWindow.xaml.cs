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

namespace WpfYatzy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random noppaRandom = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnHeitaNopat_Click(object sender, RoutedEventArgs e)
        {
            btnHeita_Click(btnHeita1, e);
            btnHeita_Click(btnHeita2, e);
            btnHeita_Click(btnHeita3, e);
            btnHeita_Click(btnHeita4, e);
            btnHeita_Click(btnHeita5, e);
            //cbLukitse1.IsChecked = false;
        }

        private void btnHeita_Click(object sender, RoutedEventArgs e)
        {
            if (sender == btnHeita1)
            {
                if (cbLukitse1.IsChecked == false)
                {
                    lblNoppa1.Content = noppaRandom.Next(1, 7).ToString();
                }
            }
            else if (sender == btnHeita2)
            {
                if (cbLukitse2.IsChecked == false)
                {
                    lblNoppa2.Content = noppaRandom.Next(1, 7).ToString();
                }
            }
            else if (sender == btnHeita3)
            {
                if (cbLukitse3.IsChecked == false)
                {
                    lblNoppa3.Content = noppaRandom.Next(1, 7).ToString();
                }
            }
            else if (sender == btnHeita4)
            {
                if (cbLukitse4.IsChecked == false)
                {
                    lblNoppa4.Content = noppaRandom.Next(1, 7).ToString();
                }
            }
            else if (sender == btnHeita5)
            {
                if (cbLukitse5.IsChecked == false)
                {
                    lblNoppa5.Content = noppaRandom.Next(1, 7).ToString();
                }
            }

        }
    }
}
