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

        public DbSet<Persona> Persona { get; set; }

        public DbSet<Producto> Productos { get; set; }

        public DbSet<Provincia> Provincia { get; set; }

        public DbSet<Departamento> Departamento { get; set; }

        public DbSet<TipoDocumento> TipoDocumento { get; set; }

        public DbSet<Localidad> Localidad { get; set; }

        public DbSet<Fotos> Fotos { get; set; }

    }
}
