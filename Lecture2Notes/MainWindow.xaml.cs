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

namespace Lecture2Notes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Checks to see if textBox is changed
            if (textBoxName.Text == "Enter Your Name Here")
            {
                MessageBox.Show("Please change the textbox");
            }
            else
            {
                MessageBox.Show("Hello " + textBoxName.Text);
            }
        }
    }
}