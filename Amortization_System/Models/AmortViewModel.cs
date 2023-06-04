namespace Amortization_System.Models
{
    public class AmortViewModel
    {
        public int PaymentNumber { get; set; }
        public DateTime PaymentDate { get; set; }
        public double PaymentAmount { get; set; }
        public double PrincipalPayment { get; set; }
        public double InterestPayment { get; set; }
        public double RemainingBalance { get; set; }
    }
}
