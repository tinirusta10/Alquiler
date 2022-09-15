using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context.Data.Entidades
{
    public class Fotos
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La foto es obligatotia")]
        public string foto { get; set; }


        
      
        public Producto Producto { get; set; }
    }

}
