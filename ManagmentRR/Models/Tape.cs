using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManagmentRR.Models
{
    public class Tape
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
        public Empresa Empresa { get; set; }
        public int EmpresaId { get; set; }

        public Tape()
        {

        }

        public Tape(int id, string nome, DateTime data, Empresa empresa, int empresaid)
        {
            Id = id;
            Nome = nome;
            Data = data;
            Empresa = empresa;
            EmpresaId = empresaid;
        }

      
    }
}
