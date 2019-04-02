using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagmentRR.Models;

namespace ManagmentRR.Services
{
    public class TapeService
    {
        private readonly ManagmentRRContext _context;

        public TapeService(ManagmentRRContext context)
        {
            _context = context;
        }

        public List<Tape> FindTapes()
        {
            return _context.Tape.ToList();
        }

    }
}
