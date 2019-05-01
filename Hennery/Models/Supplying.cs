using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hennery.Models
{
    class Supplying
    {
       
        public int Id { get; set; }
        public DateTime SupplyingDate { get; set; }
        public Boolean IsDeleted { get; set; }
        public Suppleir Suppleir { get; set; }
        public int? SuppleirId { get; set; }
        public ICollection<SupplyingItem> SupplyingItems { get; set; }
    }
}
