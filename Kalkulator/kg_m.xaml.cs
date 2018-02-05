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

namespace Kalkulator
{
    /// <summary>
    /// Logika interakcji dla klasy kg_m.xaml
    /// </summary>
    public partial class kg_m : Page
    {
        String tBoxWeight;
        String textBmi;
        String tBoxHeight;
        double bmi;
        double height;
        double weight;
        public kg_m()
        {
            InitializeComponent();
        }


        private void ButtonCalculate_Click_1(object sender, RoutedEventArgs e)
        {
            tBoxWeight = WBox.Text;
            tBoxHeight = HBox.Text;
            weight = Double.Parse(tBoxWeight);
            height = Double.Parse(tBoxHeight);
            height = height / 100;
            bmi = weight / (height * height);
            Math.Round(bmi, 2);
            textBmi = bmi.ToString(CultureInfo.InvariantCulture);
            bmiTextBlock.FontSize = 24;

            if (bmi < 18.5)
            {

                bmiTextBlock.Foreground = Brushes.Red;
                bmiTextBlock.Text = textBmi;

            }
            else
            {
                if(bmi >= 18.5 && bmi < 25)
                {

                    bmiTextBlock.Foreground = Brushes.Green;
                    bmiTextBlock.Text = textBmi;
                }
                else
                {
                    if(bmi >= 25)
                    {

                        bmiTextBlock.Foreground = Brushes.Red;
                        bmiTextBlock.Text = textBmi;
                    }
                }
            }
        }
    }
}
