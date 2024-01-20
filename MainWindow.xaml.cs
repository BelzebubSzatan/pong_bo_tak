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

namespace pong_bo_tak {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        Ball ball;
        public MainWindow() {
            InitializeComponent();
            ball = new Ball(MainCanvas,10,10);
        }

        private void Window_MouseMove(object sender, MouseEventArgs e) {

        }

        private void Window_KeyDown(object sender, KeyEventArgs e) {

        }
    }
}