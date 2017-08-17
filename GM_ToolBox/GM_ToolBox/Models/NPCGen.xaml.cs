using GM_ToolBox.ExtraFiles.Parsing;
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
    /// Interaction logic for NPCGen.xaml
    /// </summary>
    public partial class NPCGen : Window
    {
        private MainWindow location;
        private List<string> races = new List<string> { "kjljk", "jsldfjdkls", "sdflsdjf" };
        public NPCGen(MainWindow location)
        {
            InitializeComponent();
            this.location = location;
            SetUp();
        }
        private void SetUp()
        {
            //RaceSelection.ListDropDown.ItemsSource = races;
            ReturnHomeButton.Click += HomeButtonClickEvent;
            SkillSelection.Click += SkillEnableEvent;
            EnableSpecialRacialBonus.Click += SpecialEnalbleEvent;
            SavingSelection.Click += SavingThrowEnableEvent;
        }
        private void HomeButtonClickEvent(object sender, RoutedEventArgs e)
        {
            location.CloseChildWindows(this);
        }
        private void SpecialEnalbleEvent(object sender, RoutedEventArgs e)
        {
            foreach (CheckBox trait in SpecialBonusPanel.Children)
            {
                trait.IsEnabled = (bool)EnableSpecialRacialBonus.IsChecked;
                trait.IsChecked = false;
            }
        }
        private void SkillEnableEvent(object sender, RoutedEventArgs e)
        {
            foreach (CheckBox skill in SkillPanel.Children)
            {
                skill.IsEnabled = (bool)SkillSelection.IsChecked;
                skill.IsChecked = false;
            }
        }
        private void SavingThrowEnableEvent(object sender, RoutedEventArgs e)
        {
            foreach (CheckBox save in SavingThrowPanel.Children)
            {
                save.IsEnabled = (bool)SavingSelection.IsChecked;
                save.IsChecked = false;
            }
        }
    }
}

