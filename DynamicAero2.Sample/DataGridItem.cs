using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DynamicAero2.Sample
{
    internal class DataGridItem
    {
        public bool? Check { get; set; }
        public string Text { get; set; }
        public Key ComboBox { get; set; }

        public static DataGridItem[] Source { get; } = new[]
        {
            new DataGridItem { Check = true, Text = "Item 1", ComboBox = Key.A },
            new DataGridItem { Check = null, Text = "Item 2", ComboBox = Key.B },
            new DataGridItem { Check = false, Text = "Item 3", ComboBox = Key.C },
        };
        public static Key[] KeySource { get; } = Enum.GetValues(typeof(Key)).Cast<Key>().ToArray();
    }
}
