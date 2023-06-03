using System.ComponentModel;

namespace Amortization_System.Models.ViewModels
{
    public class AddBuyerRequest
    {
        public string buyer_name { get; set; }
        public string address { get; set; }
        public string project_name { get; set; }
        public double loan_amount { get; set; }
        public DateTime payment_start { get; set; }
        public string condo_unit { get; set; }
        public int payment_term { get; set; }
        public double interest_rate { get; set; }
    }
}
