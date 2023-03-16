using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemanReviewApp.Models
{
    public class PokemanOwner
    {
        public int PokemanId { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
        public Pokeman Pokeman { get; set; }

    }
}
