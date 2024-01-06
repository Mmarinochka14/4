using System.Windows;

namespace Testik
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Test1 test1 = new Test1();
            this.Hide();

            test1.ShowDialog();
            this.Show();
        }

    }
}
