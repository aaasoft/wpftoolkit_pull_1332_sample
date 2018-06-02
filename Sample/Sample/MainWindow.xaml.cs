using Sample.Model;
using System;
using System.Linq;
using System.Text;
using System.Windows;

namespace Sample
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var model_0 = new Model_0();
            model_0.Model1List.Add(new Model_1());
            propertyGrid.SelectedObject = model_0;
        }
    }
}
