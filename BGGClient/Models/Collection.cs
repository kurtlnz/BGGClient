using System.Collections.Generic;

namespace BGGClient.Models
{
    public class Collection
    {
        public IList<CollectionItem> Items { get; set; }
        public int TotalItems => Items.Count;
    }

    public class CollectionItem
    {
        
    }
}