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
                if (b > c)
                {
                    Console.WriteLine("{0} is the Gretest number", b);
                }
                else
                {
                    Console.WriteLine("{0} is the Gretest number", c);
                }
              
            }
            else
            {
                Console.WriteLine("{0} is the Gretest number", c);
            }
        }
    }
}
