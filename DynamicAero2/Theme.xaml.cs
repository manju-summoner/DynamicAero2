using System;
using System.Windows;

namespace DynamicAero2
{
    partial class Theme
    {
        ThemeColor color;
        public ThemeColor Color
        {
            get => color;
            set
            {
                if (color == value) return;
                color = value;
                SetColor(color);
            }
        }

        public Theme()
        {
            InitializeComponent();
        }
        void SetColor(ThemeColor color)
        {
            MergedDictionaries[0] = new ResourceDictionary() { Source = new Uri($"/DynamicAero2;component/Brushes/{color}.xaml", UriKind.Relative) };
        }
    }
}
