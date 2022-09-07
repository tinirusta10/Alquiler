using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context.Data.Entidades
{
    public class Persona
    {

        [Required]

        //es la id de la persona//

        public int Id { get; set; }

        [Required]
        [MaxLength(8, ErrorMessage = "El DNI de la persona no debe superar los 8 caracteres")]
        public int DNI { get; set; }


        [Required]
        [MaxLength(25)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(25)]
        public string Apellido { get; set; }

        [Required]
        [MaxLength(25, ErrorMessage = "La Contraseña no debe superar los 25 caracteres")]
        public string Contraseña { get; set; }

        [Required]
        [MaxLength(25, ErrorMessage = "la contraseña no puede superar los 25 caracteres")]
        public string RepetirContraseña { get; set; }

        [Required]
        [MaxLength(50)]
        public string Mail { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "El Numero de telefono no debe superar los 20 caracteres")]
        public int NumeroTelefono { get; set; }

        [Required]
        [MaxLength(4, ErrorMessage = "Tipo de documento incorrecto")]
        public string IdTipoDocumento { get; set; }

        [Required]
        [MaxLength(50)]
        public string IdProvincia { get; set; }

        [Required]
        [MaxLength(30)]
        public string Barrio { get; set; }

        [Required]
        [MaxLength(5)]
        public int Piso { get; set; }

        [Required]
        [MaxLength(30)]
        public string IdDepartamento { get; set; }

        [Required]
        [MaxLength(30)]
        public string calle { get; set; }

        [Required]
        [MaxLength(30)]
        public string Depto { get; set; }

        [Required]
        [MaxLength(25)]
        public string IdLocalidad { get; set; }

        [Required]
        [MaxLength(6)]
        public int Altura { get; set; }

        [Required]
        [MaxLength(25)]
        public int CP { get; set; }

        [Required]
        [MaxLength(50)]
        public string Referencia { get; set; }

    }
}
