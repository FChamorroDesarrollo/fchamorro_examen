using System.Globalization;
using CsvHelper;

namespace Sfz_Repositorio_Examen;

public class Repositorio
{
    public static Dictionary<string, List<object>> Datos { get; } = new();

    public static void CargarDatos<T>(string rutaArchivo)
    {
        using var reader = new StreamReader(rutaArchivo);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

        var registros = csv.GetRecords<T>().ToList();
        Datos[typeof(T).FullName!] = registros.Select(x => (object)x).ToList();
    }

    public static IEnumerable<T> DameLista<T>(Func<T, bool> expression)
        => Datos[typeof(T).FullName!]!.Select(x => (T)x).Where(expression);

    public static IEnumerable<T> DameLista<T>()
        => Datos[typeof(T).FullName!]!.Select(x => (T)x);

    public static T DameUno<T>(Func<T, bool> expression)
        =>
            (Datos[typeof(T).FullName!]! as List<T>)!.First(expression);

    public static T DameUnoSinVerificarExistencia<T>(Func<T, bool> expression)
        =>
            (Datos[typeof(T).FullName!]! as List<T>)!.FirstOrDefault(expression);
}