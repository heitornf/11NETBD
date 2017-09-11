using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Loja
    {
        public int Id { get; set; }
        public string Endereco { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }

        public override string ToString()
        {
            return "Id: " + Id + " End: " + Endereco;
        }
    }
}
