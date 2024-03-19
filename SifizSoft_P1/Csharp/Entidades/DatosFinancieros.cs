namespace SifizSoft_P1.Csharp.Entidades;

public enum TipoInstitucion
{
    MUTUALISTA,
    COAC
}
public class DatosFinanciero
{
    public int Secuencial { get; set; }
    public decimal Valor { get; set; }
    public decimal DatoCalculado { get; set; }
    public TipoInstitucion TipoOperacion { get; set; }
    public DateTime Fecha { get; set; }
}

public class RegistroContableFinanciero
{
    public int Secuencial { get; set; }
    public decimal Valor { get; set; }
    public DateTime Fecha { get; set; }
}