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
        [Required]
        public int Id { get; set; }
        public int ProductionId { get; set; }
        public ICollection<Production> Productions { get; set; }
        public int SupplingItemId { get; set; }
        public ICollection<SupplyingItem> SupplyingItems { get; set; }
        public int FeedItemMixingId { get; set; }
        public ICollection<FeedItemMixing> FeedItemMixings { get; set; }
        public int StoreId { get; set; }
        public ICollection<Store> Stores { get; set; }
        public int Quantity { get; set; }
        [StringLength(50)]
        public String QuantityUnit { get; set; }
    }
}
