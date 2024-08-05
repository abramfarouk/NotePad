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
using System.Windows.Shapes;

namespace Abram_NotePad
{
    /// <summary>
    /// Interaction logic for About_Menu.xaml
    /// </summary>
    public partial class About_Menu : Window
    {
        public About_Menu()
        {
            InitializeComponent();
        }

        private void OK_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
