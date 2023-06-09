﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemanReviewApp.Models
{
    public class Pokeman
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<PokemanOwner> PokemanOwners { get; set; }
        public ICollection<PokemanCategory> PokemanCategories { get; set; }
    }
}
