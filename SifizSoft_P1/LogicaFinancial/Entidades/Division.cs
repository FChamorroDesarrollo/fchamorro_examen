using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SifizSoft_P1.LogicaFinancial.Entidades;

public partial class Division
{

    public Division()
    {
    }

    [Key]
    [Column("SECUENCIAL")]
    public int Secuencial { get; private set; }

    [Column("SECUENCIALDIVISIONPADRE")]
    public int? SecuencialDivisionPadre { get; set; }

    [Column("SECUENCIALNIVEL")]
    public int SecuencialNivel { get; set; }

    [Column("CODIGO")]
    public string Codigo { get; set; }

    [Column("NOMBRE")]
    public string Nombre { get; set; }

    [Column("NUMEROVERIFICADOR")]
    public int NumeroVerificador { get; set; }

    [Column("CONCURRENCIA")]
    [ConcurrencyCheck]
    [Timestamp]
    public byte[] Concurrencia { get; private set; }

  
    #region Constructores

    public Division(int secuencialNivel
        , string codigo
        , string nombre
        , int? secuencialDivisionPadre)
    {
        SecuencialNivel = secuencialNivel;
        Codigo = codigo;
        Nombre = nombre;
        SecuencialDivisionPadre = secuencialDivisionPadre;
    }
    public Division(int secuencial
        , int secuencialNivel
        , string codigo
        , string nombre
        , int? secuencialDivisionPadre)
    {
        Secuencial = secuencial;
        SecuencialNivel = secuencialNivel;
        Codigo = codigo;
        Nombre = nombre;
        SecuencialDivisionPadre = secuencialDivisionPadre;
    }
    #endregion

}