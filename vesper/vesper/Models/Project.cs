using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vesper.Models
{
    public class Project : BaseEntity
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Client { get; set; }
        public string Url { get; set; }
        public string DetailedHeading { get; set; }
        public string DetailedText { get; set; }
        public DateTime Date { get; set; }
        public List<ProjectToCategory> ProjectToCategories { get; set; }
        public List<ProjectImage> ProjectImages { get; set; }

    }
}
