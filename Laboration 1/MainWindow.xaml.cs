using System.Collections.ObjectModel;
using System.Windows;
namespace Laboration_1
{
    public partial class MainWindow : Window
    {

        private ObservableCollection<Medlem> members = new ObservableCollection<Medlem>();

        public ObservableCollection<Medlem> Members
        {
            get { return members; }
            set { members = value; }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            Spel spel = new Spel(1, "Chess", 2, 2);
            Aktivitet aktivitet = new Aktivitet(1, "Spelkväll", DateTime.Now, spel);
            Medlem medlem = new Medlem(1, "Adam", "test@mail.com");

            aktivitet.AddDeltagare(medlem);
        }

        private void AddNewUser(object sender, RoutedEventArgs e)
        {
            int age;
            string name = txtName.Text;
            string email = txtEmail.Text;
            if (string.IsNullOrEmpty(name))
                MessageBox.Show("Namn måste vara ifyllt.", "Felaktigt namn", MessageBoxButton.OK, MessageBoxImage.Information);
            else if (!int.TryParse(txtAge.Text, out age))
                MessageBox.Show("Ålder måste vara ifylld.", "Felaktig ålder", MessageBoxButton.OK, MessageBoxImage.Information);
            else if(string.IsNullOrEmpty(email))
                MessageBox.Show("Epost måste vara ifylld.", "Felaktigt Epost", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                Medlem newMember = new Medlem(age, txtName.Text, txtEmail.Text);
                Members.Add(newMember);
                MessageBox.Show($"New user created: {newMember.Name} ({newMember.Email})");

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Är du säker att du vill ta bort denna medlem?", "Confirm Deletion", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                Medlem member = (Medlem)lvMembers.SelectedItem;
                Members.Remove(member);
            }
        }
    }
}