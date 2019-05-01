using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Hennery.Classes;
using Hennery.Models;
using Microsoft.Win32;

namespace Hennery.Views.OperationsWin
{
    /// <summary>
    /// Interaction logic for FeedCon.xaml
    /// </summary>
    public partial class FeedCon : UserControl
    {
        private Item Item;
         private Store Store;
//        private Type1 Type1;
        private BackgroundWorker Worker = new BackgroundWorker();
        private DataContext Context;
        private ObservableCollection<Store>Stores;
       private ObservableCollection<SupplyingItem>SupplyingItems;
        private ObservableCollection<Item>Items;
        List<String>List = new List<string>();
        List<Item> ItemsList =new List<Item>();
        private List<FeedItemDetails>  feedItemDetails;

        private int ID1;
        private int ID2;
        private int F = 0;
        private int IdEdit;
        private string q;

        public ObservableCollection<T> TObservableCollection<T> (IEnumerable<T> enumerable)
        {
            return new ObservableCollection<T>(enumerable);
        }
        public FeedCon()
        {
            InitializeComponent();
            Worker.DoWork += WOrkerDO;
            Worker.RunWorkerCompleted += WorkerrunCom ;
            Load();
        }

        public void Load()
        {
            dh.IsOpen = true;
            if (!Worker.IsBusy)
            {
                Context = new DataContext();
                Worker.RunWorkerAsync();
            }
        }

        private void WOrkerDO(object sender, DoWorkEventArgs e)
        {
            Stores = TObservableCollection<Store>(Context.Stores.Where(i=> !i.IsDeleted));
            SupplyingItems = TObservableCollection<SupplyingItem>(Context.SupplyingItems.Where(i=> !i.IsDeleted));
           Items = TObservableCollection<Item>(Context.Items.Where(i=>!i.IsDeleted ));
            Item qe = Context.Items.Single(l=> l.Id==1);
            var temp = Context.StoreItems.FirstOrDefault().SupplyingItem;
            q = qe.SupplyingItems.FirstOrDefault(s => s.Id == 5).StoreItems.Single(p => p.Id == 7).Quantity.ToString();

        }

        private void WorkerrunCom(object sender, RunWorkerCompletedEventArgs e)
        {
            dh.IsOpen = false;
            ComStor.ItemsSource = Stores;
            ComType.ItemsSource = Items;


            TxtName.Text = q;
                    

            Dgv.ItemsSource = feedItemDetails;

        }
    
        private void ButtonShow_OnClick(object sender, RoutedEventArgs e)
        {
           
        }

        private void ButtonDelete_OnClick(object sender, RoutedEventArgs e)
        {
            object ID = ((Button)sender).CommandParameter;
            IdEdit = (int) ID;
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                var q = Context.Items.Single(i => i.Id == IdEdit);
                q.IsDeleted = true;
            }
            Context.SaveChanges();
            Load();
        }

        private void ButtonEdit_OnClick(object sender, RoutedEventArgs e)
        {
            F = 1;
            object ID = ((Button) sender).CommandParameter;
            AddBtn.Content = "Edit";
            IdEdit = (int) ID;
            //var q = Context.Items
//            TxtH.Text = ;
//             TxtT.Text = q.Temperature;
//             Tolight.IsChecked = q.Light;
          
           // ComStor.SelectedValue = q;
        }


        private void AddBtn_OnClick(object sender, RoutedEventArgs e)
        {
            //if (F == 0)
            //{
            //    Items = new Items()
            //    {
            //        Name = TxtName.Text,
            //        Humidity = TxtH.Text,
            //        Temperature = TxtT.Text,
            //        Light = Tolight.IsChecked.Value,
            //        StoreId = (int) ComStor.SelectedValue,
            //        TypeId = (int) ComType.SelectedValue
            //    };
            //    Context.Itemses.Add(Items);
                
                
            //}
            //else
            //{
            //    var q = Context.Itemses.Single(i => i.Id == IdEdit);
            //    q.Name = TxtName.Text ;
            //    q.Humidity = TxtH.Text;
            //    q.Temperature = TxtT.Text;
            //    q.Light = Tolight.IsChecked.Value;
            //    q.StoreId = (int)ComStor.SelectedValue;
            //    q.TypeId = (int) ComType.SelectedValue;
            //    F =0;
            //    AddBtn.Content = "Add";
            //}
            //Context.SaveChanges();
            //Load();
            //TxtName.Text = "";
            //TxtH.Text = "";
            //TxtT.Text = "";

        }

        private void FeedCon_OnLoaded(object sender, RoutedEventArgs e)
        {
           

        }

        private void ComType_OnSelected(object sender, RoutedEventArgs e)
        {
            
        }

        private void ComType_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComType.SelectedValue != null)
            {
                ID1 = (int)ComType.SelectedValue;
            }
            
        }

        private void ComStor_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComStor.SelectedValue != null)
            {
                ID2 = (int) ComStor.SelectedValue;
            }
        }
    }
}
