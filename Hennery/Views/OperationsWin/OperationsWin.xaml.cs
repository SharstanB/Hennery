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
using System.Windows.Shapes;

namespace Hennery.Views.OperationsWin
{
    /// <summary>
    /// Interaction logic for OperationsWin.xaml
    /// </summary>
    public partial class OperationsWin : Window
    {
        private ConsumptionCon consumptionCon;
        public OperationsWin()
        {
            InitializeComponent();
        }


        private void LabelMain_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void RealStates_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Label1_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            consumptionCon=new ConsumptionCon();
            ConsumptionFram.Content = consumptionCon;
        }
    }
}
