using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SifizSoft_P1.LogicaFinancial.Entidades;

public partial class Activo
{

    public Activo()
    { 

    }
    [Key] [Column("SECUENCIAL")] public int Secuencial { get; private set; }

    [Column("SECUENCIALDIVESTRUCTURAACTFIJO")]
    public int SecuencialDivisionEstructuraActivoFijo { get; set; }

    [Column("NUMEROSECUENCIAL")] public int NumeroSecuencial { get; set; }

    [Column("DESCRIPCION")] public string Descripcion { get; set; }

    [Column("FECHAADQUISICION")] public DateTime FechaAdquisicion { get; set; }

    [Column("COSTO")] public decimal Costo { get; set; }

    [Column("MODELO")] public string Modelo { get; set; }

    [Column("MARCA")] public string Marca { get; set; }

    [Column("NUMEROSERIE")] public string NumeroSerie { get; set; }

    [Column("SECUENCIALPERSONARESPONSABLE")]
    public int SecuencialPersonaResponsable { get; set; }

    [Column("CODIGOESTADOACTIVO")] public string CodigoEstadoActivo { get; set; }

    [Column("SECUENCIALMONEDA")] public int SecuencialMoneda { get; set; }

    [Column("CODIGOUSUARIO")] public string CodigoUsuario { get; set; }

    [Column("FECHAMAQUINA")] public DateTime FechaMaquina { get; set; }

    [Column("FECHASISTEMA")] public DateTime FechaSistema { get; set; }

    [Column("ESTAACTIVO")] public bool EstaActivo { get; set; }

    [Column("NUMEROVERIFICADOR")] public int NumeroVerificador { get; set; }

    [Column("CODIGOCOMPUESTO")] public string CodigoCompuesto { get; set; }

    [Column("CODIGOUBICACION")] public string CodigoUbicacion { get; set; }

    [Column("SEPRORRATEA")] public bool SeProrratea { get; set; }

    [Column("SECUENCIALOFICINADEPARTAMENTO")]
    public int SecuencialOficinaDepartamento { get; set; }

    [Column("ESACTIVODIFERIDO")] public bool EsActivoDiferido { get; set; }

    [Column("CODIGOESTADOFISICOACTIVO")] public string CodigoEstadoFisicoActivo { get; set; }

    [Column("FACTURA")] public string Factura { get; set; }

    [Column("PROVEEDOR")] public string Proveedor { get; set; }

    [Column("INCLUYEVALORIVA")] public bool IncluyeValorIva { get; set; }

    [Column("CONCURRENCIA")]
    [ConcurrencyCheck]
    [Timestamp]
    public byte[] Concurrencia { get; private set; }


    #region Constructores

    public Activo(int secuencialDivisionEstructuraActivoFijo
        , int numeroSecuencial
        , string descripcion
        , DateTime fechaAdquisicion
        , decimal costo
        , string modelo
        , string marca
        , string numeroSerie
        , int secuencialPersonaResponsable
        , string codigoEstadoActivo
        , int secuencialMoneda
        , string codigoUsuario
        , DateTime fechaMaquina
        , DateTime fechaSistema
        , string codigoCompuesto
        , string codigoUbicacion
        , bool seProrratea
        , int secuencialOficinaDepartamento
        , bool esActivoDiferido
        , string codigoEstadoFisicoActivo
        , string factura
        , string proveedor
        , bool incluyeValorIva)
    {
        SecuencialDivisionEstructuraActivoFijo = secuencialDivisionEstructuraActivoFijo;
        NumeroSecuencial = numeroSecuencial;
        Descripcion = descripcion;
        FechaAdquisicion = fechaAdquisicion;
        Costo = costo;
        Modelo = modelo;
        Marca = marca;
        NumeroSerie = numeroSerie;
        SecuencialPersonaResponsable = secuencialPersonaResponsable;
        CodigoEstadoActivo = codigoEstadoActivo;
        SecuencialMoneda = secuencialMoneda;
        CodigoUsuario = codigoUsuario;
        FechaMaquina = fechaMaquina;
        FechaSistema = fechaSistema;
        CodigoCompuesto = codigoCompuesto;
        CodigoUbicacion = codigoUbicacion;
        SeProrratea = seProrratea;
        SecuencialOficinaDepartamento = secuencialOficinaDepartamento;
        EsActivoDiferido = esActivoDiferido;
        CodigoEstadoFisicoActivo = codigoEstadoFisicoActivo;
        Factura = factura;
        Proveedor = proveedor;
        IncluyeValorIva = incluyeValorIva;
        EstaActivo = true;
    }

