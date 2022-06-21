using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGPD_MDE.Entities.Generated
{
    public class Impact
    {
        public int Id { get; set; }
        public string Impacts { get; set; }

        public virtual ICollection<Question> Question { get; set; }

    }
}
