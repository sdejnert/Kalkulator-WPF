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
using System.Net;
using Newtonsoft.Json;

namespace Kalkulator
{
    /// <summary>
    /// Logika interakcji dla klasy MeWe.xaml
    /// </summary>
    
    public class Me
    {
        public double p;
        public String name;
    }

    public class We
    {
        public double p;
        public String name;
    }

    public partial class MeWe : Window
    {
        public MeWe()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            var newFoam = new MainWindow();
            newFoam.Show();
            this.Close();
        }

        private void Measures_ButtonButton_Click(object sender, RoutedEventArgs e)
        {
            Frame1.Content = new Measures();
        }

        private void Weights_ButtonButton_Click(object sender, RoutedEventArgs e)
        {
            Frame1.Content = new Weights();
        }
    }
}
