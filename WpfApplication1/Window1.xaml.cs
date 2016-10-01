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
using System.Windows.Shapes;



namespace WpfApplication1
{

    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Wallet wallet = new Wallet();
        
        int winnings;

        Spin pullLever = new Spin();
        

        public Window1()
        {
            InitializeComponent();
        }

        public void playGame()
        {
 

            Rewards.Text = "Winning solutions: \nPicard x3 = Jackpot! bet x 10 \n3 Watermelon = bet x 9 \n3 Strawberries = bet x 8 \n777 = bet x 7 \n3 Pears = bet x 6 \n3 Oranges = bet x 5 \n3 Lemons = bet x 4 \n3 Grapes = bet x 3 \n3 Cherries = bet x 2 \n2 of a kind = 2 \n3 Free Spin = Free Spin";
            WalletDisplay.Content = "Wallet: $0";

        }
            
       

            private void button_Click2(object sender, RoutedEventArgs e)
            {
                Winnings.Visibility = Visibility.Visible;
               
                wallet.fillWallet();
                
         
                Winnings.Content = "You added $50 to your wallet.";
                WalletDisplay.Content = "Wallet: $" + wallet.money;
            }

            private void button_Click3(object sender, RoutedEventArgs e)
            {
                
                Winnings.Visibility = Visibility.Visible;
                wallet.cashOut(wallet.money);
                Winnings.Content = "You cash out with $" + wallet.money;
                wallet.money = 0;
                WalletDisplay.Content = "Wallet: $" + wallet.money;
                
            }


            private void Button_Click(object sender, RoutedEventArgs e)
            {
                Winnings.Visibility = Visibility.Visible;
                winnings = pullLever.getWinnings();
                int roll1 = pullLever.getRoll1();
                int roll2 = pullLever.getRoll2();
                int roll3 = pullLever.getRoll3();
                int value = roll1 + roll2 + roll3;

                
                    if (wallet.money > 0)
                    {

                        if (roll1 == roll2 || roll1 == roll3 || roll3 == roll1)
                        {
                            Winnings.Content = "You rolled a double! Winnings: " + winnings;
                        }

                        if (roll1 == roll2 && roll1 == roll3)
                        {
                            Winnings.Content = "Triple! Winnings: " + winnings;
                        }
                        if (value == 111)
                        {
                            Winnings.Content = "Free Spin!";
                        }

                        else
                        {
                            Winnings.Content = "No match. Winnings: " + winnings;
                        }
                        pullLever.spin(wallet);
                        wallet.money = wallet.money + winnings;
                        WalletDisplay.Content = "Wallet: $" + wallet.money;

                        
                        
                            if (roll1 == 0)
                        {
                            Rect1.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/picard.jpg")));
                            
                        }
                            else if (roll1 == 1)
                            {
                                Rect1.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/Freespin.png")));
                            }
                            else if (roll1 == 2)
                            {
                                Rect1.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/Cherries.png")));
                            }
                            else if (roll1 == 3)
                            {
                                Rect1.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/grape.png")));
                            }
                            else if (roll1 == 4)
                            {
                                Rect1.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/lemon.png")));
                            }
                            else if (roll1 == 5)
                            {
                                Rect1.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/orange.png")));
                            }
                            else if (roll1 == 6)
                            {
                                Rect1.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/pear.png")));
                            }
                            else if (roll1 == 7)
                            {
                                Rect1.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/Seven.png")));
                            }
                            else if (roll1 == 8)
                            {
                                Rect1.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/strawberry.jpg")));
                            }
                            if (roll1 == 9)
                            {
                                Rect1.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/Watermelon.png")));
                            }

                        if (roll2 == 0)
                        {
                            Rect2.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/picard.jpg")));
                        }

                        else if (roll2 == 1)
                        {
                            Rect2.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/Freespin.png")));
                        }
                        else if (roll2 == 2)
                        {
                            Rect2.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/Cherries.png")));
                        }
                        else if (roll2 == 3)
                        {
                            Rect2.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/grape.png")));
                        }
                        else if (roll2 == 4)
                        {
                            Rect2.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/lemon.png")));
                        }
                        else if (roll2 == 5)
                        {
                            Rect2.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/orange.png")));
                        }
                        else if (roll2 == 6)
                        {
                            Rect2.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/pear.png")));
                        }
                        else if (roll2 == 7)
                        {
                            Rect2.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/Seven.png")));
                        }
                        else if (roll2 == 8)
                        {
                            Rect2.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/strawberry.jpg")));
                        }
                        else if (roll2 == 9)
                        {
                            Rect2.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/Watermelon.png")));
                        }


                        if (roll3 == 0)
                        {
                            Rect3.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/picard.jpg")));
                        }
                        else if (roll3 == 1)
                        {
                            Rect3.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/Freespin.png")));
                        }
                        else if (roll3 == 2)
                        {
                            Rect3.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/Cherries.png")));
                        }
                        else if (roll3 == 3)
                        {
                            Rect3.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/grape.png")));
                        }
                        else if (roll3 == 4)
                        {
                            Rect3.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/lemon.png")));
                        }
                        else if (roll3 == 5)
                        {
                            Rect3.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/orange.png")));
                        }
                        else if (roll3 == 6)
                        {
                            Rect3.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/pear.png")));
                        }
                        else if (roll3 == 7)
                        {
                            Rect3.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/Seven.png")));
                        }
                        else if (roll3 == 8)
                        {
                            Rect3.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/strawberry.jpg")));
                        }
                        else if (roll3 == 9)
                        {
                            Rect3.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/Watermelon.png")));
                        }
                        
                    }
                    else
                    {
                        Winnings.Content = "You have no money to bet. Please fill wallet.";
                    }
               
            }
        

    }

 
    

}
