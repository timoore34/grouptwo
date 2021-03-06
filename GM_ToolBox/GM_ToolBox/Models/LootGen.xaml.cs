﻿using GM_ToolBox.ExtraFiles.Parsing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
    /// Interaction logic for LootGen.xaml
    /// </summary>
    public partial class LootGen : Window
    {
        private List<Item> item = new List<Item>()
        {
                new Item("Gold", 25, false, "Here's 25 gold. Try investing into your future a bit more."),
                new Item("Gold", 50, false, "Here's 50 gold. spend it wisely"),
                new Item("Gold", 150, false, "Here's 150 gold. Treat yourself to a visit at your local bar and go crazy."),
                new Item("Fancy Looking Hat", 65, false, "The quality of this hat is superb. you recon it could save your life"
                    + "from a sword swing.\n+1 to your AC"),
                new Item("Twig", 0, false, "I dont even know why you want this in your inventory"),
                new Item("Broadsword", 175, true, "This sword is what is commonly carried around by knights of your local kingdom. As you inspect"
                +" your newfound blade, you notice the crest on the hilt of the sword is glowing slightly. If the blade found you to be knightly like its predesesor, it"
                +" would probably grant you even greater strength\n+1 damage to Knights serving in the military"),
                new Item("Apple", 25, false, "A delicious fruit or a light snack. Whichever you prefer, you would feel envigorated after ingesting.\nRecover 3HP"),
                new Item("Ex-Calibur", 300, true, "The son of excalibur who hold more power than even the gods. This sword contains sentience and never "
                    + "claimed a master worthy enough to wield him. Hopefully your party is prepared for him")
        };
        bool[] Rarities = new bool[10];
        int sliderNumber = 1;

        public LootGen()
        {
            InitializeComponent();
        }

        private void HomeMenuButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();
        }
        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {


            Random randalf = new Random();
            string returnToUser = "";
            try
            {
                if (!TotalItems.Text.Equals(""))
                {
                    sliderNumber = int.Parse(TotalItems.Text);
                }
                for (int i = 0; i < sliderNumber; i++)
                {
                    returnToUser += item[randalf.Next(0, 8)].toString() + "\n\n";
                }
                ResultTextBlock.Text = returnToUser;
            }
            catch (Exception)
            {
                ResultTextBlock.Text = "Value in \"Total Items\" box was found no to have a number in it. ";
            }



        }

        private void SelectAll_Checked(object sender, RoutedEventArgs e)
        {
            for (int i = 1; i < Rarities.Length; i++)
            {
                Rarities[i] = true;
            }
        }
        private void selectAll_Unchecked(object sender, RoutedEventArgs e)
        {
            for (int i = 1; i < Rarities.Length; i++)
            {
                Rarities[i] = false;
            }
        }
        private void SelectRarity()
        {

        }

        private void slider_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            sliderNumber = int.Parse(sender.ToString());
        }

        private void inputItems_Click(object sender, RoutedEventArgs e)
        {

            FileStream fs = new FileStream("", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            //List<Item> dataList
            item = (List<Item>)formatter.Deserialize(fs);
            fs.Close();

            //to serialize the data just do the same thing but
            formatter.Serialize(fs, item);
            //This way you have all the data stored in an List that is easly assessable and changable
            
        }
    }
}
