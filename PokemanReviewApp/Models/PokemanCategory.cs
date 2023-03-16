using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemanReviewApp.Models
{
    public class PokemanCategory
    {
        public int PokemanId { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public Pokeman Pokeman { get; set; }

    }
}
