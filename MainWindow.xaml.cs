using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AutoSearchCombobox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            AutoCombobox.Loaded += delegate
            {
                var textBox = AutoCombobox.Template.FindName("PART_EditableTextBox", AutoCombobox) as TextBox;
                var popup = AutoCombobox.Template.FindName("PART_Popup", AutoCombobox) as Popup;

                if (textBox != null)
                {

                    textBox.TextChanged += delegate
                    {
                        AutoCombobox.Items.Filter += a =>
                        {
                            var al = a.ToString().ToLower();
                            var tl = textBox.Text.ToLower();
                            if (al.StartsWith(tl))
                            {
                                return true;
                            }
                            return false;
                        };
                        popup.IsOpen = true;
                    };
                }
            };
        }
    }
}
