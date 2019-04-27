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
        [Required]
        public int Id { get; set; }
        public int SuppleirId { get; set; }
        public ICollection<Supplying> Supplyings { get; set; }
        public DateTime SupplyingDate { get; set; }
    }
}
