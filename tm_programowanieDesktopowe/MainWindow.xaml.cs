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

namespace tm_programowanieDesktopowe
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string VLogin { get; set; }
        public string VPassword { get; set; }
        public string TxValue { get; set; }
        public int My_int_value { get; set; }
        public MainWindow()
        {


            InitializeComponent();
            DataContext = this;


        }
        private void Btn_login(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Twój Login to: " + this.VLogin);
        }

        private void Btn_add(object sender, RoutedEventArgs e)
        {
            if (validate_number(this.TxValue))
            {
                MessageBox.Show("Twoja Wartosc to:" + this.My_int_value);
            }
        }
        private bool validate_number(string tekst)
        {
            var isNumber = int.TryParse(tekst, out int number);
            return isNumber;
        }

    }
}