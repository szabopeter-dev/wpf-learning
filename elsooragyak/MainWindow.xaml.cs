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

namespace elsooragyak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
      
    {
       public static int counter = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("hello");
            lb_barmi.Content = "hello user!";
            pgb.Value++;
            if (counter %2 == 0  )
            {
                myradio.IsChecked = true;
            }
            else
            {
                myradio.IsChecked= false;
            }

            lbbox.Items.Add(lb_barmi.Content);
        }

        private void lbbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show();
        }
    }
}