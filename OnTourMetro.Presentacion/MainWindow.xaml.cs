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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace OnTourMetro.Presentacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnIniciarSesion_Click(object sender, RoutedEventArgs e)
        {
            MenuPrincipal win = new MenuPrincipal();
            this.Close();
            win.ShowDialog();
        }

        private async void Tile_Aceptar_Click(object sender, RoutedEventArgs e)
        {
            if (txtCorreoElectronico.Text == "" && txtNombreUsuarioCambioPass.Text == "")
            {
                await this.ShowMessageAsync("Error", "El correo electronico no coincide con su nombre de usuario.");
            }
            else
            {
                await this.ShowMessageAsync("Proceso exitoso", "Se envio envio su contraseña a su correo y se notifico al administrador del sistema.");
            }
        }

        private void Tile_OlvidoContraseña_Click(object sender, RoutedEventArgs e)
        {
            flyRestablecerContrasena.IsOpen = true;
        }
    }
}
