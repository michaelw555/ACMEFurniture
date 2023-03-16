using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalFinanceWebsite.Shared
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Model { get; set; }

        public int Stock { get; set; }

        public string Image { get; set; } = "https://via.placeholder.com/300x300";

        public decimal Price { get; set; }

        public bool IsPublic { get; set; }

        public bool IsDeleted { get; set; }

        public Manfac Manfac { get; set; }

        public int ManfacId { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;

        public DateTime DateUpdated { get; set; }
    }
}
