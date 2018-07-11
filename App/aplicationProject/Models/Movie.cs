using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aplicationProject.Models
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }
        public string Name { get; set; }
        public DateTime Release { get; set; }
        public byte[] Poster { get; set; }
        public int Likes { get; set; }
        public string Description { get; set; }
        public ICollection<aplicationProject.Models.Reviewing> Reviews { get; set; }
    }
}
