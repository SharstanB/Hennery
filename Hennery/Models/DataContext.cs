using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = System.Type;


namespace Hennery.Models
{
    class DataContext : DbContext
    {
        public DataContext() : base("Data Source =.; Initial Catalog = HenneryDB; Integrated Security = true")
        {



        }

        public DbSet<Check> Checks { get; set; }
        public DbSet<CheckVaccine> CheckVaccines { get; set; }
        public DbSet<Consumption> Consumptions { get; set; }
        public DbSet<Conservation> Conservations { get; set; }
        public DbSet<ConsumptionStoreItem> ConsumptionStoreItems { get; set; }
        public DbSet<FeedItem> FeedItems { get; set; }
        public DbSet<FeedItemMixing> FeedItemMixings { get; set; }
        public DbSet<Hingar> Hingars { get; set; }
        public DbSet<HingarTroop> HingarTroops { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Machine> Machines { get; set; }
        public DbSet<Mixing> Mixings { get; set; }
        public DbSet<Preparation> Preparations { get; set; }
        public DbSet<Production> Productions { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<StoreItem> StoreItems { get; set; }
        public DbSet<StroreItemFeedItemMixing> StroreItemFeedItemMixings { get; set; }
        public DbSet<Suppleir> Suppleirs { get; set; }
        public DbSet<Supplying> Supplyings { get; set; }
        public DbSet<SupplyingItem> SupplyingItems { get; set; }
        public DbSet<Troop> Troops { get; set; }
        public DbSet<Vaccine> Vaccines { get; set; }
        //public DbSet<Stores> Storeses { get; set; }
        //public DbSet<Items> Itemses { get; set; }
        //public DbSet<Type1> Types { get; set; }

    }
}
