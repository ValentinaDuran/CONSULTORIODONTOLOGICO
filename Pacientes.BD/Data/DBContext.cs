using CONSULTORIODONTOLOGICO.BD.Data.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSULTORIODONTOLOGICO.BD.Data
{
    public class DBContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            foreach ( /// Desactiva la eliminacion en cascada de todas las relaciones
                var relationship in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
        // Paciente: carga de cada registro //Pacientes:tabla
        public DbSet<Paciente> Pacientes { get; set; }
        //constructor: parandome arriba de BDContext y ctrl+., seleccionar opcion "generar constructor con options"
        //DbContextOptions "opcions" agarra los parámetros "options" de la 'base' heredada
        public DbSet<ObraSocial> ObrasSociales { get; set; }
        
        public DBContext(DbContextOptions options) : base(options)
        {
        }
        

    }



}
