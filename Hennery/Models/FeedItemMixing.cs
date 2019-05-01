using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hennery.Models
{
    class FeedItemMixing
    {
      
        public int Id { get; set; }
        public Boolean IsDeleted { get; set; }
        public int MixingId { get; set; }
        public Mixing Mixing { get; set; }

        public int FeedItemId { get; set; }
        public FeedItem FeedItem { get; set; }
         public ICollection<StoreItem> StoreItems { get; set; }
        public ICollection<StroreItemFeedItemMixing>StroreItemFeedItemMixings { get; set; }

    }
}
