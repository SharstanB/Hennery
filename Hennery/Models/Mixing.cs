using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Peers;

namespace Hennery.Models
{
    class Mixing
    {
  
        public int Id { get; set; }
        public DateTime MixDate{ get; set; }
        public Boolean IsDeleted { get; set; }
        public ICollection<FeedItemMixing> FeedItemMixings { get; set; }
    }
}
