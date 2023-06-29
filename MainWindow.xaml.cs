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
        int PlayerNumber;

        public MainWindow()
        {
            InitializeComponent();

            
        }
        
        private async void Yes_Click(object sender, RoutedEventArgs e) 
        {
            StartText.Text = "Game Start!!!";
            await Task.Delay(1000);
            Yes.Visibility = Visibility.Hidden;
            No.Visibility = Visibility.Hidden;
            StartText.Visibility = Visibility.Hidden;
        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0); //アプリケーションの終了
        }

        //ゲームメイン処理-------------------------------------------------------
        public void GameMain()
        {
            StartText.Text = "さいころを振るか\nアイテムを使用してください";
        }       

        /// <summary>
        /// さいころを振る
        /// </summary>
        /// <returns>1~6の目を返す</returns>
        public int DiceRoll()
        {
            Random random = new Random();

            int dice = random.Next(1, 6); 

            return dice;
        }

        //ゲーム準備-----------------------------------------------------------
        public void GameReady()
        {
            if (PlayerNumber==1)
            {
                Player1.Visibility = Visibility.Visible;
            }
            else if(PlayerNumber==2)
            {
                Player2.Visibility = Visibility.Visible;
            }

        }

        private void DiceRoll_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SelectItem_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}