using System.Windows;
using WpfApp1.ViewModel;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {   
            InitializeComponent();
            
            DataContext = new MyMain();
        }
    }
}
