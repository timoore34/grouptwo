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

namespace GM_ToolBox.ExtraFiles.ControlElements
{
    /// <summary>
    /// Interaction logic for CheckBoxOneLabeledTextField.xaml
    /// </summary>
    public partial class CheckBoxOneLabeledTextField : UserControl
    {
        private int labelFontSize;
        private int textBoxWidth;
        private string labelContent;
        private string checkBoxContent;
        private Brush labelColor;
        private bool textBoxEnable;
        private bool checkBoxElementEnableEvent;
        public int LabelFontSize
        {
            get { return labelFontSize; }
            set
            {
                labelFontSize = value;
                EnableCheckBox.FontSize = labelFontSize - 2;
                TextFieldLabel.FontSize = labelFontSize;
            }
        }
        public int TextBoxWidth
        {
            get { return textBoxWidth; }
            set
            {
                textBoxWidth = value;
                TextField.Width = textBoxWidth;
            }
         }
        public string LabelContent
        {
            get { return labelContent; }
            set
            {
                labelContent = value;
                TextFieldLabel.Content = labelContent;
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
        public Brush LabelColor
        {
            get { return labelColor; }
            set
            {
                labelColor = value;
                EnableCheckBox.Foreground = labelColor;
                TextFieldLabel.Foreground = labelColor;
            }
        }
        public bool TextBoxEnable
        {
            get { return textBoxEnable; }
            set
            {
                textBoxEnable = value;
                TextField.IsEnabled = textBoxEnable;
            }
        }
        public bool CheckBoxElementEnableEvent
        {
            get { return checkBoxElementEnableEvent; }
            set
            {
                checkBoxElementEnableEvent = value;
                if (checkBoxElementEnableEvent)
                {
                    EnableCheckBox.Click += EnableChange;
                }
                else
                {
                    EnableCheckBox.Click -= EnableChange;
                }
            }
        }
        public CheckBoxOneLabeledTextField()
        {
            InitializeComponent();
        }
        private void EnableChange(object sender, RoutedEventArgs e)
        {
            TextBoxEnable = (bool)EnableCheckBox.IsChecked;
            TextField.Clear();
        }
    }
}
