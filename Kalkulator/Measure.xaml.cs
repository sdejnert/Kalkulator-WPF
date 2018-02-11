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
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SQLite;

namespace Kalkulator
{
    /// <summary>
    /// Logika interakcji dla klasy Measure.xaml
    /// </summary>
    public partial class Measure : Window
    {
        SQLiteConnection dbConnection = new SQLiteConnection("Data Source=Measures.db;Version=3;");
        decimal d1;
        decimal d2;
        decimal quantity;
        decimal score;

        String score_string;

        public Measure()
        {
            InitializeComponent();

            ComboBox_1.Items.Add("Millimeter");
            ComboBox_1.Items.Add("Centymeter");
            ComboBox_1.Items.Add("Decimeter");
            ComboBox_1.Items.Add("Meter");
            ComboBox_1.Items.Add("Kilometer");
            ComboBox_1.Items.Add("Inch");
            ComboBox_1.Items.Add("Foot");
            ComboBox_1.Items.Add("Yard");
            ComboBox_1.Items.Add("Mile");
            ComboBox_2.Items.Add("Millimeter");
            ComboBox_2.Items.Add("Centymeter");
            ComboBox_2.Items.Add("Decimeter");
            ComboBox_2.Items.Add("Meter");
            ComboBox_2.Items.Add("Kilometer");
            ComboBox_2.Items.Add("Inch");
            ComboBox_2.Items.Add("Foot");
            ComboBox_2.Items.Add("Yard");
            ComboBox_2.Items.Add("Mile");

        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Counting(decimal d1, decimal d2, decimal quantity)
        {
            score = d1 * quantity / d2;
        }

        private void ButtonCount_Click(object sender, RoutedEventArgs e)
        {
            object Combo1 = ComboBox_1.SelectedItem;
            object Combo2 = ComboBox_2.SelectedItem;

            String Combo_1 = Combo1.ToString();
            String Combo_2 = Combo2.ToString();

            dbConnection.Open();
            string sql1 = "select int from measures WHERE name = '" + Combo_1 + "'";
            string sql2 = "select int from measures WHERE name = '" + Combo_2 + "'";
            SQLiteCommand command1 = new SQLiteCommand(sql1, dbConnection);
            SQLiteCommand command2 = new SQLiteCommand(sql2, dbConnection);
            SQLiteDataReader reader1 = command1.ExecuteReader();
            SQLiteDataReader reader2 = command2.ExecuteReader();
            while (reader1.Read() && reader2.Read())
            {
                dynamic c1 = reader1["int"];
                d1 = c1;
                dynamic c2 = reader2["int"];
                d2 = c2;
            }
            dbConnection.Close();

            String quantityString = TextBox_1.Text;     // pobieranie wartości z TextBox_1 do zmiennej 
            if(quantityString == "")
            {
                MessageBox.Show("Enter the quantity!", "Error");
            }
            else
            {
                quantity = Decimal.Parse(quantityString);    // zmiana wartości string na decimal

                Counting(d1, d2, quantity);              // oblicznie 

                score_string = score.ToString("0.########");      // zmiana wartości decimal na string
                TextBox_2.Text = score_string;              // pobieranie wartości ze zeminnej do TextBox_2
            }

        }
    }
}

