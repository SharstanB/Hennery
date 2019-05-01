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
using MaterialDesignThemes.Wpf;

namespace Hennery.Views.OperationsWin
{
    /// <summary>
    /// Interaction logic for SupplyingCon.xaml
    /// </summary>
    public partial class SupplyingCon : UserControl
    {
        private ItemsWin ItemsWin;
        public SupplyingCon()
        {
            InitializeComponent();
        }

      
        private void Sample1_DialogHost_OnDialogClosing(object sender, DialogClosingEventArgs eventargs)
        {
           
        }

        private void ButtonEdit_OnClick(object sender, RoutedEventArgs e)
        {
          
        }

        private void ButtonDelete_OnClick(object sender, RoutedEventArgs e)
        {
           
        }

        private void ButtonShow_OnClick(object sender, RoutedEventArgs e)
        {
           
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            ItemsWin=new ItemsWin();
            ItemsWin.ShowDialog();
        }
    }
}
