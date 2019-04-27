using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hennery.Models
{
    class Troop
    {
        [Required]
        public int Id { get; set; }
        public int TroopNum { get; set; }
        public int Weight { get; set; }
        public int Count { get; set; }
        [StringLength(50)]
        public String Type { get; set; }
    }
}
