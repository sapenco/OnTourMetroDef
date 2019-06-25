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
    /// Lógica de interacción para VentanaMenuRecaudacion.xaml
    /// </summary>
    public partial class VentanaMenuRecaudacion : MetroWindow
    {
        public VentanaMenuRecaudacion()
        {
            InitializeComponent();
        }

        private void Tile_Volver_Click(object sender, RoutedEventArgs e)
        {
            MenuPrincipal win = new MenuPrincipal();
            this.Close();
            win.ShowDialog();
        }

        private void Tile_Recaudacion_Click(object sender, RoutedEventArgs e)
        {
            VentanaRecaudacion win = new VentanaRecaudacion();
            this.Close();
            win.ShowDialog();
        }

        private void Tile_Depositar_Click(object sender, RoutedEventArgs e)
        {
            flyDeposito.IsOpen = true;
        }

        private async void Tile_AceptarDeposito_Click(object sender, RoutedEventArgs e)
        {
            if ( txtCorreoElectronico.Text != "" && txtMontoDeposito.Text != "" ) {
                System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();
                mmsg.To.Add(txtCorreoElectronico.Text);
                mmsg.Subject = ("Notificacion de deposito en la agencia OnTour");
                mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
                mmsg.Body = ("Estimado: " + "Junto con saludar, le informo que se han depositado: $"
                             + txtMontoDeposito.Text + " en su cuenta. Muchas gracias.");
                mmsg.BodyEncoding = System.Text.Encoding.UTF8;
                mmsg.IsBodyHtml = true;

                mmsg.From = new System.Net.Mail.MailAddress("agencia.ontourcl@gmail.com");
                System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
                cliente.Credentials = new System.Net.NetworkCredential("agencia.ontourcl@gmail.com", "thumariodelboom");
                cliente.Port = 587;
                cliente.EnableSsl = true;
                cliente.Host = "smtp.gmail.com"; //mail.dominio.com

                try
                {
                    cliente.Send(mmsg);
                    await this.ShowMessageAsync("Proceso completo", "Se envio el correo.");
                }
                catch (Exception)
                {
                    await this.ShowMessageAsync("Error", "No se pudo enviar el correo.");
                }
            }
            else
            {
                await this.ShowMessageAsync("Error", "Debe ingresar los datos correspondientes.");
            }
            

        }
    }
    
}
