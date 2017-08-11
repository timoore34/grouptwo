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
    /// Interaction logic for BattleRandomizer.xaml
    /// </summary>
    public partial class BattleRandomizer : Window
    {
        public BattleRandomizer()
        {
            InitializeComponent();
        }

        private void HomeMenuButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();
        }
    }
}

