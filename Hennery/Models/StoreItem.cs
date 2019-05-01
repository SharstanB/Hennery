using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hennery.Models
{
    class StoreItem
    {
       
        public int Id { get; set; }

       
        public int Quantity { get; set; }
        [StringLength(50)]
        public String QuantityUnit { get; set; }

        public Boolean IsDeleted { get; set; }

        public  ICollection<ConsumptionStoreItem> ConsumptionStoreItems { get; set; }
        public ICollection<StroreItemFeedItemMixing> StroreItemFeedItemMixings { get; set; }

        public int? ProductionId { get; set; }
        public Production Production { get; set; }
        public int? SupplingItemId { get; set; }
        public SupplyingItem SupplyingItem { get; set; }
        public int? FeedItemMixingId { get; set; }
        public FeedItemMixing FeedItemMixing { get; set; }
        public int? StoreId { get; set; }
        public Store Store { get; set; }
    }
}
