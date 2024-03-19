using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SifizSoft_P1.LogicaFinancial.Entidades;

public partial class PadreDivision
{
    public PadreDivision()
    {
    }

    [Key] [Column("SECUENCIALDIVISION")] public int SecuencialDivision { get; private set; }

    [Column("SECUENCIALDIVISIONPADRE")] public int SecuencialDivisionPadre { get; set; }

    [Column("NUMEROVERIFICADOR")] public int NumeroVerificador { get; set; }

    [Column("CONCURRENCIA")]
    [ConcurrencyCheck]
    [Timestamp]
    public byte[] Concurrencia { get; private set; }


    #region Constructores

    public PadreDivision(int secuencialDivisionPadre)
    {
        SecuencialDivisionPadre = secuencialDivisionPadre;
    }

    public PadreDivision(int secuencialDivision
        , int secuencialDivisionPadre)
    {
        SecuencialDivision = secuencialDivision;
        SecuencialDivisionPadre = secuencialDivisionPadre;
    }

    #endregion
}