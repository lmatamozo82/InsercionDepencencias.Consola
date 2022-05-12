using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
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
        private readonly MDBContext? _dBContext;
        private readonly ILogger _logger;

        public App(IConfiguration config, MDBContext db,ILogger<App> lg)
        {
            _config = config;
            _dBContext = db;
            _logger= lg;    
        }

        public void Run()
        {
            //Console.WriteLine("[APP.CS]: Inicio de Run.");
            _logger.LogInformation("[APP.CS]: Inicio de Run.");
            
            ListarRercursos();

            //Console.WriteLine("[APP.CS]: Fin de Run.");
            _logger.LogInformation("[APP.CS]: Fin de Run.");
        }

        private void ListarRercursos()
        {
            _logger.LogInformation("[APP.CS]: Inicio de ListarRecursos.");
            _logger.LogInformation("-----------------");
            _logger.LogInformation("[APP.CS]: Todos los recursos");
            foreach (var r in _dBContext.Recursos)
            {
                _logger.LogInformation("[APP.CS]: Recurso.Id=" + r.Id + ", Deno=" + r.Denominacion);
            }
            _logger.LogInformation("-----------------");
            _logger.LogInformation("[APP.CS]: Todos los recursos. Orden inverso por Id");
            foreach (var r in _dBContext.Recursos.OrderBy(x=>x.Id).Reverse())
            {
                _logger.LogInformation("[APP.CS]: Recurso.Id=" + r.Id + ", Deno=" + r.Denominacion);
            }

            _logger.LogInformation("-----------------");
            _logger.LogInformation("[APP.CS]: Solo los de Id par.");
            foreach (var r in _dBContext.Recursos.Where(x => x.Id % 2==0))
            {
                _logger.LogInformation("[APP.CS]: Recurso.Id=" + r.Id + ", Deno=" + r.Denominacion);
            }
            _logger.LogInformation("-----------------");
            _logger.LogInformation("[APP.CS]: Fin de ListarRecursos.");
        }
    }
}
