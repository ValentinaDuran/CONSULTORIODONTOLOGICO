using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSULTORIODONTOLOGICO.BD.Data.Entidades
{
    //clase creada despues de sugerencia del profe en la evaluación 8 de agosto
    public class ObraSocial : Paciente
    {
        //una obra social tiene muchos pacientes 
       
        public int Id { get; set; }

        [Required]
        public string NombreObrasocial { get; set; }

        [Required]
        public string NumAfiliado { get; set; }

        public int PacienteId { get; set; }
 
        public List<Paciente> Pacientes { get; set; }
        

    }
}
