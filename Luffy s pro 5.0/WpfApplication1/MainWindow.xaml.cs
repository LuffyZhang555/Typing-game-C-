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

namespace WpfApplication1
{
    /// <summary>
    /// the welcome page to begin with using navigationservice lol
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickButton(object sender, RoutedEventArgs e)
        {
            Page1 p1 = new Page1();
            main.NavigationService.Navigate(p1);
            start.Visibility = Visibility.Hidden;
            gamename.Visibility = Visibility.Hidden;


        }

       
    }
}
