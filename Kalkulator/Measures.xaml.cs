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
using System.Text.RegularExpressions;

namespace Kalkulator
{
    /// <summary>
    /// Logika interakcji dla klasy Measures.xaml
    /// </summary>
    public partial class Measures : Page
    {


        public Measures()
        {
            InitializeComponent();

            Me meter = new Me();
            meter.name = "Meter";
            meter.p = 1;
            Me kilometer = new Me();
            kilometer.name = "Kilometer";
            kilometer.p = 1000;
            Me decimeter = new Me();
            decimeter.name = "Decimeter";
            decimeter.p = 0.1;
            Me centymeter = new Me();
            centymeter.name = "Centymeter";
            centymeter.p = 0.01;
            Me millimeter = new Me();
            millimeter.name = "Millimeter";
            millimeter.p = 0.001;
            Me inch = new Me();
            inch.name = "Inch";
            inch.p = 0.0254;
            Me foot = new Me();
            foot.name = "Foot";
            foot.p = 0.3048;
            Me yard = new Me();
            yard.name = "Yard";
            yard.p = 0.9144;
            Me mile = new Me();
            mile.name = "Mile";
            mile.p = 1609.344;

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

        private void ButtonCount_Click(object sender, RoutedEventArgs e)
        {
            object Combo1 = ComboBox_1.SelectedItem;
            object Combo2 = ComboBox_2.SelectedItem;

            String Combo_1 = Combo1.ToString();
            String Combo_2 = Combo2.ToString();

            
        }
    }
}
