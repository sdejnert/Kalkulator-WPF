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

namespace Kalkulator
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BC_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new BasicCalc();
            newForm.Show();
            this.Close();
        }

        private void BMI_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new BMI();
            newForm.Show();
            this.Close();
        }

        private void DC_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CMeWe_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
