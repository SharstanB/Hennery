using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hennery.Models
{
    class Check
    {
      
        public int Id { get; set; }
        public DateTime? CheckDate { get; set; }
        public Troop Troop { get; set; }

        public Boolean IsDeleted { get; set; }
        public int? TroopId { get; set; }
        
        public ICollection<CheckVaccine> CheckVaccines { get; set; }

    }
}
