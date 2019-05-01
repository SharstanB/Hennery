using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hennery.Models
{
    class Machine
    {
    
        public int Id { get; set; }
     
        public String SequenceNumber { get; set; }
        public String Company { get; set; }
        public String Description { get; set; }
        public Boolean IsDeleted { get; set; }
        [Index(IsUnique = true)]
        public int SupplyingItemId { get; set; }
        public SupplyingItem SupplyingItem { get; set; }
        
        public ICollection<Conservation> Conservations { get; set; }
    }
}
