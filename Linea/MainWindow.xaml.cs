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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Linea
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                Container.ColumnDefinitions.Add(new ColumnDefinition
                {
                    Width = new GridLength(45)
                });
                Container.RowDefinitions.Add(new RowDefinition
                {
                    Height = new GridLength(45)
                });
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    var button = new Button();
                    var name = $"b{i}{j}";
                    button.Content = name;
                    button.Name = name;
                    button.Width = Double.NaN;
                    button.Height = Double.NaN;
                    button.Style = this.FindResource("RoundButtonTemplate") as Style;
                    Grid.SetColumn(button, i);
                    Grid.SetRow(button, j);
                    Container.Children.Add(button);
                }
            }
        }
    }
}