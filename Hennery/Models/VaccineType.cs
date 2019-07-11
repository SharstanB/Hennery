using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hennery.Models
{
    class VaccineType
    {
        public int Id { get; set; }
       [StringLength(50)]
        public String _VaccineType { get; set; }
        public Boolean IsDeleted { get; set; }

        public ICollection<Vaccine> Vaccines { get; set; }
    }
}
