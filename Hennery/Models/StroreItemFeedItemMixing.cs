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
        public int Id { get; set; }
        public Boolean IsDeleted { get; set; }
        public int StoreItemId { get; set; }
        public StoreItem StoreItem { get; set; }
        public int FeedItemMixingId { get; set; }
        public  FeedItemMixing FeedItemMixing { get; set; }
    }
}
