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

namespace ValorRendaMax
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();




        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double price = Convert.ToDouble(precoTotal.Text);

            double areaT = Convert.ToDouble(areaTotal.Text);

            double areaDef = Convert.ToDouble(areaPendente.Text);

            double perct = 0.3;


            double areaNorm = areaT-areaDef;

            double nareaD = areaDef * perct;

            double nareaN = areaNorm + nareaD;

            double x = price / nareaN;

            double precoFinalF = x * areaNorm;

            double rendaMensal = (precoFinalF / 15)/12;
            
            precoFinal.Content = precoFinalF;

            rendaFinal.Content = rendaMensal;


        }   
    }
}
