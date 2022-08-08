using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSULTORIODONTOLOGICO.BD.Data.Entidades
{
    public class Paciente
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        public int FechaNacimiento { get; set; }
        [Required]
        public int NúmeroTeléfono { get; set; }

        [Required]
        public string Mail { get; set; }

        [Required]
        public string ObraSocial { get; set; }



    }
}
