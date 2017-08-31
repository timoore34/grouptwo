using GM_ToolBox.ExtraFiles.Enums;
using GM_ToolBox.ExtraFiles.Parsing;
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
    /// Interaction logic for NPCGen.xaml
    /// </summary>
    public partial class NPCGen : Window
    {
        private MainWindow location;
        private Races? race;
        private List<int> statList = new List<int>();
        private List<TextBox> statValues = new List<TextBox>();
        private Dictionary<Races, Race> raceData = new Dictionary<Races, Race>();
        public NPCGen(MainWindow location)
        {
            InitializeComponent();
            this.location = location;
            SetUp();
        }
        private void SetUp()
        {
            FileStream fs = new FileStream("BackgroundData/RaceDataFile.rce", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            raceData = (Dictionary<Races, Race>)formatter.Deserialize(fs);
            fs.Close();

            statValues.Add(StrStat.TextField);
            statValues.Add(DexStat.TextField);
            statValues.Add(ConStat.TextField);
            statValues.Add(IntStat.TextField);
            statValues.Add(WisStat.TextField);
            statValues.Add(ChaStat.TextField);

            StrStat.TextField.TextChanged += StatRangeTypeCheck;
            StrStat.TextField.LostFocus += StatRangeFocusCheck;
            DexStat.TextField.TextChanged += StatRangeTypeCheck;
            DexStat.TextField.LostFocus += StatRangeFocusCheck;
            ConStat.TextField.TextChanged += StatRangeTypeCheck;
            ConStat.TextField.LostFocus += StatRangeFocusCheck;
            IntStat.TextField.TextChanged += StatRangeTypeCheck;
            IntStat.TextField.LostFocus += StatRangeFocusCheck;
            WisStat.TextField.TextChanged += StatRangeTypeCheck;
            WisStat.TextField.LostFocus += StatRangeFocusCheck;
            ChaStat.TextField.TextChanged += StatRangeTypeCheck;
            ChaStat.TextField.LostFocus += StatRangeFocusCheck;

            SkillSelection.Click += SkillEnableEvent;
            SavingSelection.Click += SavingThrowEnableEvent;

            RaceSelection.ListDropDown.ItemsSource = Enum.GetValues(typeof(Races)).OfType<Races>().Select(e => e.RaceToString());
            RaceSelection.ListDropDown.SelectionChanged += RaceChanged;

            ReturnHomeButton.Click += HomeButtonClickEvent;
        }

        private void RaceChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox tempBox = (ComboBox)sender;
            if (tempBox.SelectedIndex == -1)
            {
                race = null;
            }
            else
            {
                race = (Races)Enum.Parse(typeof(Races), tempBox.SelectedValue.ToString().Replace(" ", "_"));
            }
        }

        private void StatRangeFocusCheck(object sender, RoutedEventArgs e)
        {
            TextBox text = (TextBox)sender;
            int value;
            if (int.TryParse(text.Text, out value))
            {
                text.Text = value < 7 ? "7" : $"{value}";
            }
            text.CaretIndex = text.Text.Length;
        }
        private void StatRangeTypeCheck(object sender, TextChangedEventArgs e)
        {
            TextBox text = (TextBox)sender;
            int value;
            if (int.TryParse(text.Text, out value))
            {
                value = value > 18 ? 18 : value;
                text.Text = $"{value}";
                text.Text = value < 0 ? $"{Math.Abs(value)}" : $"{value}";
            }
            else
            {
                text.Text = text.Text.Length == 0 ? "" : text.Text.TrimEnd(text.Text.Last());
            }
            text.CaretIndex = text.Text.Length;
        }
        private void GenerateAbilityScore(Races? race = null)
        {
            int value, defaultValue = -10;
            Race selectedRace;
            statList.Clear();
            if (race != null)
            {
                if (raceData.TryGetValue((Races)race, out selectedRace))
                {
                    statList.Add(selectedRace.StrBonus);
                    statList.Add(selectedRace.DexBonus);
                    statList.Add(selectedRace.ConBonus);
                    statList.Add(selectedRace.IntBonus);
                    statList.Add(selectedRace.WisBonus);
                    statList.Add(selectedRace.ChaBonus);
                }
                for (int stat = 0; stat < statValues.Count; stat++)
                {
                    if (int.TryParse(statValues.ElementAt(stat).Text, out value))
                    {
                        statList.Insert(stat, statList.ElementAt(stat) + value);
                        statList.RemoveAt(stat);
                    }
                    else
                    {
                        if (statList.ElementAt(stat) == 0)
                        {
                            statList.Insert(stat, defaultValue);
                            statList.RemoveAt(stat);
                        }
                        else
                        {
                            statList.Insert(stat, (statList.ElementAt(stat) * -1));
                            statList.RemoveAt(stat);
                        }

                    }
                }
            }
            else
            {
                foreach (TextBox text in statValues)
                {
                    if (int.TryParse(text.Text, out value))
                    {
                        statList.Add(value);
                    }
                    else
                    {
                        statList.Add(defaultValue);
                    }
                }
            }
            MessageBox.Show($"{statList.ElementAt(0)} {statList.ElementAt(1)} {statList.ElementAt(2)} {statList.ElementAt(3)} {statList.ElementAt(4)} {statList.ElementAt(5)}");
        }
        private void GenerateCharacter(object sender, RoutedEventArgs e)
        {
            GenerateAbilityScore(race);
        }
        private void HomeButtonClickEvent(object sender, RoutedEventArgs e)
        {
            location.CloseChildWindows(this);
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

