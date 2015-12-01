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

namespace vaskeProjekt
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

        private void btnOpretBruger_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBrugerNavn.Text))
            {
                MessageBox.Show("Navn ugyldigt.");
            }
            else
            {
                Service.CreateBruger(txtBrugerNavn.Text);
                txtBrugerNavn.Text = "";
                //MessageBox.Show("Bruger Oprettet");
            }
        }

        private void btnOpretVaskeri_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVaskeri.Text))
            {
                MessageBox.Show("Navn ugyldigt.");
            }
            else
            {
               // Service.CreateVaskeri(txtVaskeri.Text);
                txtVaskeri.Text = "";
                //MessageBox.Show("Vaskeri Oprettet");
            }
        }

        private void tabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (tabTilknyt.IsSelected)
            {
                cbVaskerier.ItemsSource = Service.getVaskerier();
                //lbBrugereUV.ItemsSource = Service.getBrugereUdenVaskeri();
            }
        }

        private void btnTilknyt_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBrugerNavn.Text))
            {
                MessageBox.Show("Navn ugyldigt.");
            }
            else if ((Vaskeri)cbVaskerier.SelectedValue == null)
            {
                MessageBox.Show("Der skal vælges et Vaskeri");
            }
            else
            {
                Bruger b = Service.CreateBruger(txtBrugerNavn.Text);
                Service.Tilknyt(b, (Vaskeri)cbVaskerier.SelectedValue);
                txtBrugerNavn.Text = "";
            }
        }
    }
}
