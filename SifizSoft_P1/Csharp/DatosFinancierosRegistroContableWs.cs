using Extensiones;
using Sfz_Repositorio_Examen;
using SifizSoft_P1.Csharp.Entidades;

namespace SifizSoft_P1.Csharp;
public class DatosFinancierosRegistroContableWs
{
    public void CreaRegistroContable(decimal valor, DateTime fecha)
    => new RegistroContableFinanciero
       {
           Valor = valor,
           Fecha = fecha
       }.Guardar();
}
