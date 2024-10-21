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

namespace Lotto
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

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder result = new StringBuilder();
            Random lotto = new Random();
            int getal = 0;
            int lottoNummber;
            result.AppendLine("De zes lotto getallen zijn.");
            result.AppendLine("");
            do
            {
                lottoNummber = lotto.Next(1, 45);
                result.AppendLine($"Getal {getal} is {lottoNummber}.");
                getal++;
            } while (getal < 6);
            resultTextBox.Text = result.ToString();
        }
    }
}