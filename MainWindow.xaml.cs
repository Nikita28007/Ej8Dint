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

namespace Ej8Dint
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            nombreTextBox.Tag = ayudaTextBlock;
            apellidoTextBox.Tag = ayudaApellidoTextBlock;
        }


        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBlock mensaje = (sender as TextBox).Tag as TextBlock;
            if (e.Key == Key.F1)
            {
                if (mensaje.IsVisible) 
                    mensaje.Visibility = Visibility.Hidden;
                else mensaje.Visibility = Visibility.Visible;
                ayudaTextBlock.Text = "Nombre del cliente";
                ayudaApellidoTextBlock.Text = "Apellido del cliente";

            
                    
            }
        }

        private void edadTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            int numero;
            
             if (e.Key == Key.F2)
            {
                if (!int.TryParse(edadTextBox.Text,out numero))
                {
                    ayudaEdad.Text = "Edad incorrecta";
                    ayudaEdad.Visibility = Visibility.Visible;
                    ayudaEdad.Foreground = Brushes.Red;
                }
                else
                {
                    ayudaEdad.Visibility = Visibility.Hidden;
                }
            }
        }

     
    }
}
