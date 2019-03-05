using ManagmentRR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagmentRR.Services
{
    public class EmpresaServices
    {
        private readonly ManagmentRRContext _context;

        public EmpresaServices(ManagmentRRContext context)
        {
            _context = context;
        }

        public List<Empresa> FindEmpresa()
        {
            return _context.Empresas.ToList();
        }

    }

}
