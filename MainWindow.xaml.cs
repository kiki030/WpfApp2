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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            int number;
            List<int> primes = new List<int>();

            bool isSuccess = int.TryParse(MyTextBox.Text, out number);

            if (!isSuccess)
            {
                MessageBox.Show("請輸入正整數", "錯誤");
            }
            else if (number < 2)
            { 
                MessageBox.Show("請輸入大於等於2的正整數", "錯誤");
            }
            else
            {
                string primeText = $"小於等於{number}的質數有：";
                for (int i = 2; i <= number; i++)
                { 
                    if(IsPrime(i)) primes.Add(i);
                }
                foreach (var p in primes)
                {
                    primeText += p + " ";
                }
                MytextBlock.Text = primeText;
            }
        }

        private bool IsPrime(int p)
        {
            for(int i=2;i<p ;i++)
            {
                if (p % i == 0) return false;
            }
            return true;
        }
    }
}