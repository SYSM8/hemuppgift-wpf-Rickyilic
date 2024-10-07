using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for DockButton.xaml
    /// </summary>
    public partial class DockButton : Window
    {
        public DockButton()
        {
            InitializeComponent();
        }

        private void CenterButton_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage trophyImage = new BitmapImage(new Uri(@"C:\Users\ricky\Source\Repos\Hemuppgift_WPFtemplate\Hemuppgift_WPFtemplate\TrophyImage.jpg"));
            TrophyImage.Source = trophyImage;
        }
    }
}
