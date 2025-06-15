using System;
using System.IO;


Console.WriteLine("Ingrese el 'path' de un directorio para analizar ");
string ruta = Console.ReadLine() ?? ""; //VOlver a solicitar si es vacio

if (!File.Exists(ruta)) // Una vez que sabemos que existe listar las carpetas y archivos(KB)
{
    DirectoryInfo directory = new DirectoryInfo(ruta);
    FileInfo[] files = directory.GetFiles();
    List<string> lineasCombinadas = new List<string>();
    lineasCombinadas.Add("Nombre , Tamaño , UltimoAcceso");
    foreach (FileInfo file in files)
    {
        Console.WriteLine($"Nombre: {file.Name}, Tamaño: {file.Length} bytes");
        lineasCombinadas.Add($"{file.Name},{file.Length},{file.LastAccessTime:dd-MM-yyyy HH:mm:ss}");
    }
    string rutaParaGuardar = Path.Combine(ruta, "reporte_archivos.csv");
    File.WriteAllLines(rutaParaGuardar, lineasCombinadas);
        
}




