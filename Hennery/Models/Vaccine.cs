using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hennery.Models
{
    class Vaccine
    {
      
        public int Id { get; set; }
        [StringLength(50)]
        public String Type { get; set; }
        public Boolean IsDeleted { get; set; }
        [Index(IsUnique = true)]
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public ICollection<CheckVaccine> CheckVaccines { get; set; }
    }
}
