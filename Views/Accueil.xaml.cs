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

namespace GVP.Views
{
    /// <summary>
    /// Interaction logic for Accueil.xaml
    /// </summary>
    public partial class Accueil : Page
    {
        public Accueil()
        {
            InitializeComponent();
        }

        // Effet sur les blocs de Menu d'accueil
        private void All_Block_MouseEnter(object sender, MouseEventArgs e)
        {
            Canvas canvas = (Canvas)sender;
            canvas.Background = new SolidColorBrush(Color.FromRgb(94, 105, 142));
            foreach (Label label in canvas.Children.OfType<Label>())
            {
                label.Foreground = new SolidColorBrush(Color.FromRgb(0, 46, 44));
            }
        }

        private void All_Block_MouseLeave(object sender, MouseEventArgs e)
        {
            Canvas canvas = (Canvas)sender;
            canvas.Background = new SolidColorBrush(Color.FromRgb(44, 49, 65));
            foreach (Label label in canvas.Children.OfType<Label>())
            {
                label.Foreground = new SolidColorBrush(Color.FromRgb(237, 237, 238));
            }
        }

        private void Pneu_Block_MouseEnter(object sender, MouseEventArgs e)
        {
            Canvas canvas = (Canvas)sender;
            canvas.Background = new SolidColorBrush(Color.FromRgb(94, 105, 142));
            foreach (Label label in canvas.Children.OfType<Label>())
            {
                label.Foreground = new SolidColorBrush(Color.FromRgb(0, 46, 44));
            }
            emoji_pneu.Source = new BitmapImage(new Uri("/Views/assets/car_13650409df.png", UriKind.Relative));
        }

        private void Pneu_Block_MouseLeave(object sender, MouseEventArgs e)
        {
            Canvas canvas = (Canvas)sender;
            canvas.Background = new SolidColorBrush(Color.FromRgb(44, 49, 65));
            foreach (Label label in canvas.Children.OfType<Label>())
            {
                label.Foreground = new SolidColorBrush(Color.FromRgb(237, 237, 238));
            }
            emoji_pneu.Source = new BitmapImage(new Uri("/Views/assets/car_13650409.png", UriKind.Relative));
        }

        private void Client_Block_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Client clientPage = new Client();
            this.NavigationService.Navigate(clientPage);
        }
    }
}
