
using CalculateAreaLib.Models;
using CalculateAreaLib.Models.Base;
using CalculateAreaLib.Models.Enums;
using CalculateAreaLib.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
         services.AddScoped<IParam, TriangleParam>()
        .AddScoped<IParam, CircleParam>()).Build();


//.AddScoped<IScopedOperation, DefaultOperation>()
//.AddSingleton<ISingletonOperation, DefaultOperation>()
//.AddTransient<OperationLogger>())
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var b = new TriangleParam() { figure = Figure.Trialnge, SideA = 3, SideB = 4, SideC = 5 };
var c = new CircleParam() { figure = Figure.Circle, Radius = 6 };
var a = new CalculateAreaService();
a.CheckRightTriangle(b);
Console.WriteLine(a.CalculateAreaCircle(c));
Console.WriteLine( a.CheckFigure(b));


Console.ReadKey();

