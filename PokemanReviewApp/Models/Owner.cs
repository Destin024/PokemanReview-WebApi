using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemanReviewApp.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gym { get; set; }
        public Country Country { get; set; }
        public ICollection<PokemanOwner> PokemanOwners { get; set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
    }
}
