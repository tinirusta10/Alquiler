using Context.Data.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class Bdcontext:DbContext
    {
        public Bdcontext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Persona> Personas { get; set; }

        public DbSet<Producto> Productos { get; set; }

        public DbSet<Provincia> Provincias { get; set; }

        public DbSet<Departamento> Departamentos { get; set; }

        public DbSet<TipoDocumento> TipoDocumentos { get; set; }

        public DbSet<Localidad> Localidades { get; set; }

        public DbSet<Fotos> Fotos { get; set; }

    }
}
