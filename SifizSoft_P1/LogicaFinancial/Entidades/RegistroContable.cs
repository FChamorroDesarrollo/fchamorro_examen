using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
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
    {
        var registrosContables =
            Repositorio
            .DameLista<RegistroContable>();

        var xx =
        registrosContables
            .Select(x =>
            new
            {
                x.Documento,
                x.SecuencialOficina,
                x.EsDebito,
                x.Valor
            }
            )
            .GroupBy(x => new { x.Documento, x.SecuencialOficina, x.EsDebito })
            .ToList();


        //TODO: Implementar la logica para obtener los documentos de los registros descuadrados
    }
}