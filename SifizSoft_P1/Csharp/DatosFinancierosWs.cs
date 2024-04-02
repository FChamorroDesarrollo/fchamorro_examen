using Extensiones;
using Sfz_Repositorio_Examen;
using SifizSoft_P1.Csharp.Entidades;

namespace SifizSoft_P1.Csharp;

public class DatosFinancierosWs
{
    public DatosFinancierosWs()
    {
        
    }
    public void CalculoDato(DatosFinanciero datosFinanciero, TipoInstitucion tipoInstitucion)
    => datosFinanciero
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
}