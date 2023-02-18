namespace CustomerService1.Entities
{
    public class PravnoLice
    {
        public string Naziv { get; set; }
        public string MatBr { get; set; }
        public string Faks { get; set; }
        public Guid KontaktOsobaID { get; set; }
    }
}
