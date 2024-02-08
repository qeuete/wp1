using System;
using System.Collections.Generic;
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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        List<Button> btn;
        Random random;
        bool isPlayerX;

        public MainWindow()
        {
            InitializeComponent();
            btn = new List<Button> { Button_1, Button_2, Button_3, Button_4, Button_5, Button_6, Button_7, Button_8, Button_9 };
            random = new Random();
            isPlayerX = true;
        }
        private void MakeMove(Button button)
        {
            if (button.IsEnabled)
            {
                button.Content = isPlayerX ? "X" : "O";
                button.IsEnabled = false;

                if (Check())
                {
                    Result();
                }
                else
                {
                    isPlayerX = !isPlayerX; // Switch players
                    if (!isPlayerX)
                    {
                        Random();
                    }
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MakeMove(sender as Button);
        }
        private bool Check()
        {
            int i = 0;
            foreach (Button button in btn)
            {
                if (button.IsEnabled == false)
                {
                    i++;
                }
            }
            if (i == 9)
                return true;
            else
                return false;
        }

        private void Random()
        {
            int i = 0;
            int nomer = random.Next(0, 9);
            if (Check() == true)
            {
                Result();
            }
            else
            {
                while (btn[nomer].IsEnabled == false)
                {
                    nomer = random.Next(0, 9);
                }
                btn[nomer].Content = "O";
                btn[nomer].IsEnabled = false;
            }
        }

        private void Block()
        {
            foreach (Button button in btn)
            {
                button.IsEnabled = false;
            }
        }

        private void Result()
        {
            if (Button_1.Content == "X" && Button_2.Content == "X" && Button_3.Content == "X" || Button_3.Content == "X" && Button_6.Content == "X" && Button_9.Content == "X"
                || Button_7.Content == "X" && Button_8.Content == "X" && Button_9.Content == "X" || Button_1.Content == "X" && Button_4.Content == "X" && Button_7.Content == "X"
                || Button_2.Content == "X" && Button_5.Content == "X" && Button_8.Content == "X" || Button_4.Content == "X" && Button_5.Content == "X" && Button_6.Content == "X"
                || Button_1.Content == "X" && Button_5.Content == "X" && Button_9.Content == "X" || Button_7.Content == "X" && Button_5.Content == "X" && Button_3.Content == "X")
            {
                MessageBox.Show("Вы победили ботяру");
                Block();
            }
            else if (Button_1.Content == "O" && Button_2.Content == "O" && Button_3.Content == "O" || Button_3.Content == "O" && Button_6.Content == "O" && Button_9.Content == "O"
                    || Button_7.Content == "O" && Button_8.Content == "O" && Button_9.Content == "O" || Button_1.Content == "O" && Button_4.Content == "O" && Button_7.Content == "O"
                    || Button_2.Content == "O" && Button_5.Content == "O" && Button_8.Content == "O" || Button_4.Content == "O" && Button_5.Content == "O" && Button_6.Content == "O"
                    || Button_1.Content == "O" && Button_5.Content == "O" && Button_9.Content == "O" || Button_7.Content == "O" && Button_5.Content == "O" && Button_3.Content == "O")
            {
                MessageBox.Show("Ботяра выиграл, анлак))");
                Block();
            }
            else
            {
                MessageBox.Show("Ничья");
                Block();
            }
        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = "X";
            (sender as Button).IsEnabled = false;
            Random();
        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = "X";
            (sender as Button).IsEnabled = false;
            Random();
        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = "X";
            (sender as Button).IsEnabled = false;
            Random();
        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = "X";
            (sender as Button).IsEnabled = false;
            Random();
        }

        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = "X";
            (sender as Button).IsEnabled = false;
            Random();
        }

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = "X";
            (sender as Button).IsEnabled = false;
            Random();
        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = "X";
            (sender as Button).IsEnabled = false;
            Random();
        }

        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = "X";
            (sender as Button).IsEnabled = false;
            Random();
        }

        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = "X";
            (sender as Button).IsEnabled = false;
            Random();
        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            foreach (Button button in btn)
            {
                button.IsEnabled = true;
                button.Content = " ";
            }

            isPlayerX = true; 
        }
    }
}