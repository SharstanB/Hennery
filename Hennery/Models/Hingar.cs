using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hennery.Models
{
    class Hingar
    {
        [Required]
        public int Id { get; set; }
        public int Capacity { get; set; }
        [StringLength(50)]
        public String Type { get; set; }
    }
}
