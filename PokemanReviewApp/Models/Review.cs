using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemanReviewApp.Models
{
    public class Review
    {
        internal int Rating;

        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public Pokeman Pokeman { get; set; }
        public Reviewer Reviewer { get; set; }
    }
}
