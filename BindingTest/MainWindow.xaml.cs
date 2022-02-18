using System.ComponentModel;
using System.Windows;

namespace BindingTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MyClass Mcl { get; set; } = new MyClass();
        public MainWindow()
        {
            InitializeComponent();
            Mcl.Mytext = "hello";
            mygrid.DataContext = Mcl;//需要给mygrid控件指定DataContext为mcl，这是告诉Grid控件以及它子控件绑定源是谁
        }
    }
    /// <summary>
    /// Test
    /// </summary>
    public class MyClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _mytext;
        public string Mytext
        {
            get
            { return _mytext; }
            set
            {
                _mytext = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mytext"));
            }
        }
    }
}
