using System;
using System.Collections.Generic;


namespace ManagmentRR.Models.ViewModels
{
    public class TapeCreateViewModel
    {
        public Tape Tape { get; set; }
        public ICollection<Tape> Tapes { get; set; }
        public  ICollection<Empresa> Empresas { get; set; }
        public TrocaTape TrocaTape { get; set; }
    }
}
