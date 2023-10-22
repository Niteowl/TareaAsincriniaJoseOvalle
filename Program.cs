// Tarea1
using System;
using System.Diagnostics;
using System.Text;

Random random = new Random();
int cantidadDeTarjetas = 1000;

for (int i = 0; i < cantidadDeTarjetas; i++)
{
    string numeroDeTC = GenerarNumeroDeTarjeta();
    Console.WriteLine(numeroDeTC);
    ProcesarTarjetas();
}
Stopwatch sw = Stopwatch.StartNew();

Console.WriteLine("Procesando pago, por favor espere...");

//for (int i = 0; i < cantidadDeTarjetas; i++)
//{
//    ProcesarTarjetas();
//}

await Task.Delay(10000);

sw.Stop();

Console.WriteLine($"Todos los pagos fueron procesados: {TimeSpan.FromMilliseconds(sw.ElapsedMilliseconds).TotalSeconds} segundos");

Console.WriteLine("Programa finalizado.");

string GenerarNumeroDeTarjeta()
{
    string numeroDeTC="4";
    for (int i = 0; i < 15; i++)
    {
        numeroDeTC = numeroDeTC + random.Next(10); // Genera un dígito aleatorio
    }
    return numeroDeTC;
}

async Task ProcesarTarjetas()
{
    await Task.Delay(10000);
}


