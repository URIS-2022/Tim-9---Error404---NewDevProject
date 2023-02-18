namespace PaymentService1.Models
{
    public class KupacDto
    {
        public Guid KupacID { get; set; }
        public bool FizPravno { get; set; }
        public string OstvarenaPovrsina { get; set; }
        public string BrTel1 { get; set; }
        public string Email { get; set; }
        public string BrojRacuna { get; set; }
    }
}
