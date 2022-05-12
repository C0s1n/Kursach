using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Kotin_Curs.Views
{
    public partial class SecondView : UserControl
    {
        public SecondView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
