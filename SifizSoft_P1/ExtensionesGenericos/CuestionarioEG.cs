using Extensiones;

namespace SifizSoft_P1.ExtensionesGenericos
{
    public static class CuestionarioEG
    {
        [FbsPrueba]
        public static void EgEjercicio1_Puntaje1()
        {
            //1.Noviembre(2021).Impresion();
        }

        [FbsPrueba]
        public static void EgEjercicio2_Puntaje1()
        {
            var valor = 12;
            var meses2 = 0;
            // "Yo soy el mensaje cuando sale error".ProcesaConFbsException(() => { _ = valor / meses2; }).Impresion();
        }

        [FbsPrueba]
        public static async Task EgEjercicio3_Puntaje3()
        {
            var inicio = DateTime.Now;
            //await 5;
            var final = DateTime.Now;

            $"{inicio} {final}".Impresion();
        }
    }
}