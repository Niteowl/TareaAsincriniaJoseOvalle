// Tarea2
using System;
using System.Diagnostics;
using System.Text;

Random random = new Random();
string nombre = "";
Console.WriteLine("Descarga informacion de usuarios: ");

while (true)
{
    Console.WriteLine("\nIngrese Nombre");
    nombre = Console.ReadLine();
    _ = DescargaDeDatos(nombre);
}

async Task DescargaDeDatos(string nombreEntrada)
{
    int tiempoEspera = random.Next(10000, 60000);
    await Task.Delay(tiempoEspera);
    tiempoEspera = tiempoEspera / 1000;
    Debug.WriteLine($"Información de {nombreEntrada} descargada con éxito en aprox {tiempoEspera} seg");
}