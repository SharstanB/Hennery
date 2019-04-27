using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hennery.Models
{
    class HingarTroop
    {
        [Required]
        public int id { get; set; }
        public int HingarId { get; set; }
        public int TroopId { get; set; }   
        public int? Count { get; set; } // عدد الرؤوس الموجودة في الهنغار من الفوج
    }
}
