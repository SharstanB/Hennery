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
        [Required]
        public int Id { get; set; }
        public int FeedItemId { get; set; }
        public ICollection<FeedItem> FeedItems { get; set; }
        public int MixingId { get; set; }
        public ICollection<Mixing> Mixings { get; set; }
    }
}
