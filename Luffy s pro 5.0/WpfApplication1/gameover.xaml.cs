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
    /// after game over a page with score and reamaining health
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2(string finalscore,string finalhealth)
        {
            InitializeComponent();
            result1.Text = finalscore;
            result2.Text = finalhealth;
        }
    }
}
