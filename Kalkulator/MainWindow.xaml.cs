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
using System.Net;

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
            bool CheckForInternetConnection()
            {
                try
                {
                    using (var client = new WebClient())
                    {
                        using (client.OpenRead("http://clients3.google.com/generate_204"))
                        {
                            return true;
                        }
                    }
                }
                catch
                {
                    return false;
                }
            }
            var newForm = new Distance();
            newForm.Show();
            this.Close();
        }

        private void CMeWe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("this calc doesn't exist");
        }

        private void Ex_Click(object sender, RoutedEventArgs e)
        {
            var newFoam = new Exchange();
            newFoam.Show();
            this.Close();
        }
    }
}
