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

namespace _319481IfChallenges
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

        private void btnNumber_Click(object sender, RoutedEventArgs e)
        {
            int a, b, c;
            int.TryParse(txtNumber.Text, out a);
            int.TryParse(txtOutput.Text, out b);
            int.TryParse(txtNumber2.Text, out c);

            if (a > c)
            {
                if (a > b)
                {
                    Console.WriteLine("{0} is the Greatest number", a);
                }
                else
                {
                    Console.WriteLine("{0} is the Greatest number", b);
                }

            }
            else
            {
                Console.WriteLine("{0} is the Greatest number", c);
            }
            if (a > 0)
            {
                Console.WriteLine("{0} is positive", a);
            }
            else
            {
                if (a == 0)
                {
                    Console.WriteLine("{0} is zero", a);
                }
                else
                {
                    Console.WriteLine("{0} is negative", a);
                }
            }

            if (b > 0)
            {
                Console.WriteLine("{0} is positive", b);
            }
            else
            {
                if (b == 0)
                {
                    Console.WriteLine("{0} is zero", b);
                }
                else
                {
                    Console.WriteLine("{0} is negative", b);
                }
            }
            if (c > 0)
            {
                Console.WriteLine("{0} is positive", c);
            }
            else
            {
                if (c == 0)
                {
                    Console.WriteLine("{0} is zero", c);
                }
                else
                {
                    Console.WriteLine("{0} is negative", c);
                }
            }

            if (a % 2 == 0)
            {
                Console.WriteLine("{0} is an even number", a);
            }
            else
            {
                Console.WriteLine("{0} is an odd number", a);
            }
            if (b % 2 == 0)
            {
                Console.WriteLine("{0} is an even number", b);
            }
            else
            {
                Console.WriteLine("{0} is an odd number", b);
            }
            if (c % 2 == 0)
            {
                Console.WriteLine("{0} is an even number", c);
            }
            else
            {
                Console.WriteLine("{0} is an odd number", c);
            }
            
            if (a % 5 ==0)
            {
                if (a % 11 == 0)
                {
                    Console.WriteLine("{0} is divisible by 5 and 11", a);
                }
                else
                {
                    Console.WriteLine("{0} is divisible by 5", a);
                }
            }
            else
            {
                Console.WriteLine("{0} is not divisible by 5 and 11", a);
            }
            if (b % 5 == 0)
            {
                if (b % 11 == 0)
                {
                    Console.WriteLine("{0} is divisible by 5 and 11", b);
                }
                else
                {
                    Console.WriteLine("{0} is divisible by 5", b);
                }
            }
            else
            {
                Console.WriteLine("{0} is not divisible by 5 and 11", b);
            }
            if (c % 5 == 0)
            {
                if (c % 11 == 0)
                {
                    Console.WriteLine("{0} is divisible by 5 and 11", c);
                }
                else
                {
                    Console.WriteLine("{0} is divisible by 5", c);
                }
            }
            else
            {
                Console.WriteLine("{0} is not divisible by 5 and 11", c);
            }



        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Text = txtInput.Text.ToLower();
            char theLetter = txtInput.Text[0];
            bool isVowel = false;
            if (theLetter == 'a')
            {
                isVowel = true;
            }
            else if (theLetter == 'e')
            {
                isVowel = true;
            }
            else if (theLetter == 'i')
            {
                isVowel = true;
            }
            else if (theLetter == 'o')
            {
                isVowel = true;
            }
            else if (theLetter == 'u')
            {
                isVowel = true;
            }

            if(isVowel)
                {
                    lblOutput.Content = " Vowel";
                }
            else
                {
                    lblOutput.Content = "Consonant";
                }



            }

        private void btnLeapYear_Click(object sender, RoutedEventArgs e)
        {
            int a;
            int.TryParse(txtYear.Text, out a);
            if (a % 4 == 0)
            {
                lblOutput1.Content = " The year is a leap year";
            }
            else
            {
                lblOutput1.Content = "The year is not a leap year";
            }
        }

        private void Character_Click(object sender, RoutedEventArgs e)
        {
            int a;
            int.TryParse(txtYear.Text, out a);
            if (a >= 0)
            { if (a < 0)
                {
                    lblCharacter.Content = "a is a number";
                }
                else
                {
                    {
                        lblCharacter.Content = "a is a letter";
                    }
                }
           
        }
    }
}
