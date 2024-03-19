using Extensiones;
using Sfz_Repositorio_Examen;
using SifizSoft_P1.Csharp.Entidades;

namespace SifizSoft_P1.Csharp;

public class DatosFinancierosWs
{
    private readonly ICalendarioWs _calendarioWs;

    public DatosFinancierosWs(ICalendarioWs calendarioWs)
    {
        _calendarioWs = calendarioWs;
    }

    public void Creacion(decimal valor)
    {
        var fecha = _calendarioWs.DevuelveFecha();
        new DatosFinanciero()
            {
                Valor = valor,
                Fecha = fecha
            }
            .Guardar();
        CreaRegistroContable(valor, fecha);
    }


    public void Modificacion(int secuencialDatoFinanciero, decimal nuevoValor)
        =>
            Repositorio
                .DameUno<DatosFinanciero>(x => x.Secuencial == secuencialDatoFinanciero)
                .FbsPipe(datoFinanciero =>
                {
                    datoFinanciero.Valor = nuevoValor;
                    return datoFinanciero;
                })
                .Guardar();


    public void CalculoDato(DatosFinanciero datosFinanciero, TipoInstitucion tipoInstitucion)
        =>
            datosFinanciero
                .FbsPipe(datoFinanciero =>
                {
                    switch (tipoInstitucion)
                    {
                        case TipoInstitucion.MUTUALISTA:
                            datoFinanciero.DatoCalculado = datoFinanciero.Valor * 100;
                            break;
                        case TipoInstitucion.COAC:
                            datoFinanciero.DatoCalculado = datoFinanciero.Valor * datoFinanciero.Valor * 10 / 100;
                            break;
                    }

                    return datoFinanciero;
                })
                .Guardar();

    private void CreaRegistroContable(decimal valor, DateTime fecha)
        => new RegistroContableFinanciero
        {
            Valor = valor,
            Fecha = fecha
        }.Guardar();
}