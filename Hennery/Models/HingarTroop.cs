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
    
        public int id { get; set; }
        public Boolean IsDeleted { get; set; }
        public int Count { get; set; } // عدد الرؤوس الموجودة في الهنغار من الفوج
        public int HingarId { get; set; }
        public Hingar Hingar { get; set; }
        public int TroopId { get; set; }
        public Troop Troop { get; set; }
    }
}
