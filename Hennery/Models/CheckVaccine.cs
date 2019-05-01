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
     
        public int Id { get; set; }
        public int Quantity { get; set; }
        [StringLength(50)]
        public String QuantityUnit { get; set; }
        public Boolean IsDeleted { get; set; }
        public Vaccine Vaccine { get; set; }
        public int? VaccineId { get; set; }
        public int? CheckId { get; set; }
        public Check Check { get; set; }
    }
}
