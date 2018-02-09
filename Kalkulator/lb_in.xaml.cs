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
using System.Globalization;
using System.Text.RegularExpressions;

namespace Kalkulator
{
    /// <summary>
    /// Logika interakcji dla klasy lb_in.xaml
    /// </summary>
    public partial class lb_in : Page
    {
        String YourBMI = "Your BMI is:";
        String tBoxWeight;
        String textBmi;
        String tBoxHeight;
        double bmi;
        double height;
        double weight;
        public lb_in()
        {
            InitializeComponent();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void ButtonCalculate_Click_1(object sender, RoutedEventArgs e)
        {
            BMITextBlock.Text = YourBMI;
            tBoxWeight = WBox.Text;
            tBoxHeight = HBox.Text;
            weight = Double.Parse(tBoxWeight);
            height = Double.Parse(tBoxHeight);
            bmi = (weight / (height * height)) * 703;
            Math.Round(bmi, 2);
            textBmi = bmi.ToString("#.##");
            bmiTextBlock.FontSize = 24;
            if (bmi < 18.5)
            {
                comTextBlock.Text = "You are too skinny. Correct BMI is 18.6 - 24.99. Eat more and healthily";
                bmiTextBlock.Foreground = Brushes.Red;
                bmiTextBlock.Text = textBmi;

            }
            else
            {
                if (bmi >= 18.5 && bmi < 25)
                {
                    comTextBlock.Text = "Your weight is correct(18.6 - 24.99";
                    bmiTextBlock.Foreground = Brushes.Green;
                    bmiTextBlock.Text = textBmi;
                }
                else
                {
                    if (bmi >= 25)
                    {
                        comTextBlock.Text = "Your weight is too big. Correct BMI is 18.6 - 24.99. Eat less and healthily";
                        bmiTextBlock.Foreground = Brushes.Red;
                        bmiTextBlock.Text = textBmi;
                    }
                }
            }
        }
    }
}
