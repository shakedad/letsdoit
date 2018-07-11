using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aplicationProject.Models
{
    public class User
    {
        [Key]
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Name { get; set; }
        public DateTime Register { get; set; }
        public int MyProperty { get; set; }
        public static ICollection<aplicationProject.Models.Review> Reviews { get; set; }
    }
}
