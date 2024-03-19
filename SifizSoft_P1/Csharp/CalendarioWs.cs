namespace SifizSoft_P1.Csharp;

public interface ICalendarioWs
{
    DateTime DevuelveFecha();
}

public class CalendarioWs : ICalendarioWs
{
    public DateTime DevuelveFecha() => new ();
}