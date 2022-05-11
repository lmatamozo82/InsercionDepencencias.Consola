using InsercionDepencencias.Consola.Entidades;
using InsercionDepencencias.Consola.Entidades.Seed;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InsercionDepencencias.Consola
{
    public class MDBContext : DbContext
    {
        public MDBContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //Sirve para poder personalizar el metodo de creación, asi lo personalizamos y validamos
        {
            base.OnModelCreating(modelBuilder);
            //Clase que escanea todas las configuraciones que hereden de la clase de configuracion (implementa el interfaz) y las añade.
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            SeedData.Seed(modelBuilder); //Insertamos datos para poder hacer pruebas.
        }

        public DbSet<Recurso>? Recursos { get; set; }
    }
}
