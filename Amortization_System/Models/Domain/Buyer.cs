using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amortization_System.Models.Domain
{
    public class Buyer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [DisplayName("Buyer Name")]
        public string buyer_name { get; set; }
        [DisplayName("Address")]
        public string? address { get; set; }
        [DisplayName("Project Name")]
        public string? project_name { get; set; }
        [DisplayName("Loan Amount")]
        public double loan_amount { get; set; }
        [DisplayName("Payment Start")]
        public DateTime payment_start { get; set; }
        [DisplayName("Condo Unit")]
        public string? condo_unit { get; set; }
        [DisplayName("Payment Term")]
        public int payment_term { get; set; }
        [DisplayName("Interest Rate")]
        public double interest_rate { get; set; }
    }
}
