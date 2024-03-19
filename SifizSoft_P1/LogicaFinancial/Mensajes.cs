namespace SifizSoft_P1.LogicaFinancial;

public class ActivoResumen
{

    public int Secuencial { get; set; }
    public int NumeroSecuencial { get; set; }
    public string NombreDivisionEstructuraActivoFijo { get; set; }
    public string Descripcion { get; set; }
    public string CodigoCompuesto { get; set; }
    public string NumeroSerie { get; set; }
    public bool EstaActivo { get; set; }
    public bool EsActivoDiferido { get; set; }
    public int NumeroVerificador { get; set; }

    public ActivoResumen(
        int secuencial,
        int numeroSecuencial,
        string nombreDivisionEstructuraActivoFijo,
        string descripcion,
        string codigoCompuesto,
        string numeroSerie,
        bool estaActivo,
        bool esActivoDiferido,
        int numeroVerificador)
    {
        Secuencial = secuencial;
        NumeroSecuencial = numeroSecuencial;
        NombreDivisionEstructuraActivoFijo = nombreDivisionEstructuraActivoFijo;
        Descripcion = descripcion;
        CodigoCompuesto = codigoCompuesto;
        NumeroSerie = numeroSerie;
        EstaActivo = estaActivo;
        EsActivoDiferido = esActivoDiferido;
        NumeroVerificador = numeroVerificador;
    }
}


public class DRLPorSecuencialSecuencialEmpresaME
{
    public int Secuencial { get; set; }
    public int SecuencialEmpresa { get; set; }
    public bool Ascendente { get; set; }
    public int NumeroRegistros { get; set; }
    public bool DevuelveActivos { get; set; }


    public bool DevuelveInactivos { get; set; }

    public DRLPorSecuencialSecuencialEmpresaME() { }

    public DRLPorSecuencialSecuencialEmpresaME(
        int secuencial,
        int secuencialEmpresa,
        bool ascendente,
        int numeroRegistros,
        bool devuelveActivos,
        bool devuelveInactivos)
    {
        Secuencial = secuencial;
        SecuencialEmpresa = secuencialEmpresa;
        Ascendente = ascendente;
        NumeroRegistros = numeroRegistros;
        DevuelveActivos = devuelveActivos;
        DevuelveInactivos = devuelveInactivos;
    }
}