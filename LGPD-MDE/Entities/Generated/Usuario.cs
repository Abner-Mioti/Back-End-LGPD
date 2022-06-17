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
        public string Nome { get; set; }

        public string Email { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Telefone { get; set; }

        public string Descricao { get; set; }



    }
}
