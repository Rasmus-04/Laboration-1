using System.Windows;
using System.Windows.Controls;
using System.ComponentModel;
using System.Windows.Data;

namespace Laboration_1.Vy.SpelVy
{
    /// <summary>
    /// Interaction logic for SpelVy.xaml
    /// </summary>
    public partial class SpelVy : UserControl
    {
        public SpelVy()
        {
            InitializeComponent();
            Loaded += SpelVy_Loaded;
        }

        private void SpelVy_Loaded(object sender, RoutedEventArgs e)
        {
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvSpel.ItemsSource);

            view.SortDescriptions.Add(new SortDescription("MaxPlayers", ListSortDirection.Ascending));
        }

        private void btnRemoveGame_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);

            if (lvSpel.SelectedItem == null)
                return;
            MessageBoxResult result = MessageBox.Show("Är du säker att du vill ta bort denna medlem?", "Confirm Deletion", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                mainWindow.AllaSpel.Remove((Spel)lvSpel.SelectedItem);
            }
        }
    }
}
