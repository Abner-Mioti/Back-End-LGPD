using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGPD_MDE.Models
{
    public class Usuario
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string function { get; set; }
        public string mobile { get; set; }
        public string user { get; set; }
        public string password { get; set; }
        public bool isActive { get; set; }
    }
}
