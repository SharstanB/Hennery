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
using Hennery.Views.OperationsWin;

namespace Hennery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ItemsWin ItemWin;
        private OperationsWin operationWin;
        public MainWindow()
        {
            InitializeComponent();
           
        }

       
        private void PopupBox_OnOpened(object sender, RoutedEventArgs e)
        {
           
        }

        private void PopupBox_OnClosed(object sender, RoutedEventArgs e)
        {
          }
        private void ItemBtm_OnClick(object sender, RoutedEventArgs e)
        {
            ItemWin = new ItemsWin();
            ItemWin.ShowDialog();
        }

        private void OperationBtm_OnClick(object sender, RoutedEventArgs e)
        {
           operationWin=new OperationsWin();
            operationWin.ShowDialog();
        }
    }
}
