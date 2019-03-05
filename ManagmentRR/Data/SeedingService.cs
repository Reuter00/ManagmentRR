using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagmentRR.Models;

namespace ManagmentRR.Data
{
    public class SeedingService
    {
        private ManagmentRRContext _context;

        public SeedingService(ManagmentRRContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Tape.Any() || _context.Empresas.Any())
            {
                return; // DB has been seeded
            }

            Empresa Empresa1 = new Empresa(1, "SET");
            Empresa Empresa2 = new Empresa(2, "PRT");
            Empresa Empresa3 = new Empresa(3, "EDI");


            Tape tape1 = new Tape(1, "Nx001", new DateTime(2019, 4, 21), Empresa1,1);
            Tape tape2 = new Tape(2, "Nx002", new DateTime(2019, 5, 21), Empresa2,2);
            Tape tape3 = new Tape(3, "Nx003", new DateTime(2019, 6, 21), Empresa3,3);

            _context.Empresas.AddRange(Empresa1, Empresa2, Empresa3);
            _context.Tape.AddRange(tape1, tape2, tape3);
            _context.SaveChanges();
        }
    }
}
