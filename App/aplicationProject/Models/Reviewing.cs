using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aplicationProject.Models
{
    public class Reviewing
    {
        public int ID { get; set; }
        [ForeignKey("Movie")]
        public int MovieID { get; set; }
        [ForeignKey("Review")]
        public int ReviewID { get; set; }
        public static Movie Movie { get; set; }
        public static Review Review { get; set; }
    }
}
