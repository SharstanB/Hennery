using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hennery.Models
{
    class Conservation
    {
        [Required]
        public int Id { get; set; }
        public int MachineId { get; set; }
        public ICollection<Machine> Machines { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [StringLength(50)]
        public String Type { get; set; }
        [StringLength(100)]
        public String Procedures { get; set; }
    }
}
