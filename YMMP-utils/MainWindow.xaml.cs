using iNKORE.UI.WPF.Modern.Controls;
using System.Configuration;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using YMMP_utils.Properties;


namespace YMMP_utils
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void NavToPage(string page)
        {
            var pageType = Type.GetType("YMMP_utils.Views." + page);
            if (pageType != null)
            {
                Frame.Navigate(pageType);
            }
            else
            {
                Debug.WriteLine("ページが見つかりません: " + page);
            }
        }
        public MainWindow()
        {
            InitializeComponent();

            Frame.Navigate(typeof(YMMP_utils.Views.HomePage));
        }

        private void nav_SelectionChanged(iNKORE.UI.WPF.Modern.Controls.NavigationView sender, iNKORE.UI.WPF.Modern.Controls.NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {
                // SettingsPage の名前空間を明示的に指定
                Frame.Navigate(typeof(YMMP_utils.Views.SettingsPage));
            }
            else
            {
                var item = args.SelectedItemContainer as NavigationViewItem; // NavigationViewItem の型が見つからないエラーを修正

                NavToPage(item.Tag.ToString());
            }
        }
    }
}