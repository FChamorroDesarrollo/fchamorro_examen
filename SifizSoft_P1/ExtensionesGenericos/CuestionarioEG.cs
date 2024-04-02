using Extensiones;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SifizSoft_P1.ExtensionesGenericos
{
    public static class CuestionarioEG
    {
        [FbsPrueba]
        public static void EgEjercicio1_Puntaje1()
        {
            1.Noviembre(2021).Impresion();
        }

        public static string Noviembre(this int @this, int anio)
        => @this.ToString().PadLeft(2, '0') + " Noviembre " + anio.ToString();



        [FbsPrueba]
        public static void EgEjercicio2_Puntaje1()
        {
            var valor = 12;
            var meses2 = 0;

             "Yo soy el mensaje cuando sale error".ProcesaConFbsException(() => { _ = valor / meses2; }).Impresion();
        }

        public static string ProcesaConFbsException(this string @this, Action accion)
        {
            try
            {
                accion();
                return "";
            }
            catch
            {
                return @this;
            }

        }


        [FbsPrueba]
        public static async Task EgEjercicio3_Puntaje3()
        {
            var inicio = DateTime.Now;
            await 5;
            var final = DateTime.Now;

            $"{inicio} {final}".Impresion();
        }


        public static TaskAwaiter GetAwaiter(this int @segundos)
         => Task.Delay(TimeSpan.FromSeconds(segundos)).GetAwaiter();


        public static IEnumerable<T> FbsWhere<T>(this IEnumerable<T> @this, Predicate<T> condicion)
            => @this
            .Aggregate(Enumerable.Empty<T>(), 
                      (acc, item) => condicion(item) ? acc.Append(item) : acc);

        public static IEnumerable<TResult> FbsSelect<T, TResult>(this IEnumerable<T> @this, Func<T, TResult> func)
            => @this
            .Aggregate(Enumerable.Empty<TResult>(),
                      (acc, item) => acc.Append(func(item)));

    }
}