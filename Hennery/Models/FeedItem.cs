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
       [Key]
       public int Id { get; set; }
        public String Temperature { get; set; }

        public String Humidity { get; set; }
        public Boolean Light { get; set; }
        public Boolean IsDeleted { get; set; }
        [Required]
        public int ItemId { get; set; }
        public Item Item { get; set; }

        public ICollection<FeedItemMixing> FeedItemMixings { get; set; }

        public FeedItemType FeedItemType { get; set; }
        public int FeedItemTypeId { get; set; }
    }
}
