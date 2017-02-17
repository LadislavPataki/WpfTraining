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

namespace Layout
{
    /// <summary>
    /// Interaction logic for LocalizableText.xaml
    /// </summary>
    public partial class LocalizableText : Window
    {
        public LocalizableText()
        {
            InitializeComponent();
        }

        private void ChangeTextCb_OnChecked(object sender, RoutedEventArgs e)
        {
            Prev.Content = "Go to the previous page";
            Next.Content = "Go to the next page";
            ChangeTextCb.Content = "Show short text";
        }

        private void ChangeTextCb_OnUnchecked(object sender, RoutedEventArgs e)
        {
            Prev.Content = "Prev";
            Next.Content = "Next";
            ChangeTextCb.Content = "Show long text";
        }
    }
}
