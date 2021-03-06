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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GM_ToolBox.ExtraFiles.ControlElements
{
    /// <summary>
    /// This control gives you a checkbox that can be used to endable or disable use of control elements.
    /// While providing three textbox fields for text entry.
    /// </summary>
    public partial class NameTextEntryCheckBox : UserControl
    {
        private int textBoxHeight;
        private int textBoxFontSize;
        private int labelFontSize;
        private int firstTextBoxWidth;
        private int secondTextBoxWidth;
        private int thirdTextBoxWidth;
        private int checkBoxSize;
        private Brush labelColor;
        private string checkBoxContent;
        private string firstLabelContent;
        private string secondLabelContent;
        private string thirdLabelContent;
        private bool firstTextBoxEnableState;
        private bool secondTextBoxEnableState;
        private bool thirdTextBoxEnableState;
        private bool checkBoxElementEnableEvent;
        public int TextBoxHeight
        {
            get { return textBoxHeight; }
            set
            {
                textBoxHeight = value;
                FirstTextBox.Height = textBoxHeight;
                SecondTextBox.Height = textBoxHeight;
                ThirdTextBox.Height = textBoxHeight;
            }
        }
        public int TextBoxFontSize
        {
            get { return textBoxFontSize; }
            set
            {
                textBoxFontSize = value;
                FirstTextBox.FontSize = textBoxFontSize;
                SecondTextBox.FontSize = textBoxFontSize;
                ThirdTextBox.FontSize = textBoxFontSize;
            }
        }
        public int LabelFontSize
        {
            get { return labelFontSize; }
            set
            {
                labelFontSize = value;
                EnableCheckBox.FontSize = labelFontSize - 2.5;
                FirstLabel.FontSize = labelFontSize;
                SecondLabel.FontSize = LabelFontSize;
                ThirdLabel.FontSize = LabelFontSize;
            }
        }
        public int FirstTextBoxWidth
        {
            get { return firstTextBoxWidth; }
            set
            {
                firstTextBoxWidth = value;
                FirstTextBox.Width = firstTextBoxWidth;
            }
        }
        public int SecondTextBoxWidth
        {
            get { return secondTextBoxWidth; }
            set
            {
                secondTextBoxWidth = value;
                SecondTextBox.Width = secondTextBoxWidth;
            }
        }
        public int ThirdTextBoxWidth
        {
            get { return thirdTextBoxWidth; }
            set
            {
                thirdTextBoxWidth = value;
                ThirdTextBox.Width = thirdTextBoxWidth;
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
        public Brush LabelColor
        {
            get { return labelColor; }
            set
            {
                labelColor = value;
                EnableCheckBox.Foreground = labelColor;
                FirstLabel.Foreground = labelColor;
                SecondLabel.Foreground = labelColor;
                ThirdLabel.Foreground = labelColor;
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
        public string FirstLabelContent
        {
            get { return firstLabelContent; }
            set
            {
                firstLabelContent = value;
                FirstLabel.Content = firstLabelContent;
            }
        }
        public string SecondLabelContent
        {
            get { return secondLabelContent; }
            set
            {
                secondLabelContent = value;
                SecondLabel.Content = secondLabelContent;
            }
        }
        public string ThirdLabelContent
        {
            get { return thirdLabelContent; }
            set
            {
                thirdLabelContent = value;
                ThirdLabel.Content = thirdLabelContent;
            }
        }
        public bool FirstTextBoxEnableState
        {
            get { return firstTextBoxEnableState; }
            set
            {
                firstTextBoxEnableState = value;
                FirstTextBox.IsEnabled = firstTextBoxEnableState;
            }
        }
        public bool SecondTextBoxEnableState
        {
            get { return secondTextBoxEnableState; }
            set
            {
                secondTextBoxEnableState = value;
                SecondTextBox.IsEnabled = secondTextBoxEnableState;
            }
        }
        public bool ThirdTextBoxEnableState
        {
            get { return thirdTextBoxEnableState; }
            set
            {
                thirdTextBoxEnableState = value;
                ThirdTextBox.IsEnabled = thirdTextBoxEnableState;
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
        public NameTextEntryCheckBox()
        {
            InitializeComponent();
        }
        private void EnableChange(object sender, RoutedEventArgs e)
        {
            FirstTextBoxEnableState = (bool)EnableCheckBox.IsChecked;
            SecondTextBoxEnableState = (bool)EnableCheckBox.IsChecked;
            ThirdTextBoxEnableState = (bool)EnableCheckBox.IsChecked;
            FirstTextBox.Clear();
            SecondTextBox.Clear();
            ThirdTextBox.Clear();
        }
    }
}