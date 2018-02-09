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
using System.IO;
using Newtonsoft.Json;



namespace Kalkulator
{

    /// <summary>
    /// Logika interakcji dla klasy Distance.xaml
    /// </summary>
    public partial class Distance : Window
    {
        static double pi = 3.1416;
        double x2;
        double x1;
        double y1;
        double y2;
        double score;
        String html1 = "";
        String html2 = "";
        String City_1_Name;
        String City_2_Name;
        String scoreString;

        public Distance()
        {
            InitializeComponent();
        }
            
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var newFoam = new MainWindow();
            newFoam.Show();
            this.Close();
        }

        public static bool CheckForInternetConnection()
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

        private void Connecting(String City1, String City2)
        {
            WebClient webclient = new WebClient();
            try
            {
                html1 = webclient.DownloadString("https://maps.googleapis.com/maps/api/geocode/json?address=" + City1 + ",PL&key=AIzaSyA9f9cIFs_Uzp66XfOs_b3xgp_cqs8Ge60");
                html2 = webclient.DownloadString("https://maps.googleapis.com/maps/api/geocode/json?address=" + City2 + ",PL&key=AIzaSyC-dc_cDkVYe_NqB3yHkalfZbZqkuHsrwY");
            }
            catch (WebException e)
            {
                MessageBox.Show("Can't connect with server!", "Error");
            } 
        }

        private void Counting(double x1, double y1, double x2, double y2)
        {

            score = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((Math.Cos((x1 * pi)/180) * (y2 - y1)), 2)) * 40075.704 / 360;
            scoreString = score.ToString("#.##");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            City_1_Name = City1TextBox.Text;
            City_2_Name = City2TextBox.Text;
            if(City_1_Name == "")
            {
                MessageBox.Show("Please enter a name of city 1", "Error!");
            }
            else
            {
                if(City_2_Name == "")
                {
                    MessageBox.Show("Please enter a name of city 2", "Error!");
                }
                else
                {
                    Connecting(City_1_Name, City_2_Name);

                    dynamic data1 = JsonConvert.DeserializeObject(html1);
                    dynamic data2 = JsonConvert.DeserializeObject(html2);
                    try { 
                        var name_1 = data1["results"][0]["address_components"][0]["short_name"].ToString();
                        var name_2 = data2["results"][0]["address_components"][0]["short_name"].ToString();

                        var x1_String = data1["results"][0]["geometry"]["location"]["lat"].ToString();
                        var y1_String = data1["results"][0]["geometry"]["location"]["lng"].ToString();
                        var x2_String = data2["results"][0]["geometry"]["location"]["lat"].ToString();
                        var y2_String = data2["results"][0]["geometry"]["location"]["lng"].ToString();
                        x1 = Double.Parse(x1_String);
                        x2 = Double.Parse(x2_String);
                        y1 = Double.Parse(y1_String);
                        y2 = Double.Parse(y2_String);

                        Counting(x1, y1, x2, y2);
                        ScoreTextBlock.Text = "From " + name_1 + " to " + name_2 + " is " + scoreString + " km in streight line.";
                    }

                    catch(ArgumentException)
                    {
                        MessageBox.Show("Can't connect with server!", "Error");
                    }

                }
            }           
        }
    }
}
