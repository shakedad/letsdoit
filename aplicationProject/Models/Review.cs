using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aplicationProject.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        [ForeignKey("User")]
        public string UserName { get; set; }
        public DateTime Publish { get; set; }
        public string Content { get; set; }
        public static User Writer { get; set; }
        public ICollection<aplicationProject.Models.Reviewing> Movies { get; set; }
    }
}
