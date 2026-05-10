using System.Windows;
using System.Windows.Controls;
using Laboration_1.Vy.AddMemberVy;
using Laboration_1.Vy.AddSpelWindow;

namespace Laboration_1.Vy.MenuBar
{
    /// <summary>
    /// Interaction logic for MenuBar.xaml
    /// </summary>
    public partial class MenuBar : UserControl
    {
        public MenuBar()
        {
            InitializeComponent();
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);

            // För tillgång till members listan i MainWindow.xaml.cs
            MainWindow mainWindow = (MainWindow)parentWindow;

            AddMember addMemberWindow = new AddMember(parentWindow);
            parentWindow.Opacity = .4;
            bool? result = addMemberWindow.ShowDialog();

            if (result == true) { 
                mainWindow.Members.Add(addMemberWindow.CreatedMember);
            }
            parentWindow.Opacity = 1;

        }

        private void NewSpel_Click(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);

            // För tillgång till allaSpel listan i MainWindow.xaml.cs
            MainWindow mainWindow = (MainWindow)parentWindow;

            AddSpel nyttSpelWindow = new AddSpel(parentWindow);
            parentWindow.Opacity = .4;
            bool? result = nyttSpelWindow.ShowDialog();

            if (result == true)
            {
                mainWindow.AllaSpel.Add(nyttSpelWindow.CreatedSpel);
            }
            parentWindow.Opacity = 1;
        }
    }
}
