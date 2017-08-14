﻿using System;
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
    /// Interaction logic for DieRoller.xaml
    /// </summary>
    public partial class DieRoller : Window
    {
        public DieRoller()
        {
            InitializeComponent();
        }

        private void HomeMenuButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();
        }

        private void RollButton_Click(object sender, RoutedEventArgs e)
        {

            //SplashScreen splash = new SplashScreen(@"C:\Users\Bradly Holland-Hedge\Documents\GitHub\grouptwo\GM_ToolBox\GM_ToolBox\ExtraFiles\ElDierado.gif");
            //splash.Show(true);
            ResultLabel.Content = RollDie((int.Parse(NumOfDiceBox.Text)), (int.Parse(TypeOfDiceBox.Text)), (int.Parse(ModBox.Text)));
        }

        private int RollDie(int numOfDice, int numOfSides, int mod)
        {
            Random rando = new Random();
            int sum = 0;


            for(int i = 0; i < numOfDice; i++)
            {
                sum += rando.Next(1, numOfSides + 1);
            }
            sum = sum + mod;

            return sum;
        }
    }
}
