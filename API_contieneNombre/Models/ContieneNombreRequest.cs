namespace API_contieneNombre.Models
{
    public class ContieneNombreRequest
    {
        public string[] Info { get; set; }
        public string Nombre { get; set; }
    }

    public class ContieneNombreResponse
    {
        public bool Resultado { get; set; }
    }
}
