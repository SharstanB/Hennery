using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hennery.Models
{
    class StroreItemFeedItemMixing
    {
        [Required]
        public int Id { get; set; }
        public int StoreItemId { get; set; }
        public ICollection<StoreItem> StoreItems { get; set; }
        public int MixingFeedItemId { get; set; }
        public ICollection<FeedItemMixing> FeedItemMixings { get; set; }
    }
}
