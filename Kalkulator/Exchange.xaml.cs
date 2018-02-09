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
using System.Text.RegularExpressions;

namespace Kalkulator
{

    /// <summary>
    /// Logika interakcji dla klasy Exchange.xaml
    /// </summary>
    public partial class Exchange : Window
    {
        double c1;
        double c2;
        double score;
        String Combo_1;
        String Combo_2;
        String quantity_String;
        double quantity;

        WebClient webClinet = new WebClient();

        public Exchange()
        {
            InitializeComponent();
            ComboBox_1.Items.Add("USD");
            ComboBox_2.Items.Add("USD");
            ComboBox_1.Items.Add("EUR");
            ComboBox_2.Items.Add("EUR");
            ComboBox_1.Items.Add("CAD");
            ComboBox_2.Items.Add("CAD");
            ComboBox_1.Items.Add("RUB");
            ComboBox_1.Items.Add("HRK");
            ComboBox_1.Items.Add("SEK");
            ComboBox_1.Items.Add("NOK");
            ComboBox_1.Items.Add("GBP");
            ComboBox_1.Items.Add("AUD");
            ComboBox_1.Items.Add("CNY");
            ComboBox_1.Items.Add("CHF");
            ComboBox_2.Items.Add("RUB");
            ComboBox_2.Items.Add("HRK");
            ComboBox_2.Items.Add("SEK");
            ComboBox_2.Items.Add("NOK");
            ComboBox_2.Items.Add("GBP");
            ComboBox_2.Items.Add("AUD");
            ComboBox_2.Items.Add("CNY");
            ComboBox_2.Items.Add("CHF");
            ComboBox_1.Items.Add("PLN");
            ComboBox_2.Items.Add("PLN");

        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }


        private void ComboBox_1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            object ObjectCombo1 = ComboBox_1.SelectedItem;
            Combo_1 = ObjectCombo1.ToString();
            if (Combo_1 != "PLN")
            {
                var html1 = webClinet.DownloadString("http://api.nbp.pl/api/exchangerates/rates/A/" + Combo_1 + "/?format=json");
                dynamic currency_1 = JsonConvert.DeserializeObject(html1);
                var name = currency_1["code"].ToString();
                var mid_1 = currency_1["rates"][0]["mid"].ToString("0.##");
                TextBlock_1.Text = "1 " + name + " = " + mid_1 + " PLN.";
            }
            else
            {
                TextBlock_1.Text = "";
            }
        }

        private void ComboBox_2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object ObjectCombo2 = ComboBox_2.SelectedItem;
            Combo_2 = ObjectCombo2.ToString();
            if (Combo_2 != "PLN")
            {
                var html2 = webClinet.DownloadString("http://api.nbp.pl/api/exchangerates/rates/A/" + Combo_2 + "/?format=json");
                dynamic currency_2 = JsonConvert.DeserializeObject(html2);
                var name = currency_2["code"].ToString();
                var mid_2 = currency_2["rates"][0]["mid"].ToString("0.##");
                TextBlock_2.Text = "1 " + name + " = " + mid_2 + " PLN.";
            }
            else
            {
                TextBlock_2.Text = "";
            }

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            var newFoam = new MainWindow();
            newFoam.Show();
            this.Close();
        }

        private void Counting(double c1, double c2, double q)
        {
            score = c1 / c2 * q;
        }

        private void ButtonCount_Click(object sender, RoutedEventArgs e)
        {
            var html1 = "";
            var html2 = "";
            dynamic currency_1;
            dynamic currency_2;
            var mid_1 = "";
            var mid_2 = "";
            if (Combo_1 != "PLN")
            {
                html1 = webClinet.DownloadString("http://api.nbp.pl/api/exchangerates/rates/A/" + Combo_1 + "/?format=json");
                currency_1 = JsonConvert.DeserializeObject(html1);
                mid_1 = currency_1["rates"][0]["mid"].ToString();
            }
            else
            {
                mid_1 = "1";
            }
            if (Combo_2 != "PLN")
            {
                html2 = webClinet.DownloadString("http://api.nbp.pl/api/exchangerates/rates/A/" + Combo_2 + "/?format=json");
                currency_2 = JsonConvert.DeserializeObject(html2);
                mid_2 = currency_2["rates"][0]["mid"].ToString();
            }
            else
            {
                mid_2 = "1";
            }
            quantity_String = TextBox_1.Text;
            if(quantity_String == "")
            {
                MessageBox.Show("Enter the quantity", "Error");
            }
            else
            {
                quantity = Double.Parse(quantity_String);

                c1 = Double.Parse(mid_1);
                c2 = Double.Parse(mid_2);

                Counting(c1, c2, quantity);
                TextBox_2.Text = score.ToString("0.##");
            }
        }

    }
}
