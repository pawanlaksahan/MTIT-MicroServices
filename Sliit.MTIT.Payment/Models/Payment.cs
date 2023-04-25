namespace Sliit.MTIT.Payment.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int CardNumber { get; set; }
        public string? ExpiryDate { get; set; }
        public int CVC { get; set; }
        public int Amount { get; set; }
    }
}
