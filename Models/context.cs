using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class context : DbContext
    {
        public context() : base("Local")
        {

        }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Loja> Loja { get; set; }
    }
}
