using System.Collections.ObjectModel;
using System.Windows;
namespace Laboration_1
{
    public partial class MainWindow : Window
    {

        private ObservableCollection<Medlem> members = new ObservableCollection<Medlem>();
        private ObservableCollection<Spel> allaSpel = new ObservableCollection<Spel>();

        public ObservableCollection<Medlem> Members
        {
            get { return members; }
            set { members = value; }
        }

        public ObservableCollection<Spel> AllaSpel
        {
            get { return allaSpel; }
            set { allaSpel = value; }
        }

        private Medlem selectedMember;

        public Medlem SelectedMember
        {
            get { return selectedMember; }
            set { selectedMember = value; }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            AllaSpel.Add(new Spel("Chess", 2, 2));

            Medlem medlem = new Medlem(1, "Adam", "test@mail.com");
        }

        private void removeUserBtn_Click(object sender, RoutedEventArgs e)
        {
            if (selectedMember == null)
                return;
            MessageBoxResult result = MessageBox.Show("Är du säker att du vill ta bort denna medlem?", "Confirm Deletion", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                Members.Remove(selectedMember);
            }
        }
    }
}