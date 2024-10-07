using System.Windows;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //HEJ
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GridButton_Click(object sender, RoutedEventArgs e)
        {
            GridWindow newGridWindow = new GridWindow();
            newGridWindow.Show();
        }

        private void StackButton_Click(object sender, RoutedEventArgs e)
        {
            StackPanel newStackPanel = new StackPanel();
            newStackPanel.Show();
        }

        private void WrapButton_Click(object sender, RoutedEventArgs e)
        {
            WrapButton newWrapButton = new WrapButton();
            newWrapButton.Show();
        }

        private void DockButton_Click(object sender, RoutedEventArgs e)
        {
            DockButton newDockButton = new DockButton();
            newDockButton.Show();
        }
    }
}