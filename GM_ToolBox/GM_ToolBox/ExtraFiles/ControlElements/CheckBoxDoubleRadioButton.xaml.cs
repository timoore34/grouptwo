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

namespace GM_Toolbox.ControlElements
{
    /// <summary>
    /// Interaction logic for CheckBoxDoubleRadioButton.xaml
    /// </summary>
    public partial class CheckBoxDoubleRadioButton : UserControl
    {
        private int labelFontSize;
        private int checkBoxSize;
        private string checkBoxContent;
        private string radioButtonOneContent;
        private string radioButtonTwoContent;
        private Brush textColor;
        private bool radioButtonOneEnable;
        private bool radioButtonTwoEnable;
        private bool radioButtonOneIsChecked;
        private bool radioButtonTwoIsChecked;
        public int LabelFontSize
        {
            get { return labelFontSize; }
            set
            {
                labelFontSize = value;
                EnableCheckBox.FontSize = labelFontSize - 2.5;
                RadioButtonOne.FontSize = labelFontSize;
                RadioButtonTwo.FontSize = labelFontSize;
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
        public string CheckBoxContent
        {
            get { return checkBoxContent; }
            set
            {
                checkBoxContent = value;
                EnableCheckBox.Content = checkBoxContent;
            }
        }
        public string RadioButtonOneContent
        {
            get { return radioButtonOneContent; }
            set
            {
                radioButtonOneContent = value;
                RadioButtonOne.Content = radioButtonOneContent;
            }
        }
        public string RadioButtonTwoContent
        {
            get { return radioButtonTwoContent; }
            set
            {
                radioButtonTwoContent = value;
                RadioButtonTwo.Content = radioButtonTwoContent;
            }
        }
        public Brush TextColor
        {
            get { return textColor; }
            set
            {
                textColor = value;
                EnableCheckBox.Foreground = textColor;
                RadioButtonOne.Foreground = textColor;
                RadioButtonTwo.Foreground = textColor;
            }
        }
        public bool RadioButtonOneEnable
        {
            get { return radioButtonOneEnable; }
            set
            {
                radioButtonOneEnable = value;
                RadioButtonOne.IsEnabled = radioButtonOneEnable;
            }
        }
        public bool RadioButtonTwoEnable
        {
            get { return radioButtonTwoEnable; }
            set
            {
                radioButtonTwoEnable = value;
                RadioButtonTwo.IsEnabled = radioButtonTwoEnable;
            }
        }
        public bool RadioButtonOneIsChecked
        {
            get { return radioButtonOneIsChecked; }
            set
            {
                radioButtonOneIsChecked = value;
                RadioButtonOne.IsChecked = radioButtonOneIsChecked;
            }
        }
        public bool RadioButtonTwoIsChecked
        {
            get { return radioButtonTwoIsChecked; }
            set
            {
                radioButtonTwoIsChecked = value;
                RadioButtonTwo.IsChecked = radioButtonTwoIsChecked;
            }
        }
        public CheckBoxDoubleRadioButton()
        {
            InitializeComponent();
        }
    }
}
