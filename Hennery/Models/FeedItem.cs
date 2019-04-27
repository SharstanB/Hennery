using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hennery.Models
{
    class FeedItem
    {
        [Required]
        public int Id { get; set; }
        public int Temperature { get; set; }
        [StringLength(50)]
        public String TemperatureUnit { get; set; }
        public int Humidity { get; set; }
        [StringLength(50)]
        public String HumidityUnit { get; set; }
        public Boolean Light { get; set; }
    }
}
