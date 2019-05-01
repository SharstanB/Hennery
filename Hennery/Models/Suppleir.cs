using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hennery.Models
{
    class Suppleir
    {
     
        public int Id { get; set; }
        [StringLength(50)]
        public String Name { get; set; }
        public Boolean IsDeleted { get; set; }
        public int Phone { get; set; }
        public ICollection<Supplying> Supplyings { get; set; }

    }
}
