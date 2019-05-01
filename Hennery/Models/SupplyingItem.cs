using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hennery.Models
{
    class SupplyingItem
    {
       
        public int Id { get; set; }
        public int Quantity { get; set; }
        [StringLength(50)]
        public String QuantityUnit { get; set; }      // واحدة القياس كمية المادة     
        public int Price { get; set; }
        public DateTime ProductionDate { get; set; }
        public int GoodnessPeriod { get; set; }
        public Boolean IsDeleted { get; set; }
        public ICollection<StoreItem> StoreItems { get; set; }
        public ICollection<Machine> Machines { get; set; }
        public ICollection<Troop>  Troops { get; set; }
        public Item Item { get; set; }
        public int? ItemId { get; set; }
        public Supplying Supplying { get; set; }
        public int? SupplyingId { get; set; }

    }
}
