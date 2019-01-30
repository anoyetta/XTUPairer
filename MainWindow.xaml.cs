using System.Windows;
using System.Windows.Input;
using Prism.Commands;

namespace XTUPairer
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private volatile bool toEnd = false;

        public MainWindow()
        {
            this.InitializeComponent();

            this.Closing += (_, e) =>
            {
                if (this.toEnd)
                {
                    return;
                }

                e.Cancel = true;
                this.Hide();
            };
        }

        private ICommand endCommand;

        public ICommand EndCommand => this.endCommand ?? (this.endCommand = new DelegateCommand(() =>
        {
            this.toEnd = true;
            this.Close();
        }));

        private ICommand showCommand;

        public ICommand ShowCommand => this.showCommand ?? (this.showCommand = new DelegateCommand(() =>
        {
            this.Show();
        }));

        private ICommand hideCommand;

        public ICommand HideCommand => this.hideCommand ?? (this.hideCommand = new DelegateCommand(() =>
        {
            this.Hide();
        }));

        private ICommand toggleCommand;

        public ICommand ToggleCommand => this.toggleCommand ?? (this.toggleCommand = new DelegateCommand(() =>
        {
            if (this.Visibility == Visibility.Visible)
            {
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }));
    }
}
