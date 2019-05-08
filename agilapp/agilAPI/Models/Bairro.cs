namespace agilAPI.Models
{
    public enum BairroNames
    {
        Betania
    }
    public class Bairro
    {
        public int IdBairro { get; set; }
        public BairroNames BairroName { get; set; }

    }
}