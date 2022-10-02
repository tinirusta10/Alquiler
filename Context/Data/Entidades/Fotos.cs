using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context.Data.Entidades
{
    public class Foto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La foto es obligatotia")]
        public string Fotito { get; set; }


        
      
        public Producto Producto { get; set; }
    }

}
