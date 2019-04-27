using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hennery.Models
{
    class Machine
    {
        [Required]
        public int Id { get; set; }
        public int SupplyingItemId { get; set; }
        public String SequenceNumber { get; set; }
        public String Company { get; set; }
        public String Description { get; set; }
    }
}
