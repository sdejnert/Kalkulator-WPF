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
using System.Windows.Shapes;

namespace Kalkulator
{
    /// <summary>
    /// Logika interakcji dla klasy BMI.xaml
    /// </summary>
    public partial class BMI : Window
    {
        public BMI()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new MainWindow();
            newForm.Show();
            this.Close();
        }

        private void Kg_MButton_Click(object sender, RoutedEventArgs e)
        {
            Frame1.Content = new kg_m();
        }

        private void lb_inButton_Click(object sender, RoutedEventArgs e)
        {
            Frame1.Content = new lb_in();
        }
    }
}
