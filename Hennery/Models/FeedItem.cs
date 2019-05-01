using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hennery.Models
{
    class FeedItem
    {
     public int Id { get; set; }
        public int? Temperature { get; set; }
        [StringLength(50)]
        public string TemperatureUnit { get; set; }
        public int? Humidity { get; set; }
        [StringLength(50)]
        public String HumidityUnit { get; set; }
        public Boolean Light { get; set; }
        public Boolean IsDeleted { get; set; }
        [Index(IsUnique = true)]
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public ICollection<FeedItemMixing> FeedItemMixings { get; set; }

    }
}
