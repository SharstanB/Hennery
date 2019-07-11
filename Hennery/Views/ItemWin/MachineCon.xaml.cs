using Hennery.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Channels;
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
using Hennery.Classes;

namespace Hennery.Views.ItemWin
{
    /// <summary>
    /// Interaction logic for MachineCon.xaml
    /// </summary>
    public partial class MachineCon : UserControl
    {
        private BackgroundWorker worker = new BackgroundWorker();
        private DataContext Context;
        private ObservableCollection<Machine> Machines;
        private ObservableCollection<SupplyingItem>SupplyingItems;      
 
        public ObservableCollection<T> TObservableCollection<T>(IEnumerable<T>enumerable)
        {
            return new ObservableCollection<T>(enumerable);
        }
        public MachineCon()
        {
            InitializeComponent();
            worker.DoWork += DoWorker;
            worker.RunWorkerCompleted += Workerruncom;
            Load();
        }
        public void DoWorker( Object sender , DoWorkEventArgs doWorkEventArgs )
        {
            Machines = TObservableCollection(Context.Machines.Where(i => !i.IsDeleted));
        }

        public void Workerruncom( object worker , RunWorkerCompletedEventArgs args)
        {
            dh.IsOpen = false;
            DgvMachine.ItemsSource = Machines;
        }

        public void Load()
        {
            dh.IsOpen = true;
            if (!worker.IsBusy)
            {
                Context = new DataContext();
                worker.RunWorkerAsync();
            }
        }
        
        
        private void ButtonShow_OnClick(object sender, RoutedEventArgs e)
        {
           
        }

        private void ButtonEdit_OnClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void ButtonDelete_OnClick(object sender, RoutedEventArgs e)
        {
           
        }

        private void ComStoreName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DGVEmployee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnAdd_OnClick(object sender, RoutedEventArgs e)
        {
//            Items.Add(new Item()
//            {
//                Name = NameTxt.Text,
//                
//            });
        }
    }
}
