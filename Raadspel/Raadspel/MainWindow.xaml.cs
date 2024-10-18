using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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

namespace Raadspel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        Random randomNumber = new Random();
        int winningNumber;
        int tries = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void dateLabel_Loaded(object sender, RoutedEventArgs e)
        {
            DateTime date = DateTime.Now;
            dateLabel.Content = date.ToString("dddd dd MMMM yyyy - HH:mm");
            dateLabel.Foreground = Brushes.Blue;
            dateLabel.FontFamily = new FontFamily("Arial");
            dateLabel.FontSize = 12;
            dateLabel.FontStyle = FontStyles.Italic;
            dateLabel.FontWeight = FontWeights.DemiBold;
        }

        private void endButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void newButton_Click(object sender, RoutedEventArgs e)
        {
            winningNumber = randomNumber.Next(1, 101);
            Console.WriteLine(winningNumber);
            output1TextBox.Clear();
            output1TextBox.Foreground = Brushes.Black;
            output2TextBox.Clear();
            numberTextBox.Clear();
            numberTextBox.Focus();
            tries = 0;
            evaluateButton.IsEnabled = true;
        }

        private void evaluateButton_Click(object sender, RoutedEventArgs e)
        {
            bool isValidInput = int.TryParse(numberTextBox.Text, out int inputNumber);
        
            if (isValidInput && inputNumber > 0 && inputNumber <= 100)
            {
                output1TextBox.Foreground = Brushes.Black;
                if (inputNumber < winningNumber)
                {
                    output1TextBox.Text = "Raad hoger";
                    tries++;
                    output2TextBox.Text = $"Aantal keren geraden: {tries}";
                } 
                else if (inputNumber > winningNumber)
                {
                    output1TextBox.Text = "Raad lager";
                    tries++;
                    output2TextBox.Text = $"Aantal keren geraden: {tries}";
                } 
                else
                {
                    output1TextBox.Text = "Proficiat! U hebt het getal geraden!";
                    tries++;
                    output2TextBox.Text = $"Aantal keren geraden: {tries}";
                    evaluateButton.IsEnabled = false;
                }
            }
            else
            {
                output1TextBox.Text = "Geef een geheel getal tussen 1 en 100.";
                output1TextBox.Foreground = Brushes.Red;
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            winningNumber = randomNumber.Next(1, 101);
            Console.WriteLine(winningNumber);
        }
    }
}
