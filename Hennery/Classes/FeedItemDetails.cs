using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hennery.Classes
{
    class FeedItemDetails
    {
        public String  ItemName { get; set; }
        public String ItemType { get; set; }
        public String StoreName { get; set; }
        public int Tempreture { get; set; }
        public int Humidity { get; set; }
        public Boolean Light { get; set; }

        public FeedItemDetails( String itemName , string itemType , string storeName, int tempreture , int humidity , Boolean light)
        {
            ItemName = itemName;
            ItemType = itemType;
            StoreName = storeName;
            Tempreture = tempreture;
            Humidity = humidity;
            Light = light;
        }
    }
}
