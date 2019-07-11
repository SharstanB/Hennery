using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.Entity;
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
using System.Windows.Media.Media3D;
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
        private BackgroundWorker Worker = new BackgroundWorker();
        private DataContext Context;

        private Item _item;
        private FeedItem _feedItem;
        private FeedItemType FeedItemType;
        private ObservableCollection<FeedItem> FeedItems;
        private ObservableCollection<FeedItemType> FeedItemTypes;
        private ObservableCollection<Item> Items;
        private int F = 0;
        private int IdEdit;
        public ObservableCollection<T> TObservableCollection<T>(IEnumerable<T> enumerable)
        {
            return new ObservableCollection<T>(enumerable);
        }
        public FeedCon()
        {
            InitializeComponent();
            Worker.DoWork += WOrkerDO;
            Worker.RunWorkerCompleted += WorkerrunCom;
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
            FeedItems = TObservableCollection(Context.FeedItems.Where(s => !s.IsDeleted)
                .Include(nameof(Item)).Where(i => i.Item.Id == i.ItemId && !i.IsDeleted).Include(nameof(FeedItemType)).Where(i => i.FeedItemType.Id == i.FeedItemTypeId));
            FeedItemTypes = TObservableCollection(Context.FeedItemTypes.Where(i => !i.IsDeleted));
        }
        private void WorkerrunCom(object sender, RunWorkerCompletedEventArgs e)
        {
            dh.IsOpen = false;
            ComType.ItemsSource = FeedItemTypes;
            Dgv.ItemsSource = FeedItems;
        }
        private void ButtonDelete_OnClick(object sender, RoutedEventArgs e)
        {
            object ID = ((Button)sender).CommandParameter;  // to save row index (id)
            IdEdit = (int)ID;
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                var q = Context.FeedItems.Single(i => i.Id == IdEdit);
                q.IsDeleted = true;
                q.Item.IsDeleted = true;
            }
            Context.SaveChanges();
            Load();
        }

        private void ButtonEdit_OnClick(object sender, RoutedEventArgs e)
        {
            F = 1;
            object ID = ((Button)sender).CommandParameter;
            AddBtn.Content = "Edit";
            IdEdit = (int)ID;
            var q = Context.FeedItems.Single(i => i.Id == IdEdit);
            TxtH.Text = q.Humidity;
            TxtT.Text = q.Temperature;
            Tolight.IsChecked = q.Light;
            TxtName.Text = q.Item.Name;
            ComType.SelectedValue = q.FeedItemType.Id;
        }

        public void AddNewItem(int a)
        {

        }

        private void AddBtn_OnClick(object sender, RoutedEventArgs e)
        {
            if (F == 0)
            {

                _item = new Item()
                {
                    Name = TxtName.Text,
                };
                Context.Items.Add(_item);
                Context.SaveChanges();
                int a = _item.Id;
                int FeedTypeId;
                FeedItemType feedType = Context.FeedItemTypes.Find(Convert.ToInt32(ComType.SelectedValue));
                if (feedType == null)
                {
                    FeedItemType = new FeedItemType()
                    {
                        FeedType = ComType.Text
                    };
                    Context.FeedItemTypes.Add(FeedItemType);
                    Context.SaveChanges();
                    FeedTypeId = FeedItemType.Id;
                }
                else
                {
                    FeedTypeId = feedType.Id;
                }
                _feedItem = new FeedItem()
                {
                    Temperature = TxtT.Text,
                    Humidity = TxtH.Text,
                    Light = Tolight.IsChecked.Value,
                    ItemId = a,
                    FeedItemTypeId = FeedTypeId
                };
                Context.FeedItems.Add(_feedItem);
                Context.SaveChanges();
                Load();

            }
            else
            {
                int FeedTypeId;
                var q = Context.FeedItems.Single(i => i.Id == IdEdit);
                q.Humidity = TxtH.Text;
                q.Temperature = TxtT.Text;
                q.Light = Tolight.IsChecked.Value;
                if (ComType.SelectedValue == null)
                {


                    FeedItemType = new FeedItemType()
                    {
                        FeedType = ComType.Text
                    };
                    Context.FeedItemTypes.Add(FeedItemType);
                    Context.SaveChanges();
                    FeedTypeId = FeedItemType.Id;
                    q.FeedItemTypeId = FeedTypeId;
                }
                else
                    q.FeedItemTypeId = (int)ComType.SelectedValue;
                q.Item.Name = TxtName.Text;

                F = 0;
                AddBtn.Content = "Add";
            }
            Context.SaveChanges();
            Load();
            TxtName.Text = "";
            TxtH.Text = "";
            TxtT.Text = "";
        }

        private void FeedCon_OnLoaded(object sender, RoutedEventArgs e)
        {


        }

        private void ComType_OnSelected(object sender, RoutedEventArgs e)
        {

        }

        private void ComType_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }

        private void ComStor_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

       
    }
}
