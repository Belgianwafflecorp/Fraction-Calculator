using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FractionLibrary;

namespace WpfCalculator
{
    public partial class MainWindow : Window
    {
        private Fraction fraction1 = new Fraction();
        private Fraction fraction2 = new Fraction();
        private Fraction result = new Fraction();

        public MainWindow()
        {
            InitializeComponent();

        }


        private void BtnSum_Click(object sender, RoutedEventArgs e)
        {
            @operator.Text = "+";
            finalDenominator.Text = "";
            finalNumerator.Text = "";
            secondNumerator.Visibility = Visibility.Visible;
            secondLine.Visibility = Visibility.Visible;
            secondDenominator.Visibility = Visibility.Visible;
            finalLine.Visibility = Visibility.Visible;
            finalDenominator.Visibility = Visibility.Visible;
            finalNumerator.Visibility = Visibility.Visible;
        }

        private void BtnMin_Click(object sender, RoutedEventArgs e)
        {
            @operator.Text = "-";
            finalDenominator.Text = "";
            finalNumerator.Text = "";
            secondNumerator.Visibility = Visibility.Visible;
            secondLine.Visibility = Visibility.Visible;
            secondDenominator.Visibility = Visibility.Visible;
            finalLine.Visibility = Visibility.Visible;
            finalDenominator.Visibility = Visibility.Visible;
            finalNumerator.Visibility = Visibility.Visible;
        }

        private void BtnMultiply_Click(object sender, RoutedEventArgs e)
        {
            @operator.Text = "x";
            finalDenominator.Text = "";
            finalNumerator.Text = "";
            secondNumerator.Visibility = Visibility.Visible;
            secondLine.Visibility = Visibility.Visible;
            secondDenominator.Visibility = Visibility.Visible;
            finalLine.Visibility = Visibility.Visible;
            finalDenominator.Visibility = Visibility.Visible;
            finalNumerator.Visibility = Visibility.Visible;
        }

        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            @operator.Text = ":";
            finalDenominator.Text = "";
            finalNumerator.Text = "";
            secondNumerator.Visibility = Visibility.Visible;
            secondLine.Visibility = Visibility.Visible;
            secondDenominator.Visibility = Visibility.Visible;
            finalLine.Visibility = Visibility.Visible;
            finalDenominator.Visibility = Visibility.Visible;
            finalNumerator.Visibility = Visibility.Visible;
        }

        private void BtnReciprocal_Click(object sender, RoutedEventArgs e)
        {
            @operator.Text = "-f";
            finalDenominator.Text = "";
            finalNumerator.Text = "";
            secondNumerator.Visibility = Visibility.Collapsed;
            secondLine.Visibility = Visibility.Collapsed;
            secondDenominator.Visibility = Visibility.Collapsed;
            finalLine.Visibility = Visibility.Visible;
            finalDenominator.Visibility = Visibility.Visible;
            finalNumerator.Visibility = Visibility.Visible;
        }

        private void BtnInvert_Click(object sender, RoutedEventArgs e)
        {
            @operator.Text = "1/f";
            finalDenominator.Text = "";
            finalNumerator.Text = "";
            secondNumerator.Visibility = Visibility.Collapsed;
            secondLine.Visibility = Visibility.Collapsed;
            secondDenominator.Visibility = Visibility.Collapsed;
            finalLine.Visibility = Visibility.Visible;
            finalDenominator.Visibility = Visibility.Visible;
            finalNumerator.Visibility = Visibility.Visible;
        }
        
        private void BtnResult_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int numerator1 = Convert.ToInt32(firstNumerator.Text);
                int denominator1 = Convert.ToInt32(firstDenominator.Text);
                fraction1 = new Fraction(numerator1, denominator1);

                if (firstDenominator.Text == "0")
                {
                    throw new ArgumentException("Denominator cannot be zero.");
                }
                else if (@operator.Text == "-f")
                {
                    result = fraction1.Invert();
                }
                else if (@operator.Text == "1/f")
                {
                    result = fraction1.Reciprocal();
                }
                else
                {
                    int numerator2 = Convert.ToInt32(secondNumerator.Text);
                    int denominator2 = Convert.ToInt32(secondDenominator.Text);
                    fraction2 = new Fraction(numerator2, denominator2);


                    if (secondDenominator.Text == "0")
                    {
                        throw new ArgumentException("Denominator cannot be zero.");
                    }
                    else if (@operator.Text == "+")
                    {
                        result = fraction1.Add(fraction2);
                    }
                    else if (@operator.Text == "-")
                    {
                        result = fraction1.Subtract(fraction2);
                    }
                    else if (@operator.Text == "x")
                    {
                        result = fraction1.Multiply(fraction2);
                    }
                    else if (@operator.Text == ":")
                    {
                        result = fraction1.Divide(fraction2);
                    }
                }
                @finalNumerator.Text = result.Numerator.ToString();
                if (result.Denominator == 1)
                {
                    finalDenominator.Visibility = Visibility.Collapsed;
                    finalLine.Visibility = Visibility.Collapsed;
                }
                else
                {
                    finalLine.Visibility = Visibility.Visible;
                }
                @finalDenominator.Text = result.Denominator.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}