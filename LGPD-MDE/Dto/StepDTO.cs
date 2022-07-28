using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGPD_MDE.Dto
{
    public class StepDTO
    {
        public string Steps { get; set; }
        public int Value { get; set; }
        public DateTime CloseDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Itens { get; set; }
        public bool Active { get; set; }

    }
}
