using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace C0s_Curs.Views
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
