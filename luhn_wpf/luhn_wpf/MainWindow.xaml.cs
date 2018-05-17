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

namespace luhn_wpf
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            gecerli.Visibility = Visibility.Hidden;
            gecersiz.Visibility = Visibility.Hidden;
            Girdi.Focus();
            

        }

        private void Check_Card_Click(object sender, RoutedEventArgs e)
        {
            gecerli.Visibility = Visibility.Hidden;
            gecersiz.Visibility = Visibility.Hidden;
            string girdi = Girdi.Text;
            string yazi=null;
            string a=null, b=null, c=null, d=null;
            char[] cardNums = girdi.ToCharArray();
            if (cardNums.Length != 16)
            {
                MessageBox.Show("Lütfen kart numarasını 16 haneli giriniz", "Uyarı", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                int[] cardNumbers = new int[cardNums.Length];
                for (int i = 0; i < cardNums.Length; i++)
                {
                    cardNumbers[i] = Convert.ToInt32(cardNums[i].ToString());

                }
                for (int j = 0; j < 4; j++)
                {
                    a += cardNums[j].ToString();
                    b += cardNums[j + 4].ToString();
                    c += cardNums[j + 8].ToString();
                    d += cardNums[j + 12].ToString();
                }
                yazi = string.Format("Kart Numaranız: {0} - {1} - {2} - {3}", a, b, c, d);

                girilenKartNo.Text = yazi;
                bool sonuc = false;
                bool son = luhn(cardNumbers, sonuc);
                if (son == true)
                {
                    gecerli.Visibility = Visibility.Visible;
                    MessageBox.Show("Kart Numarası Geçerli!", "Sonuç", MessageBoxButton.OK, MessageBoxImage.Information);                    
                }
                else
                {
                    gecersiz.Visibility = Visibility.Visible;
                    MessageBox.Show("Kart Numarası Geçersiz!", "Sonuç", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
            
           
        }
        public static bool luhn(int[] cardNumbersArray, bool result)
        {
            int singleSum = 0;
            int doubleSum = 0;
            for (int j = 0; j < 8; j++)
            {
                singleSum += cardNumbersArray[2 * j + 1];

                if ((cardNumbersArray[j * 2] * 2) >= 10)
                {
                    doubleSum += cardNumbersArray[j * 2] * 2 - 9;
                }
                else
                {
                    doubleSum += cardNumbersArray[j * 2] * 2;
                }
            }
            int total = singleSum + doubleSum;
            result = (total % 10).Equals(0);
            return result;
        }

        private void Girdi_TextChanged(object sender, TextChangedEventArgs e)
        {
            Girdi.Focus();
        }
    }
}
