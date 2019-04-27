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
        [Required]
        public int Id { get; set; }
        public int ItemId { get; set; }
        public ICollection<Item> Items { get; set; }
        public int TroopId { get; set; }
        public ICollection<Troop> Troops { get; set; }
        public DateTime ProductionDate { get; set; }
        public int? Quantity { get; set; }
        [StringLength(50)]
        public String QuantityUnit { get; set; }
    }
}
