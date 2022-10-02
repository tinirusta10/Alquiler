using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context.Data.Entidades
{
    public class Localidad
    {

        public int Id { get; set; }


        [Required(ErrorMessage = "El Nombre de Localidad es obligatorio")]
        [MaxLength(30, ErrorMessage = "El Nombre de Localidad no debe superar los 30 caracteres")]
        public string NombreLocalidad { get; set; }


        public List<Persona> Personas { get; set; }

    }
}
