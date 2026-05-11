using Laboration_1.Vy.AddMemberVy;
using Laboration_1.Vy.EventDeltagareWindow;
using Laboration_1.Vy.AddDeltagreWindow;
using System.Windows;
using System.Windows.Controls;
using System.ComponentModel;
using System.Windows.Data;

namespace Laboration_1.Vy.EventVy
{
    /// <summary>
    /// Interaction logic for EventVy.xaml
    /// </summary>
    public partial class EventVy : UserControl
    {
        public EventVy()
        {
            InitializeComponent();
            Loaded += EventVy_Loaded;
        }

        private void EventVy_Loaded(object sender, RoutedEventArgs e)
        {
            CollectionView view =(CollectionView)CollectionViewSource.GetDefaultView(lvAktiviteter.ItemsSource);

            view.SortDescriptions.Add(new SortDescription("Datum",ListSortDirection.Ascending));
        }

        private void btnRemoveActivity_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);

            if (lvAktiviteter.SelectedItem == null)
                return;
            MessageBoxResult result = MessageBox.Show("Är du säker att du vill ta bort denna Aktivitet?", "Confirm Deletion", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                mainWindow.AllaAktiviteter.Remove((Aktivitet)lvAktiviteter.SelectedItem);
            }
        }

        private void btnVisaDeltagare_Click(object sender, RoutedEventArgs e)
        {
            if(lvAktiviteter.SelectedItem == null)
                return;

            Window parentWindow = Window.GetWindow(this);

            // För tillgång till listorna i MainWindow.xaml.cs
            MainWindow mainWindow = (MainWindow)parentWindow;

            DeltagareWindow deltagareWindow = new DeltagareWindow(parentWindow, (Aktivitet)lvAktiviteter.SelectedItem);

            parentWindow.Opacity = .4;
            deltagareWindow.ShowDialog();
            parentWindow.Opacity = 1;
        }

        private void btnAddMember_Click(object sender, RoutedEventArgs e)
        {
            if (lvAktiviteter.SelectedItem == null)
                return;

            Window parentWindow = Window.GetWindow(this);

            // För tillgång till listorna i MainWindow.xaml.cs
            MainWindow mainWindow = (MainWindow)parentWindow;

            AddDeltagareWindow deltagareWindow = new AddDeltagareWindow(parentWindow, (Aktivitet)lvAktiviteter.SelectedItem, mainWindow.Members);

            parentWindow.Opacity = .4;
            deltagareWindow.ShowDialog();
            parentWindow.Opacity = 1;
        }
    }
}
