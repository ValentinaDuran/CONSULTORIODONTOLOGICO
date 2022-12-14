using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSULTORIODONTOLOGICO.BD.Data.Entidades
{
    public class Paciente 
    {
        // un paciente tiene una obra social RELACION 1:MUCHOS
        public int Id { get; set; } 

        [Required]
        public string NombreObraSocial { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        public int DNI { get; set; }
        [Required]
        public int NúmeroTeléfono { get; set; }

        [Required]
        public string Mail { get; set; }

        public int ObraSocialId { get; set; }//id+propiedad siempre unidos y en ese orden id arriba y propiedad abajo
        public ObraSocial ObraSocial  { get; set; }//propiedad de tipo obrasocial. relacion 1=1

    }
}
