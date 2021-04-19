using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Maker { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);

    }
}
