using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
