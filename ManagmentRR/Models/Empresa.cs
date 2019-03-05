using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagmentRR.Models
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Nome { get; set; }


        public Empresa()
        {

        }

        public Empresa(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

       
    }
}
