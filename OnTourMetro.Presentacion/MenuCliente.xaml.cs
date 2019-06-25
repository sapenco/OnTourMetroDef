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
using MahApps.Metro.Controls.Dialogs;

namespace OnTourMetro.Presentacion
{
    /// <summary>
    /// Lógica de interacción para MenuCliente.xaml
    /// </summary>
    public partial class MenuCliente : MetroWindow
    {
        public MenuCliente()
        {
            InitializeComponent();
        }

        private void BtnRegistrarCurso_Click(object sender, RoutedEventArgs e)
        {
            FlyRegistroCurso.IsOpen = true;
        }

        private void BtnRegistrarAlumno_Click(object sender, RoutedEventArgs e)
        {
            FlyRegistroAlumno.IsOpen = true;
        }

        private async void BtnGuardarAlumno_Click(object sender, RoutedEventArgs e)
        {
            await this.ShowMessageAsync("Proceso exitoso","Los datos se registraron correctamente");
            txtNombreAlumno.Text = string.Empty;
            txtApellidoAlumno.Text = string.Empty;
            txtRutAlumno.Text = string.Empty;
            cmbCurso.Text = string.Empty;
            txtNombreAlumno.Focus();

        }

        private async void BtnGuardarCurso_Click(object sender, RoutedEventArgs e)
        {
            await this.ShowMessageAsync("Proceso exitoso", "Los datos se registraron correctamente");
            txtNombreColegio.Text = string.Empty;
            txtCurso.Text = string.Empty;
            txtNombreColegio.Focus();

        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            MenuPrincipal win = new MenuPrincipal();
            this.Close();
            win.ShowDialog();
        }
    }
}
