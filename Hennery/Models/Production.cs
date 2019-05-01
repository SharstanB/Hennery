using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hennery.Models
{
    class Production
    {
    
        public int Id { get; set; }

        public DateTime ProductionDate { get; set; }
        public int? Quantity { get; set; }
        [StringLength(50)]
        public String QuantityUnit { get; set; }
        public Boolean IsDeleted { get; set; }
        public ICollection<StoreItem> StoreItems { get; set; }

         public int ItemId { get; set; }
        public Item Item { get; set; }
        public int TroopId { get; set; }
        public Troop Troop { get; set; }
    }
}
