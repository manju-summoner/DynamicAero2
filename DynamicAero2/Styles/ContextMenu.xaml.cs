using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Threading;

namespace DynamicAero2.Styles
{
    partial class ContextMenu
    {
        public ContextMenu()
        {
            InitializeComponent();

            AddPrivateControlStyle(typeof(Application).Assembly.GetType("System.Windows.Documents.TextEditorContextMenu+EditorContextMenu"), typeof(System.Windows.Controls.ContextMenu));
            AddPrivateControlStyle(typeof(Application).Assembly.GetType("System.Windows.Documents.TextEditorContextMenu+EditorMenuItem"), typeof(System.Windows.Controls.MenuItem));
        }
        void AddPrivateControlStyle(Type targetType, Type baseType)
        {
            var baseStyle = this[baseType] as Style;
            var style = new Style(targetType, baseStyle);
            this.Add(targetType, style);
        }
    }
}
