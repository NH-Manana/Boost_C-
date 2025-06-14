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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace GVP.Views
{

    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class MenuPneu : Window
    {
        DispatcherTimer time = new DispatcherTimer();

        public MenuPneu()
        {
            InitializeComponent();

            time.Interval = TimeSpan.FromSeconds(1);
            time.Tick += Timer_Tick;
            time.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lb_time_d.Content = DateTime.Now.ToString("hh : mm");
            lb_date_d.Content = DateTime.Now.ToString("dddd dd MMMM yyyy");
        }

        private void Menu_Loaded(object sender, RoutedEventArgs e)
        {

        }

        //Effet close frame
        // -->
        private void Grid_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!IsClickedInsideElement(btn_user, e) && !IsClickedInsideElement(User_menu, e))
            {
                if (User_menu.Opacity == 1)
                {
                    var fadeOutStoryboard = this.FindResource("fadeOutUserMenu") as Storyboard;
                    fadeOutStoryboard?.Begin();
                }
            }
        }
        private bool IsClickedInsideElement(FrameworkElement element, MouseButtonEventArgs e)
        {
            if (element == null) return false;

            var position = e.GetPosition(element);

            return position.X >= 0 && position.X < element.ActualWidth &&
                   position.Y >= 0 && position.Y < element.ActualHeight;
        }
        // <--

        // -> Minimize & Close
        private void btn_min_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btn_quit_Click(object sender, RoutedEventArgs e)
        {
            showQuit();
        }
        // <-

        private void btn_Menu_O_MouseEnter(object sender, MouseEventArgs e)
        {
            btn_Menu_r.Fill = new SolidColorBrush(Color.FromRgb(113, 96, 232));
            btn_Menu_O.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }

        private void btn_Menu_O_MouseLeave(object sender, MouseEventArgs e)
        {
            btn_Menu_r.Fill = new SolidColorBrush(Color.FromRgb(94, 94, 94));
            btn_Menu_O.Foreground = new SolidColorBrush(Color.FromRgb(170, 170, 170));
        }
        private void btn_Menu_C_MouseEnter(object sender, MouseEventArgs e)
        {
            btn_Menu_r.Fill = new SolidColorBrush(Color.FromRgb(113, 96, 232));
            btn_Menu_C.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }

        private void btn_Menu_C_MouseLeave(object sender, MouseEventArgs e)
        {
            btn_Menu_r.Fill = new SolidColorBrush(Color.FromRgb(94, 94, 94));
            btn_Menu_C.Foreground = new SolidColorBrush(Color.FromRgb(170, 170, 170));
        }

        private void btn_Menu_O_Click(object sender, RoutedEventArgs e)
        {
            btn_Menu_O.Visibility = Visibility.Collapsed;
            btn_Menu_C.Visibility = Visibility.Visible;
        }

        private void btn_Menu_C_Click(object sender, RoutedEventArgs e)
        {
            btn_Menu_C.Visibility = Visibility.Collapsed;
            btn_Menu_O.Visibility = Visibility.Visible;
        }

        private void btn_notify_O_MouseEnter(object sender, MouseEventArgs e)
        {
            btn_notify_O.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }

        private void btn_notify_O_MouseLeave(object sender, MouseEventArgs e)
        {
            btn_notify_O.Foreground = new SolidColorBrush(Color.FromRgb(170, 170, 170));
        }

        private void btn_notify_C_MouseEnter(object sender, MouseEventArgs e)
        {
            btn_notify_C.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }

        private void btn_notify_C_MouseLeave(object sender, MouseEventArgs e)
        {
            btn_notify_C.Foreground = new SolidColorBrush(Color.FromRgb(170, 170, 170));
        }

        private void btn_user_MouseEnter(object sender, MouseEventArgs e)
        {
            btn_user.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }

        private void btn_user_MouseLeave(object sender, MouseEventArgs e)
        {
            btn_user.Foreground = new SolidColorBrush(Color.FromRgb(170, 170, 170));
        }

        private void btn_user_Click(object sender, RoutedEventArgs e)
        {
            if(User_menu.Opacity == 0)
            {
                Storyboard user_menu_a = this.FindResource("fadeInUserMenu") as Storyboard;
                user_menu_a.Begin();
            }
            else
            {
                Storyboard user_menu_c = this.FindResource("fadeOutUserMenu") as Storyboard;
                user_menu_c.Begin();
            }
        }

        private void btn_notify_O_Click(object sender, RoutedEventArgs e)
        {
            btn_notify_O.Visibility = Visibility.Collapsed;
            btn_notify_C.Visibility = Visibility.Visible;
        }

        private void btn_notify_C_Click(object sender, RoutedEventArgs e)
        {
            btn_notify_C.Visibility = Visibility.Collapsed;
            btn_notify_O.Visibility = Visibility.Visible;
        }


        public void showQuit()
        {
            darkBg.Visibility = Visibility.Visible;
        }

        // Action à chaque ListItemBox Menu
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem selectedItem = (ListBoxItem)e.AddedItems[0];
            string content = (string)selectedItem.Content;

            switch (content)
            {
                case "🏚 Accueil":
                    mainFrame.Source = new Uri("/Views/Accueil.xaml", UriKind.Relative);
                    break;
                case "👤 Client":
                    mainFrame.Navigate(new Client());
                    break;
                case "🚗 Livreur":
                    mainFrame.Navigate(new Page2());
                    break;
                case "🏭 Fournisseur":
                    mainFrame.Navigate(new Page1());
                    break;
                case "🛞 Pneu":
                    mainFrame.Navigate(new Page1());
                    break;
                case "📊 Stock":
                    mainFrame.Navigate(new Page1());
                    break;
                case "📈 Statistiques":
                    mainFrame.Navigate(new Page1());
                    break;
            }
        }
    }
}
