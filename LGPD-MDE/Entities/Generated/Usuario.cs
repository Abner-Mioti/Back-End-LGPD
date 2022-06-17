using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGPD_MDE.Entities.Generated
{
    [Table(name: "usuario")]
    public class Usuario
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
