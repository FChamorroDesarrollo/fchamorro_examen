namespace SifizSoft_P1
{

    public class DatoPersona
    {
        public string Nombre { get; set; }
        public string Empresa { get; set; }
        public DatoPersona(string nombre, string empresa)
        {
            Nombre = nombre;
            Empresa = empresa;
        }
    }
}
