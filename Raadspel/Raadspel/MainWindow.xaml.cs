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

namespace Raadspel
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
    }
}
