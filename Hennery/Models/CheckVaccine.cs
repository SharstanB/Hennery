using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hennery.Models
{
    class CheckVaccine
    {
        [Required]
        public int Id { get; set; }
        public int VaccineId { get; set; }
        public ICollection<Vaccine> Vaccines { get; set; }
        public int CheckId { get; set; }
        public ICollection<Check> Checks { get; set; }
        public int Quantity { get; set; }
        [StringLength(50)]
        public String QuantityUnit { get; set; }
    }
}
