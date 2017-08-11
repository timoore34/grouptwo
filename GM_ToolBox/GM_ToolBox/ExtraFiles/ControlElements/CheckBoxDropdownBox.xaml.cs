using System;
using System.Collections;
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

namespace GM_Toolbox.ControlElements
{
    /// <summary>
    /// Creates a CheckBox and ComboBox element
    /// </summary>
    public partial class CheckBoxDropdownBox : UserControl
    {
        private int checkBoxTextFontSize;
        private int checkBoxSize;
        private int dropDownListWidth;
        private int dropDownListHeight;
        private string checkBoxContent;
        private Brush textColor;
        private IEnumerable dropDownListItems;
        private bool comboBoxEnableState;
        public int CheckBoxTextFontSize
        {
            get { return checkBoxTextFontSize; }
            set
            {
                checkBoxTextFontSize = value;
                EnableCheckBox.FontSize = checkBoxTextFontSize - 2.5;
            }
        }
        public int CheckBoxSize
        {
            get { return checkBoxSize; }
            set
            {
                checkBoxSize = value;
                CheckSize.Height = checkBoxSize;
            }
        }
        public int DropDownListWidth
        {
            get { return dropDownListWidth; }
            set
            {
                dropDownListWidth = value;
                ListDropDown.Width = dropDownListWidth;
            }
        }
        public int DropDownListHeight
        {
            get { return dropDownListHeight; }
            set
            {
                dropDownListHeight = value;
                ListDropDown.Height = dropDownListHeight;
            }
        }
        public string CheckBoxContent
        {
            get { return checkBoxContent; }
            set
            {
                checkBoxContent = value;
                EnableCheckBox.Content = checkBoxContent;
            }
        }
        public IEnumerable DropDownListItems
        {
            get { return dropDownListItems; }
            set
            {
                dropDownListItems = value;
                ListDropDown.ItemsSource = dropDownListItems;
            }
        }
        public bool ComboBoxEnableState
        {
            get { return comboBoxEnableState; }
            set
            {
                comboBoxEnableState = value;
                ListDropDown.IsEnabled = comboBoxEnableState;
            }
        }
        public Brush TextColor
        {
            get { return textColor; }
            set
            {
                textColor = value;
                EnableCheckBox.Foreground = textColor;
            }
        }
        public CheckBoxDropdownBox()
        {
            InitializeComponent();
        }
    }
}