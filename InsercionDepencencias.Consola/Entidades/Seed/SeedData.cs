using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsercionDepencencias.Consola.Entidades.Seed
{
    public class SeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            //Recursos
            var r1 = new Recurso { Id = 1, Denominacion="Video_1" };
            var r2 = new Recurso { Id = 2, Denominacion = "Video_2" };
            var r3 = new Recurso { Id = 3, Denominacion = "Imagen_1" };
            var r4 = new Recurso { Id = 4, Denominacion = "Imagen_2" };
            var r5 = new Recurso { Id = 5, Denominacion = "HTML5_1" };
            var r6 = new Recurso { Id = 6, Denominacion = "HTML5_2" };

            modelBuilder.Entity<Recurso>().HasData(r1,r2,r3,r4,r5,r6);
        }
    }
}
