namespace PaymentService1.Entities
{
    public class Uplata
    {
        public Guid UplataID { get; set; }
        public string brojRacuna { get; set; }
        public string pozivNaBroj { get; set; }
        public float iznos { get; set; }
        public Guid uplatilac { get; set; }
        public string svrhaUplate { get; set; }
        public DateTime datum { get; set; }
        public Guid javnoNadmetanje { get; set; }
    }
}
