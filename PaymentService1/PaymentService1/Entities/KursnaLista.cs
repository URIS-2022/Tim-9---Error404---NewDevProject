namespace PaymentService1.Entities
{
    public class KursnaLista
    {
        public Guid KursnaListaID { get; set; }
        public DateTime datum { get; set; }
        public string valuta { get; set; }
        public float vrednost { get; set; }
    }
}
