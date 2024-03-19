using System.Text;
using Sfz_Repositorio_Examen;
using SifizSoft_P1.LogicaFinancial.Entidades;

namespace SifizSoft_P1.LogicaFinancial
{
    public class ConsultaActivos
    {
        public IEnumerable<ActivoResumen> DRLPorSecuencialSecuencialEmpresaActivo()
            =>
                Repositorio
                    .DameLista<Activo>(x => x.EstaActivo)
                    .Select(activo => new
                    {
                        activo.Secuencial,
                        activo.NumeroSecuencial,
                        activo.Descripcion,
                        activo.CodigoCompuesto,
                        activo.NumeroSerie,
                        activo.EstaActivo,
                        activo.EsActivoDiferido,
                        activo.NumeroVerificador,
                        activo.SecuencialDivisionEstructuraActivoFijo
                    })
                    .AsEnumerable()
                    .Select(activo => new ActivoResumen(
                        activo.Secuencial,
                        activo.NumeroSecuencial,
                        DevuelveCamino(activo
                            .SecuencialDivisionEstructuraActivoFijo, ">"),
                        activo.Descripcion,
                        activo.CodigoCompuesto,
                        activo.NumeroSerie,
                        activo.EstaActivo,
                        activo.EsActivoDiferido,
                        activo.NumeroVerificador));

        private string DevuelveCamino(
            int secuencialDivision,
            string delimitador)
        {
            var cadena = new StringBuilder("");
            var padreDivision =
                Repositorio.DameUnoSinVerificarExistencia<PadreDivision>(
                    x => x.SecuencialDivision == secuencialDivision);

            if (padreDivision != null)
            {
                cadena.Append(DevuelveCamino(padreDivision.SecuencialDivisionPadre,
                    delimitador));
                cadena.Append(delimitador);
            }

            var division =
                Repositorio.DameUno<Division>(x => x.Secuencial == secuencialDivision);
            cadena.Append(division.Nombre);
            return cadena.ToString();
        }
    }
}