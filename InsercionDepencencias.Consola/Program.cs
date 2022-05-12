using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using InsercionDepencencias.Consola;
using Serilog;
using System.Reflection;

Console.WriteLine("[PROGRAM.CS]: Inicio");

Console.WriteLine("[PROGRAM.CS]: Llamada a metodo ConfigureServices.");
var services = ConfigureServices();

Console.WriteLine("[PROGRAM.CS]: Llamada a metodo BuildServiceProvider.");
var serviceProvider = services.BuildServiceProvider();

Console.WriteLine("[PROGRAM.CS]: Llamada a metodo ConfigureServices.");
var tmpApp = serviceProvider.GetService<App>(); //Obtenemos el objeto de tipo App de nuestro service provider y lo ejecutamos.

tmpApp.Run();

Console.ReadKey();


 IServiceCollection ConfigureServices()
{
    IServiceCollection services = new ServiceCollection();

    //Creamos un gestor de configuraciones y lo añadimos al inyector de Dependencias.
    var config = LoadConfiguration();
    services.AddSingleton(config);

    //Creamos la instancia del loger de Serilog y lo añadimos al inyector de Dependencias.
    string fileLog = System.IO.Path.Combine(config.GetSection("LogPath").Value, Assembly.GetExecutingAssembly().GetName().Name + ".log");
    CreateLogger(fileLog);
    services.AddLogging(configure => configure.AddSerilog()).AddTransient<App>();

    //Configuracion de DBContext
    var connectionstring = config.GetConnectionString("connetionTest");
    services.AddDbContext<MDBContext>(opciones => opciones.UseSqlServer(connectionstring)); //Añadimos al inyector el objeto MDBcontext.


    services.AddTransient<App>(); //Añadimos un objeto del tipo App a la lista de servicios

    return services;
}

 IConfiguration LoadConfiguration() //Metodo donde cargamos nuestro fichero appsettings.json 
{
    var builder = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

    return builder.Build();
}

void CreateLogger(string logFile)
{
    Log.Logger = new LoggerConfiguration()
               .WriteTo.Console()
               .WriteTo.File(logFile, rollingInterval: RollingInterval.Day)
               .CreateLogger();
}