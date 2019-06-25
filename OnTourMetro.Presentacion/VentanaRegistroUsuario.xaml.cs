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
using OnTourMetro.Modelo;
using OnTourMetro.Negocio;
using MahApps.Metro.Controls.Dialogs;


namespace OnTourMetro.Presentacion
{
    /// <summary>
    /// Lógica de interacción para VentanaRegistroUsuario.xaml
    /// </summary>
    public partial class VentanaRegistroUsuario : MetroWindow
    {
        public VentanaRegistroUsuario()
        {
            InitializeComponent();
        }

        private void Tile_Cancelar_Click(object sender, RoutedEventArgs e)
        {
            MenuPrincipal win = new MenuPrincipal();
            this.Close();
            win.ShowDialog();

        }

        private async void Tile_Guardar_Click(object sender, RoutedEventArgs e)
        {
            if (!VerificarCasillas())
            {
                return;
            }
            else
            {
                Usuarios usr = new Usuarios();

                usr.Nombres = txtNombreUsuario.Text;
                usr.Appaterno = txtApellidoPaternoUsuario.Text;
                usr.Cod_Usuario = psbContrasenaNuevoUsuario.PasswordChar;
                usr.Apmaterno = txtApellidoMaternoUsuario.Text;
                new BcUsuarios().Create(usr);
                await this.ShowMessageAsync("ERROR", "Se encontró una casilla vacía. Verifique la casilla:");
            }
        }

        public bool VerificarCasillas()
        {
            if (txtNombreUsuario.Text.Trim() == "")
            {
                ErrorCasillaVacia("Nombre");
                return false;
            }

            if (txtApellidoPaternoUsuario.Text.Trim() == "")
            {
                ErrorCasillaVacia("Apellido paterno");
                return false;
            }

            if (psbContrasenaNuevoUsuario.Password == "")
            {
                ErrorCasillaVacia("Contraseña");
                return false;
            }

            if (txtApellidoMaternoUsuario.Text.Trim() == "")
            {
                ErrorCasillaVacia("Apellido Materno");
                return false;
            }
            return true;
        }

        public async void ErrorCasillaVacia(string casilla)
        {
          await this.ShowMessageAsync("ERROR", "Se encontró una casilla vacía. Verifique la casilla: " + casilla);
        }

    }
}
