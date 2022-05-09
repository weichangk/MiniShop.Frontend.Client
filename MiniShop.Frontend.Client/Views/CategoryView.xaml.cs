using System;
using System.Collections.Generic;
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

namespace MiniShop.Frontend.Client.Views
{
    /// <summary>
    /// CategoryView.xaml 的交互逻辑
    /// </summary>
    public partial class CategoryView : UserControl
    {
        public CategoryView()
        {
            InitializeComponent();
        }

        private void Left_Click(object sender, RoutedEventArgs e)
        {
            CategoryScrollViewer.PageLeft();
        }

        private void Right_Click(object sender, RoutedEventArgs e)
        {
            CategoryScrollViewer.PageRight();
        }
    }
}
