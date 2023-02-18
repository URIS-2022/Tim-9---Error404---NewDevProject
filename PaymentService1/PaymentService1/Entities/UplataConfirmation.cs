namespace PaymentService1.Entities
{
    public class UplataConfirmation
    {
        public Guid UplataID { get; set; }
        public string brojRacuna { get; set; }
        public float iznos { get; set; }
        public Guid uplatilac { get; set; }
        public DateTime datum { get; set; }
    }
}
