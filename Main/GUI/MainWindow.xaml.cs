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
    }
}
