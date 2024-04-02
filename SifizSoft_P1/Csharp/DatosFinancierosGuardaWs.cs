using Extensiones;
using Sfz_Repositorio_Examen;
using SifizSoft_P1.Csharp.Entidades;

namespace SifizSoft_P1.Csharp;

public class DatosFinancierosGuardaWs
{
    private readonly ICalendarioWs _calendarioWs;

    public DatosFinancierosGuardaWs(ICalendarioWs calendarioWs)
    {
        _calendarioWs = calendarioWs;
    }

    public void Creacion(decimal valor)
    => _calendarioWs
       .DevuelveFecha()
       .FbsPipeAction(x =>
        {
            var datosFinanciero = new DatosFinanciero
            {
                Valor = valor,
                Fecha = x
            };
            datosFinanciero.Guardar();
        
            new DatosFinancierosRegistroContableWs()
               .CreaRegistroContable(valor, x);
        });

    public void Modificacion(int secuencialDatoFinanciero, decimal nuevoValor)
    => Repositorio
       .DameUno<DatosFinanciero>(x => x.Secuencial == secuencialDatoFinanciero)
       .FbsPipe(datoFinanciero =>
       {
           datoFinanciero.Valor = nuevoValor;
           return datoFinanciero;
       })
       .Guardar();




}

