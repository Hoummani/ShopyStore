namespace WebAPIPayement.Models
{
    public class PayementDetail
    {
        public int Id { get; set; }
        public string CardOwnerName { get; private set; }
        public string CardNumber { get; private set; }
        public string ExpirationDate { get; private set; }
        public string CVV { get; private set; }
    }
}