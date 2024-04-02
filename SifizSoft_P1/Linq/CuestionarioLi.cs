using Extensiones;

namespace SifizSoft_P1.Linq
{
    public static class CuestionarioLi
    {

        [FbsPrueba]
        public static void LiEjercicio1_Puntaje2()
        {

            var salesData = new List<Incidentes>
            {
                new Incidentes { TipoIncidente = "Bugs", Mes = "Enero", Cantidad = 100 },
                new Incidentes { TipoIncidente = "Bugs", Mes = "Febrero", Cantidad = 150 },
                new Incidentes { TipoIncidente = "Mantenimiento", Mes = "Enero", Cantidad = 200 },
                new Incidentes { TipoIncidente = "Mantenimiento", Mes = "Febrero", Cantidad = 250 },
                new Incidentes { TipoIncidente = "Proyectos", Mes = "Enero", Cantidad = 300 },
            };

            //TODO: Obtener por TipoIncidente la cantidad ocurrida en cada mes usando la extensión Pivot.
            salesData
                .Pivot(x => x.Mes, y => y.TipoIncidente, z => z.Sum(x => x.Cantidad))
                .Impresion();

        }
    }

    public class Incidentes
    {
        public required string TipoIncidente { get; set; }
        public required string Mes { get; set; }
        public required int Cantidad { get; set; }
    }

}
