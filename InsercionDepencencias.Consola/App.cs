using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsercionDepencencias.Consola
{
    public class App
    {
        private readonly IConfiguration _config;
        private readonly MDBContext _dBContext;

        public App(IConfiguration config, MDBContext db)
        {
            Console.WriteLine("[APP.CS]: Inicio de constructor.");
            _config = config;
            _dBContext = db;
            Console.WriteLine("[APP.CS]: Fin de constructor.");
        }

        public void Run()
        {
            Console.WriteLine("[APP.CS]: Inicio de Run.");
            //var logDirectory = _config.GetValue<string>("Runtime:LogOutputDirectory");
            //var logger = new LoggerConfiguration()
            //    .WriteTo.Console()
            //    .WriteTo.File(logDirectory)
            //    .CreateLogger();

            ListarRercursos();

            Console.WriteLine("[APP.CS]: Fin de Run.");
        }

        private void ListarRercursos()
        {
            Console.WriteLine("[APP.CS]: Inicio de ListarRecursos.");


            Console.WriteLine("[APP.CS]: Fin de ListarRecursos.");
        }

    }
}
