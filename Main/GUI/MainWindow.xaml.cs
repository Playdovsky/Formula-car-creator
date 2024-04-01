using Main.GUI;
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
            StartControl control = new StartControl();
            ContentControl.Content = control;
            LabelTitle.Visibility = Visibility.Hidden;
        }

        private void ContentControl_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            RaceCarControl carControl = new RaceCarControl();
            ContentControl.Content = carControl;
            LabelTitle.Visibility = Visibility.Visible;
        }
    }
}
