using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGPD_MDE.Entities.Generated
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Function { get; set; }
        public string Mobile { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

    }
}
