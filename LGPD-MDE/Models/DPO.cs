using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGPD_MDE.Models
{
    public class DPO : Usuario
    {
        public Enterprise enterprise { get; set; }
        public Area area { get; set; }
    }
}
