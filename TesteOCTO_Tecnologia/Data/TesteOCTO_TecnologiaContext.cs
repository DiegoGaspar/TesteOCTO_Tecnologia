using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudOCTOTecnologia.Models;

namespace TesteOCTO_Tecnologia.Data
{
    public class TesteOCTO_TecnologiaContext : DbContext
    {
        public TesteOCTO_TecnologiaContext (DbContextOptions<TesteOCTO_TecnologiaContext> options)
            : base(options)
        {
        }

        public DbSet<CrudOCTOTecnologia.Models.PessoaFisica> PessoaFisica { get; set; }

        public DbSet<CrudOCTOTecnologia.Models.PessoaJuridica> PessoaJuridica { get; set; }


    }
}
