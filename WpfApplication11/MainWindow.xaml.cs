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

namespace WpfApplication11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Osoba osoba = new Osoba();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime dataT = DateTime.ParseExact(DataUr.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                osoba.Ustaw(Imie.Text, Nazwisko.Text, dataT);
                OpisOsoby.Text = osoba.ToString();
            }
            catch
            {
                MessageBox.Show("coś źle");
            }
        }


    }
}
