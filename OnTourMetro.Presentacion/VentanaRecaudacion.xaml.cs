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
    /// Lógica de interacción para VentanaRecaudacion.xaml
    /// </summary>
    public partial class VentanaRecaudacion : MetroWindow
    {
        public VentanaRecaudacion()
        {
            InitializeComponent();
        }

        private void TlCerrar_Click(object sender, RoutedEventArgs e)
        {
            VentanaMenuRecaudacion win = new VentanaMenuRecaudacion();
            this.Close();
            win.ShowDialog();
        }

        private async void TlBuscarColegio_Click(object sender, RoutedEventArgs e)
        {
            if (txtBuscarColegio.Text.Trim() == "")
            {
                await this.ErrorColegioVacio();
            }
            else
            {
                Usuarios usr = new BcUsuarios().ReadByColegio(txtBuscarColegio.Text);
                if (usr == null)
                {
                    await this.ErrorColegioNoEncontrado();
                }
                else
                {
                    dgrUsuarios.ItemsSource = new List<Usuarios> { usr };
                }
            }

        }

        private async void TlBuscarCurso_Click(object sender, RoutedEventArgs e)
        {
            if (txtBuscarCurso.Text.Trim() == "")
            {
                await this.ErrorColegioVacio();
            }
            else
            {
                Usuarios usr = new BcUsuarios().ReadByCurso(txtBuscarColegio.Text);
                if (usr == null)
                {
                    await this.ErrorCursoNoEncontrado();
                }
                else
                {
                    dgrUsuarios.ItemsSource = new List<Usuarios> { usr };
                }
            }
        }

        private void TlBuscarContratos_Click(object sender, RoutedEventArgs e)
        {
            List<Usuarios> list = new BcUsuarios().ReadAll();
            dgrUsuarios.ItemsSource = list;
        }



        public async Task ErrorColegioVacio()
        {
            await this.ShowMessageAsync("ERROR AL BUSCAR", "Por favor, ingrese un Colegio");
        }

        public async Task ErrorColegioNoEncontrado()
        {
            await this.ShowMessageAsync("ERROR AL BUSCAR", "No se encontró el Colegio ingresado. Intente nuevamente.");
        }

        public async Task ErrorCursoVacio()
        {
            await this.ShowMessageAsync("ERROR AL BUSCAR", "Por favor, ingrese un Curso");
        }
        public async Task ErrorCursoNoEncontrado()
        {
            await this.ShowMessageAsync("ERROR AL BUSCAR", "No se encontró el curso ingresado. Intente nuevamente.");
        }

        
    }
}
