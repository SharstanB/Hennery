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
    
        public int Id { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [StringLength(50)]
        public String Type { get; set; }
        [StringLength(100)]
        public String Procedures { get; set; }
        public Boolean IsDeleted { get; set; }

        public Machine Machine { get; set; }
        public int MachineId { get; set; }

    }
}
