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

namespace WpfLab4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rateD.Text);
            double sumDollar = Convert.ToDouble(sumD.Text);
            double resDollar = rateDollar * sumDollar;
            resD.Text = resDollar.ToString();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rateE.Text);
            double sumEuro = Convert.ToDouble(sumE.Text);
            double resEuro = rateEuro * sumEuro;
            resE.Text = resEuro.ToString();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            double rateGrivna = Convert.ToDouble(rateG.Text);
            double sumGrivna = Convert.ToDouble(sumG.Text);
            double resGrivna = rateGrivna * sumGrivna;
            resG.Text = resGrivna.ToString();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            double rateDrama = Convert.ToDouble(rateDr.Text);
            double sumDrama = Convert.ToDouble(sumDr.Text);
            double resDrama = rateDrama * sumDrama;
            resDr.Text = resDrama.ToString();
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            double inch_ = Convert.ToDouble(inch.Text);
            double resInch_ = 0.0254 * inch_;
            resInch.Text = resInch_.ToString();
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            double foot_ = Convert.ToDouble(foot.Text);
            double resFoot_ = 0.3048 * foot_;
            resFoot.Text = resFoot_.ToString();
        }

        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            double miles_ = Convert.ToDouble(miles.Text);
            double resMiles_ = 1609.34 * miles_;
            resMiles.Text = resMiles_.ToString();
        }

        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            double verst_ = Convert.ToDouble(verst.Text);
            double resVerst_ = 1066.8 * verst_;
            resVerst.Text = resVerst_.ToString();
        }
    }
}
