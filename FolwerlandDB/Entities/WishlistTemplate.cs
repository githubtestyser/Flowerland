using System.Collections.Generic;

namespace FlowerlandDB
{
    class WishlistTemplate
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
