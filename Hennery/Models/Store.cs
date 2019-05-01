using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hennery.Models
{
     class Store
    {
       
        public int Id { get; set; }
   
        [StringLength(50)]
        public String StoreName { get; set; }
        public int Area { get; set; }
        public Boolean IsDeleted { get; set; }
        public int Temperature { get; set; }
        [StringLength(50)]
        public String TemperatureUnit { get; set; }
        public int Humidity { get; set; }
        [StringLength(50)]
        public String HumidityUnit { get; set; }
        public Boolean Light { get; set; }
       

        public int HingarId { get; set; }
        public Hingar Hingar { get; set; }

        public ICollection<StoreItem> StoreItems { get; set; }

    }
}
