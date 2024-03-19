using Extensiones;
using System.Diagnostics;

namespace SifizSoft_P1.ExtensionesGenericos
{
    public static class CuestionarioEG
    {
        [FbsPrueba]
        public static void EgEjercicio1_Puntaje1()
        {
            "01 de noviembre del 2021".Impresion();
        }

        [FbsPrueba]
        public static void EgEjercicio2_Puntaje1()
        {
            var valor = 12;
            var meses2 = 0;
            //"Yo soy el mensaje cuando sale error".ProcesaConFbsException(() => { _ = valor / meses2; }).Impresion();
        }

        [FbsPrueba]
        public static async Task EgEjercicio3_Puntaje3()
        {
            var inicio = DateTime.Now;

            await Task.Delay(5000);

            //await 5;
            var final = DateTime.Now;

            $"{inicio} {final}".Impresion();
        }
    }
}