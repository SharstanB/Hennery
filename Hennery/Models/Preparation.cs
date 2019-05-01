using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hennery.Models
{
    class Preparation
    {
     
        public int Id { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [StringLength(100)]
        public String Notes { get; set; }
        [StringLength(100)]
        public String Procedures { get; set; }
        public Boolean IsDeleted { get; set; }
        public int HingarId { get; set; }
        public Hingar Hingar { get; set; }
    }
}
