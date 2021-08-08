using System;

namespace server.Models
{
    public class ProductInventory
    {
        public int ProductInventoryId { get; set; }
        public int Quantity { get; set; }

        public virtual Product Product { get; set; }
    }
}
