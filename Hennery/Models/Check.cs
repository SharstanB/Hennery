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
        [Required]
        public int Id { get; set; }
        public int TroopId { get; set; }
        public ICollection<Troop> Troops { get; set; }
        public DateTime CheckDate { get; set; }
    }
}
