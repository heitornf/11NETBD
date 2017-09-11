using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public int LojaId { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Profissao { get; set; }

        public virtual Loja Loja { get; set; }
    }
}
