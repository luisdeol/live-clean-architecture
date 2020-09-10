using System;
using System.Collections.Generic;
using System.Text;

namespace LiveCleanArchitecture.Core.Entities
{
    public class Product
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Active { get; set; }
    }
}
