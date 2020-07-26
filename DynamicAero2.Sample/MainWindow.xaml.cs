using System.Windows;

namespace DynamicAero2.Sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var theme = Application.Current.Resources.MergedDictionaries[0] as DynamicAero2.Theme;
            if (theme is null) return;

            theme.Color = theme.Color switch
            {
                ThemeColor.NormalColor => ThemeColor.Dark,
                ThemeColor.Dark => ThemeColor.Light,
                _ => ThemeColor.NormalColor
            };
        }
    }
}
