using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hennery.Models
{
    class Troop
    {
       
        public int Id { get; set; }
        public int TroopNum { get; set; }
        public int Weight { get; set; }
        public int Count { get; set; }
        [StringLength(50)]
        public String Type { get; set; }
        public Boolean IsDeleted { get; set; }
        [Index(IsUnique = true)]
        public int SupplyingItemId { get; set; }
        public SupplyingItem SupplyingItem { get; set; }
//        public ICollection<Store> Stores { get; set; }
        public ICollection<Check> Checks { get; set; }
        public ICollection<HingarTroop> HingarTroops { get; set; }
        public ICollection<Production> Productions { set; get; }
        public ICollection<Consumption> Consumptions { set; get; }

    

    }
}
