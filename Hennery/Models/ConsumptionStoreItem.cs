using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hennery.Models
{
    class ConsumptionStoreItem
    {
       
        public int Id { get; set; }
        public int? Quantity { get; set; }
        [StringLength(50)]
        public String QuantityUnit { get; set; }
        public Boolean IsDeleted { get; set; }
        public int StoreItemId { get; set; }
        public StoreItem StoreItem { get; set; }

        public int ConsumptionId { get; set; }
        public Consumption Consumption { get; set; }
    }
}
