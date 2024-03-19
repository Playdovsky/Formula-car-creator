using System.Windows;
using System.Windows.Controls;

namespace Main
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeContent();
        }

        private void InitializeContent()
        {
            RaceCarControl carControl = new RaceCarControl();
            ContentControl.Content = carControl;
        }

        private void ButtonCarList_Click(object sender, RoutedEventArgs e)
        {
            GarageWindow garageWindow = new GarageWindow();
            garageWindow.Show();
        }
    }
}
