using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace InsercionDepencencias.Consola
{
    /// <summary>
    /// Esta clase solo la creo para poder llamar a add-migration XX desde la consola de paquetes. Sino, no encuentra la clase derivada options del DBContext que estoy creando yo.
    /// </summary>
    public class MDBContextFactory : IDesignTimeDbContextFactory<MDBContext>
    {
        public MDBContext CreateDbContext(string[] args)
        {
            
            var optionsBuilder = new DbContextOptionsBuilder<MDBContext>();
            //optionsBuilder.UseSqlServer("(localdb)\\mssqllocaldb;Initial Catalog=TestInsercion;Integrated Security=True");
            optionsBuilder.UseSqlServer(args[0]);  //Cuando llamemos a add-migration, tenemos que pasar por paramentro la connectionString.


            return new MDBContext(optionsBuilder.Options);
        }

    }
}
