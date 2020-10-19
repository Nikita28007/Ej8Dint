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
                if (mensaje.IsVisible) mensaje.Visibility = Visibility.Hidden;
                else mensaje.Visibility = Visibility.Visible;
              
            }
        }

        private void nomAppTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            int num;
            TextBlock textBlock = sender as TextBlock;
            if (Keyboard.IsKeyDown(Key.F2) || textBox.Tag.Equals("3"))
            {
                if (textBlock.Tag.Equals("t3"))
                {
                    if (!int.TryParse(textBox.Text, out num))
                    {
                        textBox.Text = "Edad incorecta"; 
                    }
                }
            }
        }

        


          

            //comprobar edad - try parse 
            //si es entero correcto, si no no
        

        private void edadTextBox_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.Key == Key.F1)
            {
                //si es visble cambiar a visible
            }
        }
    }
}
