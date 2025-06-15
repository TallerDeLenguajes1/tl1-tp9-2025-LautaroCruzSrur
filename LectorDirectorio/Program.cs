using System;
using System.IO;


Console.WriteLine("Ingrese el 'path' de un directorio para analizar ");
string ruta = Console.ReadLine() ?? ""; //VOlver a solicitar si es vacio

if (!File.Exists(ruta)) // Una vez que sabemos que existe listar las carpetas y archivos(KB)
{
    DirectoryInfo directory = new DirectoryInfo(ruta);
    FileInfo[] files = directory.GetFiles();
    List<string> Lineas = new List<string>();

    foreach (FileInfo file in files)
    {
        Console.WriteLine($"Nombre: {file.Name}, Tamaño: {file.Length} bytes");
        Lineas.Add($"Nombre: {file.Name}");
        Lineas.Add($"Tamaño: {file.Length}");
        Lineas.Add($"Ultimo acceso: {file.LastAccessTime}");

    }
    string rutaParaGuardar = Path.Combine(ruta, "listado.csv");
    File.WriteAllLines(rutaParaGuardar, Lineas);
        
}




