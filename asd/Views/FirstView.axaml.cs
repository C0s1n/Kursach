using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Kotin_Curs.Views
{
    public partial class FirstView : UserControl
    {
        public FirstView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
