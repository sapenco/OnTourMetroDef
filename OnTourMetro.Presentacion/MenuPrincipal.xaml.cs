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
using MahApps.Metro.Controls;

namespace OnTourMetro.Presentacion
{
    /// <summary>
    /// Lógica de interacción para MenuPrincipal.xaml
    /// </summary>
    public partial class MenuPrincipal : MetroWindow
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void TlContrato_Click(object sender, RoutedEventArgs e)
        {
            Contratos win = new Contratos();
            this.Close();
            win.ShowDialog();
        }

        private void TlClientes_Click(object sender, RoutedEventArgs e)
        {
            MenuCliente win = new MenuCliente();
            this.Close();
            win.ShowDialog();
        }

        private void TlCerrarsesion_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            this.Close();
            win.ShowDialog();
        }

        private void TlRegistroUsuarios_Click(object sender, RoutedEventArgs e)
        {
            VentanaRegistroUsuario win = new VentanaRegistroUsuario();
            this.Close();
            win.ShowDialog();
        }

        private void TlCuenta_Click(object sender, RoutedEventArgs e)
        {
            VentanaCuenta win = new VentanaCuenta();
            this.Close();
            win.ShowDialog();
        }

        private void TlRecaudacion_Click(object sender, RoutedEventArgs e)
        {
            VentanaMenuRecaudacion win = new VentanaMenuRecaudacion();
            this.Close();
            win.ShowDialog();
        }
    }
}
