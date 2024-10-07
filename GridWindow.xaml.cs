using System;
using System.Collections.Generic;
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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for GridWindow.xaml
    /// </summary>
    public partial class GridWindow : Window
    {
        public GridWindow()
        {
            InitializeComponent();
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {

            /*  Deklarerar två nya int värden för att lagra våra nya värden som kommer från RowNumber.text 
                och ColumnNumber.text och felhanterar ifall användarens inmatning inte är mellan 0-3 
            */

            if (int.TryParse(RowNumber.Text, out int row) && row >= 0 && row <= 3 &&
                int.TryParse(ColumnNumber.Text, out int column) && column >= 0 && column <= 3)

                {
                //skapar en ny knapp från eventet
                Button newButton = new Button();
                newButton.Content = $"Row ({RowNumber.Text},Column {ColumnNumber.Text})";
                newButton.Background = Brushes.LightGreen;

                //Lägger till nya knappen i inmatningens ruta
                Grid.SetRow(newButton, row);
                Grid.SetColumn(newButton, column);
                GridButton.Children.Add(newButton);

            }
            else
            {
                MessageBox.Show("Ange siffror mellan 0-3");
            }
        }
    }
}

    
