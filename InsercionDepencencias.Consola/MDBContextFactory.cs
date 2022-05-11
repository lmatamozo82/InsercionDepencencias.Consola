using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Linq;

namespace InsercionDepencencias.Consola
{
    /// <summary>
    /// Esta clase solo la creo para poder llamar a add-migration XX desde la consola de paquetes. Sino, no encuentra la clase derivada options del DBContext que estoy creando yo.
    /// </summary>
    public class MDBContextFactory : IDesignTimeDbContextFactory<MDBContext>
    {
        public MDBContext CreateDbContext(string[] args)
        {
            string conectionString = string.Join(" ",args);
            var optionsBuilder = new DbContextOptionsBuilder<MDBContext>();
            optionsBuilder.UseSqlServer(conectionString);  //Cuando llamemos a add-migration, tenemos que pasar por paramentro la connectionString.
           


            return new MDBContext(optionsBuilder.Options);
        }

    }
}
