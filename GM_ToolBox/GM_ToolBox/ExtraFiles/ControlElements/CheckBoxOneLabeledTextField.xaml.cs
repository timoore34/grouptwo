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
        private int LabelFontSize;
        private int TextBoxWidth;
        private string LabelContent;
        private string CheckBoxContent;
        private Brush LabelColor;
        public CheckBoxOneLabeledTextField()
        {
            InitializeComponent();
        }
    }
}
