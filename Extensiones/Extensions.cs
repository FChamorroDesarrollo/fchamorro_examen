using Dumpify;
using System.Runtime.CompilerServices;

namespace Extensiones
{
    public static class PruebaExtensiones
    {
        public static void Impresion(this object @this, [CallerMemberName] string nombreMetodo = "")
        {
            if (!string.IsNullOrEmpty(nombreMetodo))
                nombreMetodo = $"Resultado : {nombreMetodo}";
            @this.Dump(nombreMetodo);
        }


        public static IEnumerable<IGrouping<TKey, IDictionary<TColumn, TValue>>> Pivot<TSource, TKey, TColumn, TValue>(
            this IEnumerable<TSource> source, Func<TSource, TKey> rowSelector,
            Func<TSource, TColumn> columnSelector, Func<IEnumerable<TSource>, TValue> valueSelector)
        {
            return source
                .GroupBy(rowSelector)
                .Select(g => new
                {
                    RowKey = g.Key,
                    Columns = source.Select(columnSelector).Distinct(),
                    Values = g
                        .GroupBy(columnSelector)
                        .ToDictionary(g2 => g2.Key, g2 => valueSelector(g2))
                })
                .GroupBy(x => x.RowKey, x => x.Values);
        }

        public static TReturn FbsPipe<T, TReturn>(this T @this, Func<T, TReturn> funcion)
            => funcion(@this);

        public static void FbsPipeAction<T>(this T @this, Action<T> accion)
            => accion(@this);

        public static void Guardar<T>(this T @this)
        {
        }
    }
}