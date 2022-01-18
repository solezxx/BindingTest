using System.ComponentModel;
using System.Windows;

namespace BindingTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public myClass mcl { get; set; } = new myClass();
        public MainWindow()
        {
            InitializeComponent();
            mcl.mytext = "hello";
            mygrid.DataContext = mcl;//需要给mygrid控件指定DataContext为mcl，这是告诉Grid控件以及它子控件绑定源是谁
        }
    }

    public class myClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _mytext;
        public string mytext
        {
            get
            { return _mytext; }
            set
            {
                _mytext = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("mytext"));
            }
        }
    }
}
