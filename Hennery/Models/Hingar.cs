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

        public int Id { get; set; }
        public int Capacity { get; set; }
        [StringLength(50)]
        public String Type { get; set; }
        public Boolean IsDeleted { get; set; }
        public ICollection<HingarTroop> HingarTroops { get; set; }
        public ICollection<Preparation> Preparations { get; set; }
        public ICollection<Store> Stores { get; set; }
    }
}
