using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGPD_MDE.Dto
{
    public class UsuarioDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Funcao { get; set; }
        public string Telefone { get; set; }
        public string UsuarioP { get; set; }
        public string Senha { get; set; }
        public bool Bloqueado { get; set; }

    }
}
