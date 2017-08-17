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
            int numOfDice = 0, typeOfDice = 0, mod = 0;
            bool isValid = true;
            try
            {
                numOfDice = int.Parse(NumOfDiceBox.Text);
                typeOfDice = int.Parse(TypeOfDiceBox.Text);
                mod = int.Parse(ModBox.Text);
            }
            catch (FormatException)
            {
                //exception code here
            }
            if (isValid)
            {
                if (numOfDice < 0)
                {
                    //negative message here
                }
                else if (typeOfDice < 0)
                {
                    //negative message here
                }
                else
                {
                    //SplashScreen splash = new SplashScreen(@"C:\Users\Bradly Holland-Hedge\Documents\GitHub\grouptwo\GM_ToolBox\GM_ToolBox\ExtraFiles\ElDierado.gif");
                    //splash.Show(true);
                    if ((bool)AdvantageBox.IsChecked)
                    {
                        int resultOne = RollDie(numOfDice, typeOfDice, mod), resultTwo = RollDie(numOfDice, typeOfDice, mod);
                        ResultLabel.Content = resultOne;
                        DadvResultLabel.Content = resultTwo;
                        if (resultOne > resultTwo)
                        {
                            ResultLabel.Foreground = Brushes.Purple;
                            DadvResultLabel.Foreground = Brushes.Brown;
                        }
                        else
                        {
                            ResultLabel.Foreground = Brushes.Brown;
                            DadvResultLabel.Foreground = Brushes.Purple;
                        }
                    }
                    else if ((bool)DisadvBox.IsChecked)
                    {
                        int resultOne = RollDie(numOfDice, typeOfDice, mod), resultTwo = RollDie(numOfDice, typeOfDice, mod);
                        ResultLabel.Content = resultOne;
                        DadvResultLabel.Content = resultTwo;
                        if (resultOne < resultTwo)
                        {
                            ResultLabel.Foreground = Brushes.Purple;
                            DadvResultLabel.Foreground = Brushes.Brown;
                        }
                        else
                        {
                            ResultLabel.Foreground = Brushes.Brown;
                            DadvResultLabel.Foreground = Brushes.Purple;
                        }
                    }
                    else
                    {
                        ResultLabel.Content = RollDie(numOfDice, typeOfDice, mod);
                        ResultLabel.Foreground = Brushes.Purple;
                        DadvResultLabel.Content = "";
                    }
                }
            }
        }
        Random rando = new Random();
        private int RollDie(int numOfDice, int numOfSides, int mod)
        {
            
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

