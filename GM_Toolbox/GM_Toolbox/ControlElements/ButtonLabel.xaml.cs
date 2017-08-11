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
    /// A control element that provides access to a labeled button.
    /// </summary>
    public partial class ButtonLabel : UserControl
    {
        private int labeledButtonWidth;
        private int labeledButtonHeight;
        private Brush labelColor;
        private string labelContent;
        public int LabeledButtonWidth
        {
            get { return labeledButtonWidth; }
            set
            {
                labeledButtonWidth = value;
                LabeledButton.Width = labeledButtonWidth;
            }
        }
        public int LabeledButtonHeight
        {
            get { return labeledButtonHeight; }
            set
            {
                labeledButtonHeight = value;
                LabeledButton.Height = labeledButtonHeight;
            }
        }
        public Brush LabelColor
        {
            get { return labelColor; }
            set
            {
                labelColor = value;
                ButtonLabel.Foreground = labelColor;
            }
        }
        public string LabelContent
        {
            get { return labelContent; }
            set
            {
                labelContent = value;
                ButtonLabel.Content = labelContent;
            }
        }
        public ButtonLabel()
        {
            InitializeComponent();
        }
    }
}
