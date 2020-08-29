using System;
using System.Collections.Generic;
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

namespace QuizSEBASTIANGOMEZ
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();

            cboxGraficas.Items.Add("RTX 2080ti");
            cboxGraficas.Items.Add("GTX 1650 Super");
            cboxGraficas.Items.Add("VEGA 56");

            cboxProcesadores.Items.Add("Ryzen 5 2600");
            cboxProcesadores.Items.Add("I9 9900K");
            cboxProcesadores.Items.Add("Ryzen 3 3300G");

        }

        private void rbtnGraficas_Checked(object sender, RoutedEventArgs e)
        {
            cboxGraficas.Visibility = Visibility.Visible;
            cboxProcesadores.Visibility = Visibility.Hidden;
        }

        private void rbtnProcesadores_Checked(object sender, RoutedEventArgs e)
        {
            cboxProcesadores.Visibility = Visibility.Visible;
            cboxGraficas.Visibility = Visibility.Hidden;
        }

        private void btnCarro_Click(object sender, RoutedEventArgs e)
        {
            if (sldTienda.Value != 0)
            {

                if (cboxGraficas.Visibility == Visibility.Hidden)
                {
                    lboxCarrito.Items.Add(string.Format("{0} | {1}", cboxProcesadores.SelectedItem, sldTienda.Value));
                }
                else
                {
                    lboxCarrito.Items.Add(string.Format("{0} | {1}", cboxGraficas.SelectedItem, sldTienda.Value));
                }
            }
        }

        private void btnComprar_Click(object sender, RoutedEventArgs e)
        {
            if(lboxCarrito.SelectedItem== null)
            {
                MessageBox.Show("Seleccione un articulo");
            }
            else
            {

                string compra1 = lboxCarrito.SelectedItem.ToString();
                txtResults.Text += compra1 + "\n";
                lboxCarrito.Items.Remove(lboxCarrito.SelectedItem);
            }
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.frameMain.NavigationService.Navigate(new Login());
        }
    }
}
