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
        [Required]
        public int Id { get; set; }
        public int ItemId { get; set; }
        public ICollection<Item> Items { get; set; }
        public int SupplyingId { get; set; }
        public ICollection<Supplying> Supplyings { get; set; }
        public int Quantity { get; set; }
        [StringLength(50)]
        public String QuantityUnit { get; set; }      // واحدة القياس كمية المادة     
        public int Price { get; set; }
        public DateTime ProductionDate { get; set; }
        public int GoodnessPeriod { get; set; }
    }
}
