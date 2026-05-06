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
namespace Laboration_1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Spel spel = new Spel(1, "Chess", 2, 2);

            Aktivitet aktivitet = new Aktivitet(1, "Spelkväll", DateTime.Now, spel);

            Medlem medlem = new Medlem(1, "Adam", "test@mail.com");

            aktivitet.AddDeltagare(medlem);

            MessageBox.Show(aktivitet.Spel.ToString());
        }
    }
}