using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vesper.Models
{
    public class Testimonial : BaseEntity
    {
        public string AuthorName { get; set; }
        public string AuthorImage { get; set; }
        public string AuthorOccupation { get; set; }
        public string Text { get; set; }
    }
}
