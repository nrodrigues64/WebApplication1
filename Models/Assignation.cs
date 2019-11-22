using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Assignation
    {
        public virtual Matela Matela { get; set; }
        public virtual Patient Patient { get; set; }
        
    }
}
