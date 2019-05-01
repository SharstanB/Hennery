using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Hennery.Models;
using Hennery.Views.ItemWin;
using Hennery.Views.OperationsWin;

namespace Hennery
{
    /// <summary>
    /// Interaction logic for ItemsWin.xaml
    /// </summary>
    public partial class ItemsWin : Window
    {
        private FeedCon FeedCon;
        private ProductCon ProductCon;
        private MachineCon MachineCon;
        public ItemsWin()
        {
            InitializeComponent();
            Load();
        }

        public void Load()
        {
            FeedCon feedCon = new FeedCon();
            ItemFram.Content = feedCon;
        }
        private void LabelMain_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           Load();
        }

        private void Label1_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MachineCon = new MachineCon();
            MachineFram.Content = MachineCon;
        }

        private void RealStates_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ProductCon = new ProductCon();
            ProductFram.Content = ProductCon;
        }

      
    }
}
