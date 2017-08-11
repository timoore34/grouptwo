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
using GM_Toolbox.Models;

namespace GM_Toolbox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RandomBattleMenuButton_Click(object sender, RoutedEventArgs e)
        {
            BattleRandomizer br = new BattleRandomizer();
            this.Close();
            br.Show();
        }

        private void RandomTrapMenuButton_Click(object sender, RoutedEventArgs e)
        {
            TrapGen tg = new TrapGen();
            this.Close();
            tg.Show();
        }

        private void AreaGenMenuButton_Click(object sender, RoutedEventArgs e)
        {
            AreaGen ag = new AreaGen();
            this.Close();
            ag.Show();
        }

        private void NPCMenuButton_Click(object sender, RoutedEventArgs e)
        {
            NPCGen ng = new NPCGen();
            this.Close();
            ng.Show();
        }

        private void LootMenuButton_Click(object sender, RoutedEventArgs e)
        {
            LootGen lg = new LootGen();
            this.Close();
            lg.Show();
        }

        private void PlayerMenuButton_Click(object sender, RoutedEventArgs e)
        {
            PlayerMenu pm = new PlayerMenu();
            this.Close();
            pm.Show();
        }

        private void DiceRollerMenuButton_Click(object sender, RoutedEventArgs e)
        {
            DieRoller dr = new DieRoller();
            this.Close();
            dr.Show();
        }
    }
}