using Extensiones;

namespace SifizSoft_P1.Csharp
{
    public static class CuestionarioCs
    {
        [FbsPrueba]
        public static void CsEjemplo1_Puntaje1()
        {
            var incidente1 = new Incidente { TipoIncidente = "Bugs", Mes = "Enero", Cantidad = 100 };
            var incidente2 = new Incidente { TipoIncidente = "Bugs", Mes = "Enero", Cantidad = 200 };
            //incidente1 += incidente2;
            incidente1.Impresion();
        }
    }

    public class Incidente
    {
        public required string TipoIncidente { get; set; }
        public required string Mes { get; set; }
        public required int Cantidad { get; set; }

        
    }
}
