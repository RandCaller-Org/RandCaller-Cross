using Avalonia.Input;
using FluentAvalonia.UI.Windowing;

namespace RandCaller_Cross
{
    public partial class MainWindow : FAAppWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            TitleBar.ExtendsContentIntoTitleBar = true;
            TitleBar.Height = 48;
        }

        private void TitleBarHost_PointerPressed(object? sender, PointerPressedEventArgs e)
        {
            if (e.GetCurrentPoint(this).Properties.IsLeftButtonPressed)
            {
                BeginMoveDrag(e);
            }
        }
    }
}