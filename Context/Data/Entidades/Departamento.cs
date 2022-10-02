using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context.Data.Entidades
{
    public class Departamento
    {

        
        public int Id { get; set; }


        [Required(ErrorMessage = "El Nombre de Departamento es obligatorio")]
        [MaxLength(30, ErrorMessage = "El Nombre de Departamento no debe superar los 30 caracteres")]
        public string NombreDepartamento { get; set; }

        public List<Persona> Personas { get; set; }

    }
}