    public Activo(int secuencial
        , int secuencialDivisionEstructuraActivoFijo
        , int numeroSecuencial
        , string descripcion
        , DateTime fechaAdquisicion
        , decimal costo
        , string modelo
        , string marca
        , string numeroSerie
        , int secuencialPersonaResponsable
        , string codigoEstadoActivo
        , int secuencialMoneda
        , string codigoUsuario
        , DateTime fechaMaquina
        , DateTime fechaSistema
        , string codigoCompuesto
        , string codigoUbicacion
        , bool seProrratea
        , int secuencialOficinaDepartamento
        , bool esActivoDiferido
        , string codigoEstadoFisicoActivo
        , string factura
        , string proveedor
        , bool incluyeValorIva)
    {
        Secuencial = secuencial;
        SecuencialDivisionEstructuraActivoFijo = secuencialDivisionEstructuraActivoFijo;
        NumeroSecuencial = numeroSecuencial;
        Descripcion = descripcion;
        FechaAdquisicion = fechaAdquisicion;
        Costo = costo;
        Modelo = modelo;
        Marca = marca;
        NumeroSerie = numeroSerie;
        SecuencialPersonaResponsable = secuencialPersonaResponsable;
        CodigoEstadoActivo = codigoEstadoActivo;
        SecuencialMoneda = secuencialMoneda;
        CodigoUsuario = codigoUsuario;
        FechaMaquina = fechaMaquina;
        FechaSistema = fechaSistema;
        CodigoCompuesto = codigoCompuesto;
        CodigoUbicacion = codigoUbicacion;
        SeProrratea = seProrratea;
        SecuencialOficinaDepartamento = secuencialOficinaDepartamento;
        EsActivoDiferido = esActivoDiferido;
        CodigoEstadoFisicoActivo = codigoEstadoFisicoActivo;
        Factura = factura;
        Proveedor = proveedor;
        IncluyeValorIva = incluyeValorIva;
        EstaActivo = true;
    }

    public Activo(int secuencialDivisionEstructuraActivoFijo
        , int numeroSecuencial
        , string descripcion
        , DateTime fechaAdquisicion
        , decimal costo
        , string modelo
        , string marca
        , string numeroSerie
        , int secuencialPersonaResponsable
        , string codigoEstadoActivo
        , int secuencialMoneda
        , string codigoUsuario
        , DateTime fechaMaquina
        , DateTime fechaSistema
        , bool estaActivo
        , string codigoCompuesto
        , string codigoUbicacion
        , bool seProrratea
        , int secuencialOficinaDepartamento
        , bool esActivoDiferido
        , string codigoEstadoFisicoActivo
        , string factura
        , string proveedor
        , bool incluyeValorIva)
    {
        SecuencialDivisionEstructuraActivoFijo = secuencialDivisionEstructuraActivoFijo;
        NumeroSecuencial = numeroSecuencial;
        Descripcion = descripcion;
        FechaAdquisicion = fechaAdquisicion;
        Costo = costo;
        Modelo = modelo;
        Marca = marca;
        NumeroSerie = numeroSerie;
        SecuencialPersonaResponsable = secuencialPersonaResponsable;
        CodigoEstadoActivo = codigoEstadoActivo;
        SecuencialMoneda = secuencialMoneda;
        CodigoUsuario = codigoUsuario;
        FechaMaquina = fechaMaquina;
        FechaSistema = fechaSistema;
        EstaActivo = estaActivo;
        CodigoCompuesto = codigoCompuesto;
        CodigoUbicacion = codigoUbicacion;
        SeProrratea = seProrratea;
        SecuencialOficinaDepartamento = secuencialOficinaDepartamento;
        EsActivoDiferido = esActivoDiferido;
        CodigoEstadoFisicoActivo = codigoEstadoFisicoActivo;
        Factura = factura;
        Proveedor = proveedor;
        IncluyeValorIva = incluyeValorIva;
    }


    public static void DRLPorSecuencialSecuencialEmpresaActivo()
    { 

    }


    //public string DevuelveCamino(List<Division> divisones, int secuencialDivision, string delimitador)
    //{ 
    //    var xx =
    //        divisones
    //        .GroupBy(x => x.SecuencialNivel)
    //        .Select(x => x.Key)
    //        .ToArray();
    //}
    #endregion
}