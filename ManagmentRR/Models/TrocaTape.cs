using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManagmentRR.Models
{
    public class TrocaTape
    {
        public int Id { get; set; }
        public Tape Tape { get; set; }
        public int TapeId { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataInicio { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataFim { get; set; }
        public Empresa Empresa { get; set; }
        public int EmpresaId { get; set; }


        public TrocaTape()
        {

        }

        public TrocaTape(int id, Tape tape, DateTime datainicio, Empresa empresa)
        {
            Id = id;
            Tape = tape;
            DataInicio = datainicio;
            Empresa = empresa;
            
        }


    }
}
