// See https://aka.ms/new-console-template for more information
using WebAppNetCore;
using WebAppNetCore.Models;

Console.WriteLine("Bienvenido al programa");
var dataService = new DataService();
dataService.Inicializar();
Console.WriteLine("Programa finalizado con éxito");