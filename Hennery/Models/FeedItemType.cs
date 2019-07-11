using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Hennery.Models
{
    class FeedItemType
    {
        public int Id { get; set; }
        public String FeedType { get; set; }

        public Boolean IsDeleted { get; set; }
        public ICollection<FeedItem> FeedItems { get; set; }
    }
}
