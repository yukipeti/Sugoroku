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

namespace Sugoroku
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
       
        private async void Yes_Click(object sender, RoutedEventArgs e) 
        {
            StartText.Text = "Game Start!";
            await Task.Delay(1000);
            Yes.Visibility = Visibility.Collapsed;
            No.Visibility = Visibility.Collapsed;
            StartText.Visibility = Visibility.Collapsed;
        }
        private void No_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0); //アプリケーションの終了
        }

    }
}
