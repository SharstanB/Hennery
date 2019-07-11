using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Hennery.Models
{
    class Item
    {
       
       public int Id { get; set; }
        [StringLength(50)]
        public String Name { get; set; }
        public Boolean IsDeleted { get; set; } 
        public ICollection<SupplyingItem> SupplyingItems { get; set; }
        public ICollection<Production> Productions { get; set; }
        public ICollection<FeedItem> FeedItems { get; set; }
        public ICollection<Vaccine> Vaccines { get; set; }
        
    }
}
