using System.Windows;

namespace ParseHypemJsonWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Manager _manager;


        public MainWindow()
        {
            InitializeComponent();
            _manager = new Manager();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            _manager.CreateBatchFile();

        }
    }
}
