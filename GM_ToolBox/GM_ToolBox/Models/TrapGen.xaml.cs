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
    public enum DamageType
    {
        Poison,
        Bludgeoning,
        Slashing,
        Piercing,
        Fire,
        Cold,
        Acid,
        Lightning,
        Necrotic,
        Radiant,
        Crushing,
        Psychic,
        Force
    }

    public enum Difficulty
    {
        Easy,
        Medium,
        Hard,
        Mythic
    }

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

        public static Difficulty GetDifficulty()
        {
            Difficulty result;
            Random rando = new Random();
            int x = rando.Next(1, 101);
            if(x <= 40)
            {
                result = Difficulty.Easy;
            }
            else if(x > 40 && x <= 70)
            {
                result = Difficulty.Medium;
            }
            else if(x > 70 && x <= 90)
            {
                result = Difficulty.Hard;
            }
            else
            {
                result = Difficulty.Mythic;
            }

            return result;
        }

        public static DamageType GetDamageType()
        {
            DamageType result;
            Random rando = new Random();
            int x = rando.Next(1, 14);
            #region ifs
            if (x == 1)
            {
                result = DamageType.Acid;
            }
            else if (x == 2)
            {
                result = DamageType.Bludgeoning;
            }
            else if (x == 3)
            {
                result = DamageType.Cold;
            }
            else if (x == 4)
            {
                result = DamageType.Crushing;
            }
            else if (x == 5)
            {
                result = DamageType.Fire;
            }
            else if (x == 6)
            {
                result = DamageType.Force;
            }
            else if (x == 7)
            {
                result = DamageType.Lightning;
            }
            else if (x == 8)
            {
                result = DamageType.Necrotic;
            }
            else if (x == 9)
            {
                result = DamageType.Piercing;
            }
            else if (x == 10)
            {
                result = DamageType.Poison;
            }
            else if (x == 11)
            {
                result = DamageType.Psychic;
            }
            else if (x == 12)
            {
                result = DamageType.Radiant;
            }
            else
            {
                result = DamageType.Slashing;
            }
#endregion
            return result;
        }

        public static int GetSaveDC(Difficulty difficulty)
        {
            int result = 0;
            Random rando = new Random();

            #region ifs
            if(difficulty.Equals(Difficulty.Easy))
            {
                result = rando.Next(1, 16);
            }
            else if(difficulty.Equals(Difficulty.Medium))
            {
                result = rando.Next(10, 26);
            }
            else if (difficulty.Equals(Difficulty.Hard))
            {
                result = rando.Next(15, 31);
            }
            else if (difficulty.Equals(Difficulty.Mythic))
            {
                result = rando.Next(25, 41);
            }
            #endregion

            return result;
        }

        private void HomeMenuButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();
        }
    }
}
