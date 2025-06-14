using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace GVP.Views
{
    /// <summary>
    /// Interaction logic for Client.xaml
    /// </summary>
    public partial class Client : Page
    {
        public ICommand SupprimerCommand { get; private set; }
        public ICommand ModifierCommand { get; private set; }
        private int _currentClientId;

        public Client()
        {
            InitializeComponent();
            SupprimerCommand = new RelayCommand(ExecuteSupprimerCommand);
            ModifierCommand = new RelayCommand(ExecuteModifierCommand);
            DataContext = this;
            ChargerClients();
        }

        private void ChargerClients()
        {
            var controller = new GVP.Controllers.ClientController();
            var clients = controller.GetAllClients();
            liste_client.ItemsSource = clients;
        }

        private void ExecuteSupprimerCommand(object parameter)
        {
            if (parameter is int clientId)
            {
                try
                {
                    var controller = new GVP.Controllers.ClientController();
                    controller.DeleteClient(clientId);
                    MessageBox.Show("Client supprimé avec succès !", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);
                    ChargerClients();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la suppression du client : {ex.Message}", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("ID du client invalide.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ExecuteModifierCommand(object parameter)
        {
            if (parameter is int clientId)
            {
                try
                {
                    var controller = new GVP.Controllers.ClientController();
                    var client = controller.GetClientById(clientId); // Assumed method
                    if (client != null)
                    {
                        _currentClientId = clientId;
                        // Populate the Modifier tab fields
                        txtNomModifier.Text = client.Nom;
                        txtPrenomModifier.Text = client.Prenom;
                        txtNomCompletModifier.Text = $"{client.Nom} {client.Prenom}".Trim();
                        txtAdresseModifier.Text = client.Adresse;
                        txtVilleModifier.Text = client.Ville;
                        txtTelephoneModifier.Text = client.Telephone;
                        txtEmailModifier.Text = client.Email;

                        // Switch to Modifier tab
                        ModifierTab.IsSelected = true;
                    }
                    else
                    {
                        MessageBox.Show("Client introuvable.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors du chargement du client : {ex.Message}", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("ID du client invalide.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_Return_MouseEnter(object sender, MouseEventArgs e)
        {
            btn_Return.BorderThickness = new Thickness(3);
            btn_Return.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF002E2C"));
            btn_Return.Effect = null;
        }

        private void btn_Return_MouseLeave(object sender, MouseEventArgs e)
        {
            btn_Return.BorderThickness = new Thickness(0);
            btn_Return.BorderBrush = Brushes.Transparent;
            btn_Return.Effect = (Effect)FindResource("myShadowbtnReturn");
            btn_Return.Background = Brushes.White;
        }

        private void btn_Return_Click(object sender, RoutedEventArgs e)
        {
            Accueil accueilPage = new Accueil();
            this.NavigationService.Navigate(accueilPage);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        }

        private void NomPrenom_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtNomComplet.Text = $"{txtNom.Text} {txtPrenom.Text}".Trim();
        }

        private void NomPrenomModifier_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtNomCompletModifier.Text = $"{txtNomModifier.Text} {txtPrenomModifier.Text}".Trim();
        }

        private void BtnEnregistrer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var client = new GVP.Models.Client
                {
                    Nom = txtNom.Text,
                    Prenom = txtPrenom.Text,
                    Adresse = txtAdresse.Text,
                    Ville = txtVille.Text,
                    Telephone = txtTelephone.Text,
                    Email = txtEmail.Text
                };
                var controller = new GVP.Controllers.ClientController();
                controller.AddClient(client);
                var result = MessageBox.Show("Client ajouté avec succès !", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);
                if (result == MessageBoxResult.OK)
                {
                    ClearFields();
                    ChargerClients();
                    ListeTab.IsSelected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout du client : {ex.Message}", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnEnregistrerModifier_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var client = new GVP.Models.Client
                {
                    Id = _currentClientId,
                    Nom = txtNomModifier.Text,
                    Prenom = txtPrenomModifier.Text,
                    Adresse = txtAdresseModifier.Text,
                    Ville = txtVilleModifier.Text,
                    Telephone = txtTelephoneModifier.Text,
                    Email = txtEmailModifier.Text
                };
                var controller = new GVP.Controllers.ClientController();
                controller.UpdateClient(client); // Assumed method
                MessageBox.Show("Client modifié avec succès !", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);
                ClearModifierFields();
                ChargerClients();
                ListeTab.IsSelected = true; // Return to Liste tab
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification du client : {ex.Message}", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_Clean_Click(object sender, RoutedEventArgs e)
        {
            ClearFields();
        }

        private void btn_CleanModifier_Click(object sender, RoutedEventArgs e)
        {
            ClearModifierFields();
        }

        private void ClearFields()
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtNomComplet.Text = "";
            txtAdresse.Text = "";
            txtVille.Text = "";
            txtTelephone.Text = "";
            txtEmail.Text = "";
        }

        private void ClearModifierFields()
        {
            txtNomModifier.Text = "";
            txtPrenomModifier.Text = "";
            txtNomCompletModifier.Text = "";
            txtAdresseModifier.Text = "";
            txtVilleModifier.Text = "";
            txtTelephoneModifier.Text = "";
            txtEmailModifier.Text = "";
            _currentClientId = 0;
        }

        private TabControl FindParentTabControl(DependencyObject child)
        {
            DependencyObject parent = VisualTreeHelper.GetParent(child);
            while (parent != null && !(parent is TabControl))
            {
                parent = VisualTreeHelper.GetParent(parent);
            }
            return parent as TabControl;
        }
    }

    public class RelayCommand : ICommand
    {
        private readonly Action<object?> _execute;
        private readonly Func<object?, bool>? _canExecute;

        public RelayCommand(Action<object?> execute, Func<object?, bool>? canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public bool CanExecute(object? parameter) => _canExecute?.Invoke(parameter) ?? true;

        public void Execute(object? parameter) => _execute(parameter);

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}