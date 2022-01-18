using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
