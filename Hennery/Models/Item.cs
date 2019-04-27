using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hennery.Models
{
    class Item
    {
        [Required]
        public int Id { get; set; }
        [StringLength(50)]
        public String Name { get; set; }
        [StringLength(50)]
        public String Type { get; set; }
    }
}
