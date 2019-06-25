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
    /// Lógica de interacción para VentanaCuenta.xaml
    /// </summary>
    public partial class VentanaCuenta : MetroWindow
    {
        public VentanaCuenta()
        {
            InitializeComponent();
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            MenuPrincipal win = new MenuPrincipal();
            this.Close();
            win.ShowDialog();
        }
    }
}
