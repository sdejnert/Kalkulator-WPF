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
using System.Globalization;

namespace Kalkulator
{
    /// <summary>
    /// Logika interakcji dla klasy BasicCalc.xaml
    /// </summary>
    public partial class BasicCalc : Window
    {
        byte spyMinus = 0;
        String tBox;
        double number = 0;
        double score = 0;
        byte spy;
        public BasicCalc()
        {
            InitializeComponent();
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void BattonBack1_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new MainWindow();
            newForm.Show();
            this.Close();
        }

        private void ButonPlus_Click(object sender, RoutedEventArgs e)
        {
            tBox = CalcTextBox.Text;
            number = Double.Parse(tBox);
            if (spy == 2)
            {
                score = score - number;
                spy = 0;
            }
            else
            {
                if (spy == 3)
                {
                    score = score / number;
                    spy = 0;
                }
                else
                {
                    if(spy == 4)
                    {
                        score = score * number;
                        spy = 0;
                    }
                    else
                    {
                        score = number + score;
                    }



                }
            }
            tBox = score.ToString(CultureInfo.InvariantCulture);
            CalcTextBox.Text = tBox;
            ScoreTextBlock.Text = tBox + " +";
            spy = 1;
            CalcTextBox.SelectAll();
            CalcTextBox.Focus();
        }

        private void ButonMinus_Click(object sender, RoutedEventArgs e)
        {
            tBox = CalcTextBox.Text;
            number = Double.Parse(tBox);
            if (spy == 1)
            {
                score = score + number;
                spy = 0;
            }
            else
            {
                if(spy == 3)
                {
                    score = score / number;
                    spy = 0;
                }
                else
                {
                    if (spyMinus == 0)
                    {
                        score = (score - number)* (-1);
                        spyMinus = 1;
                    }
                    else
                    {
                        if (spy == 4)
                        {
                            score = score * number;
                            spy = 0;
                        }
                        else
                        {
                            score = score - number;
                        }
                    }         
                }
            }
            tBox = score.ToString(CultureInfo.InvariantCulture);
            CalcTextBox.Text = tBox;
            ScoreTextBlock.Text = tBox + " -";
            spy = 2;
            CalcTextBox.SelectAll();
            CalcTextBox.Focus();
        }

        private void ButonDivision_Click(object sender, RoutedEventArgs e)
        {
            tBox = CalcTextBox.Text;
            number = Double.Parse(tBox);
            if ( spy == 1)
            {
                score = score + number;
                spy = 0;
            }
            else
            {
                if(spy == 2)
                {
                    score = score - number;
                    spy = 0;

                }
                else
                {
                    if (spy == 4)
                    {
                        score = score * number;
                        spy = 0;
                    }
                    else
                    {
                        if (spyMinus == 0)
                        {
                            score = number;
                            spyMinus = 1;
                        }
                        else
                        {
                            score = score / number;
                        }
                    }
                }
            }
            tBox = score.ToString(CultureInfo.InvariantCulture);
            CalcTextBox.Text = tBox;
            ScoreTextBlock.Text = tBox + " /";
            spy = 3;
            CalcTextBox.SelectAll();
            CalcTextBox.Focus();
        }

        private void ButonMultiplication_Click(object sender, RoutedEventArgs e)
        {
            tBox = CalcTextBox.Text;
            number = Double.Parse(tBox);
            if(spy == 1)
            {
                score = score + number;
                spy = 0;
            }
            else
            {
                if(spy == 2)
                {
                    score = score - number;
                    spy = 0;
                }
                else
                {
                    if(spy == 3)
                    {
                        score = score / number;
                        spy = 0;
                    }
                    else
                    {
                        if(spyMinus == 0)
                        {
                            score = number;
                            spyMinus = 1;
                        }
                        else
                        {
                            score = score * number;
                        }   
                        
                    }
                }
            }
            tBox = score.ToString(CultureInfo.InvariantCulture);
            CalcTextBox.Text = tBox;
            ScoreTextBlock.Text = tBox + " *";
            spy = 4;
            CalcTextBox.SelectAll();
            CalcTextBox.Focus();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            score = 0;
            number = 0;
            ScoreTextBlock.Text = "0";
            CalcTextBox.Text = "0";
            spyMinus = 0;
            CalcTextBox.SelectAll();
            CalcTextBox.Focus();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tBox = CalcTextBox.Text;
            number = Double.Parse(tBox);
            if (spy == 1)
            {
                score = score + number;
                tBox = score.ToString(CultureInfo.InvariantCulture);
                CalcTextBox.Text = tBox;
                ScoreTextBlock.Text = tBox;

            }
            else
            {
                if (spy == 2)
                {
                    score = score - number;
                    tBox = score.ToString(CultureInfo.InvariantCulture);
                    CalcTextBox.Text = tBox;
                    ScoreTextBlock.Text = tBox;
                }
                else
                {
                    if(spy == 3)
                    {
                        score = score / number;
                        tBox = score.ToString(CultureInfo.InvariantCulture);
                        CalcTextBox.Text = tBox;
                        ScoreTextBlock.Text = tBox;
                    }
                    else
                    {
                        if(spy == 4)
                        {
                            score = score * number;
                            tBox = score.ToString(CultureInfo.InvariantCulture);
                            CalcTextBox.Text = tBox;
                            ScoreTextBlock.Text = tBox;
                        }
                    }
                }
            }
            number = 0;
            spy = 0;
            tBox = score.ToString(CultureInfo.InvariantCulture);
            CalcTextBox.Text = "";
            ScoreTextBlock.Text = tBox;
        }
        
    }
}
