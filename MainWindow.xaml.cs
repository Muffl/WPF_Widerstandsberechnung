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

namespace WPF_Widerstandsberechnung
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

        private void cmd_Berechnen_Click(object sender, RoutedEventArgs e)
        {
            double ohm;
            double ampere;
            double volt;

            //ohm = Convert.ToDouble(txtBox_Ohm.Text);
            ampere = Convert.ToDouble(txtBox_Ampere.Text);
            volt = Convert.ToDouble(txtBox_Volt.Text);

            ohm = volt / ampere;

            string format = "{0,10:000}";

            txtBox_Ohm.Text = String.Format(format, ohm); 

        }
    }
}
