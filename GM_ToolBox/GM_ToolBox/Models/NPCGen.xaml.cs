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
            RaceSelection.ListDropDown.ItemsSource = races;
            ReturnHomeButton.Click += HomeButtonClickEvent;
            RaceSelection.EnableCheckBox.Click += RaceIncludeChange;
            NameField.EnableCheckBox.Click += NameIncludeChange;
            GenderField.EnableCheckBox.Click += GenderIncludeChange;
        }
        private void HomeButtonClickEvent(object sender, RoutedEventArgs e)
        {
            location.CloseChildWindows(this);
        }
        private void RaceIncludeChange(object sender, RoutedEventArgs e)
        {
            RaceSelection.ComboBoxEnableState = (bool)RaceSelection.EnableCheckBox.IsChecked;
            RaceSelection.ListDropDown.SelectedIndex = -1;
        }
        private void NameIncludeChange(object sender, RoutedEventArgs e)
        {
            NameField.FirstTextBoxEnableState = (bool)NameField.EnableCheckBox.IsChecked;
            NameField.SecondTextBoxEnableState = (bool)NameField.EnableCheckBox.IsChecked;
            NameField.ThirdTextBoxEnableState = (bool)NameField.EnableCheckBox.IsChecked;
            NameField.FirstTextBox.Clear();
            NameField.SecondTextBox.Clear();
            NameField.ThirdTextBox.Clear();
        }
        private void GenderIncludeChange(object sender, RoutedEventArgs e)
        {
            GenderField.RadioButtonOneEnable = (bool)GenderField.EnableCheckBox.IsChecked;
            GenderField.RadioButtonTwoEnable = (bool)GenderField.EnableCheckBox.IsChecked;
            GenderField.RadioButtonOne.IsChecked = false;
            GenderField.RadioButtonTwo.IsChecked = false;
        }
    }
}

