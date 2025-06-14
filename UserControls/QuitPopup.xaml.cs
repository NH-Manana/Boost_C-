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
using GVP.Views;


namespace GVP.UserControls
{
    /// <summary>
    /// Interaction logic for QuitPopup.xaml
    /// </summary>
    public partial class QuitPopup : UserControl
    {
        public QuitPopup()
        {
            InitializeComponent();
     
        }

        // Fermer l'application après avoir cliqué sur "Oui"
        private void btn_quit_y_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // Retourner au menu après avoir cliqué sur "Non"
        private void btn_quit_n_Click(object sender, RoutedEventArgs e)
        {
            ClosePopup(Parent);
        }

        // Ferme la popup en cachant son parent
        private void ClosePopup(DependencyObject parent)
        {
            if (parent is Grid grid)
            {
                grid.Visibility = Visibility.Collapsed;
            }
        }
    }
}

