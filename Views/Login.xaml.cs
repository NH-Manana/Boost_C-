using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace GVP.Views
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void passbox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (passbox.Password != tbPassLog.Text)
                tbPassLog.Text = passbox.Password;
                tbPassLog.SelectionStart = tbPassLog.Text.Length;
        }

        private void tbPassLog_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbPassLog.Text != passbox.Password)
                passbox.Password = tbPassLog.Text;
                passbox.GetType().GetMethod("Select", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(passbox, new object[] { passbox.Password.Length, 0 });
        }

        private void cbShowPass_Checked(object sender, RoutedEventArgs e)
        {
            tbPassLog.Visibility = Visibility.Visible;
            passbox.Visibility = Visibility.Collapsed;
            tbPassLog.Focus(); // Mettre le focus sur tbPassLog
        }

        private void cbShowPass_Unchecked(object sender, RoutedEventArgs e)
        {
            tbPassLog.Visibility = Visibility.Collapsed;
            passbox.Visibility = Visibility.Visible;
            passbox.Focus(); // Mettre le focus sur passbox
        }

        private void btnClose_Log_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            MenuPneu menupneu = new MenuPneu();
            this.Close();
            menupneu.Show();
        }
    }
}
