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

namespace GM_Toolbox.Models
{
    /// <summary>
    /// Interaction logic for TrapGen.xaml
    /// </summary>
    public partial class TrapGen : Window
    {
        public TrapGen()
        {
            InitializeComponent();
        }
        /*
         * 2 text boxes - 1 dmg done, 1 how to beat
         *  drop down for reasons
         *  3 buttons - save load generate
         *  2 check boxes for reasons
         *  
         */ 
        private void HomeMenuButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();
        }
    }
}
