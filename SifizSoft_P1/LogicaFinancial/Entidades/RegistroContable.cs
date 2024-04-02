using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using Extensiones;
using Sfz_Repositorio_Examen;

namespace SifizSoft_P1.LogicaFinancial.Entidades;

public partial class RegistroContable
{
    [Key] [Column("SECUENCIAL")] public int Secuencial { get; set; }

    [Column("VALOR")] public decimal Valor { get; set; }

    [Column("ESDEBITO")] public bool EsDebito { get; set; }

    [Column("DOCUMENTO")] public string Documento { get; set; }

    [Column("DETALLE")] public string Detalle { get; set; }

    [Column("ESTACONTABILIZADO")] public bool EstaContabilizado { get; set; }

    [Column("SECUENCIALCUENTACONTABLE")] public int SecuencialCuentaContable { get; set; }

    [Column("SECUENCIALOFICINA")] public int SecuencialOficina { get; set; }

    [Column("SECUENCIALPERFILCONTABLE")] public int SecuencialPerfilContable { get; set; }

    [Column("CODIGOUSUARIO")] public string CodigoUsuario { get; set; }

    [Column("SECUENCIALMONEDA")] public int SecuencialMoneda { get; set; }

    [Column("FECHASISTEMAREGISTRO")] public DateTime FechaSistemaRegistro { get; set; }

    [Column("FECHAMAQUINAREGISTRO")] public DateTime FechaMaquinaRegistro { get; set; }

    [Column("ESTAACTIVA")] public bool EstaActiva { get; set; }

    [Column("GENERARCHEQUE")] public bool GenerarCheque { get; set; }

    [Column("GENERACIONENLINEA")] public bool GeneracionEnLinea { get; set; }

    [Column("ESREVERSO")] public bool EsReverso { get; set; }

    [Column("ESMOVIMIENTODETALLE")] public bool EsMovimientoDetalle { get; set; }

    [Column("ESMOVIMIENTOCONTROL")] public bool EsMovimientoControl { get; set; }

    [Column("CONCURRENCIA")]
    [ConcurrencyCheck]
    [Timestamp]
    public byte[] Concurrencia { get; private set; }

    public static void ConsultaDocumentosRegistrosDescuadrados()
    => Repositorio
      .DameLista<RegistroContable>()
      .GroupBy(x => new
      {
          x.Documento,
          x.SecuencialOficina
      })
      .Select(y => new
      {
          y.Key.Documento,
          y.Key.SecuencialOficina,
          ValorDebito = y.Sum(x => x.EsDebito ? x.Valor : 0),
          ValorCredito = y.Sum(x => x.EsDebito ? 0 : x.Valor)
      })
      .Where(x => x.ValorDebito != x.ValorCredito)
      .Select(x => x.Documento)
      .Impresion("ConsultaDocumentosRegistrosDescuadrados");

        //TODO: Implementar la logica para obtener los documentos de los registros descuadrados
    
}