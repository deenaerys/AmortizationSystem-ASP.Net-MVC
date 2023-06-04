using Amortization_System.Data;
using Amortization_System.Models;
using Amortization_System.Models.Domain;
using Amortization_System.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Amortization_System.Controllers
{
    public class BuyersController : Controller
    {
        private readonly AmorDbContext amorDbContext;

        public BuyersController(AmorDbContext amorDbContext)
        {
            this.amorDbContext = amorDbContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var buyers = amorDbContext.Buyers.ToList();
            List<BuyerViewModel> buyerlist = new List<BuyerViewModel>();
            if (buyers != null)
            {
              
                foreach (var buyer in buyers)
                {
                    var BuyerViewModel = new BuyerViewModel()
                    {
                        id=buyer.id,
                        buyer_name=buyer.buyer_name,
                        address=buyer.address,
                        project_name=buyer.project_name,
                        loan_amount=buyer.loan_amount,
                        payment_start=buyer.payment_start,
                        condo_unit=buyer.condo_unit,
                        payment_term=buyer.payment_term,
                        interest_rate=buyer.interest_rate

                    };
                    buyerlist.Add(BuyerViewModel);
                }
                return View(buyerlist);
            }
            return View(buyerlist);
        }

        [HttpGet]
        public IActionResult Create()
        { 
            return View(); 
        }

        [HttpPost]
        public IActionResult Create(BuyerViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var buyer = new Buyer()
                    {
                        buyer_name = model.buyer_name,
                        address = model.address,
                        project_name = model.project_name,
                        loan_amount = model.loan_amount,
                        payment_start = model.payment_start,
                        condo_unit = model.condo_unit,
                        payment_term = model.payment_term,
                        interest_rate = model.interest_rate

                    };
                    amorDbContext.Buyers.Add(buyer);
                    amorDbContext.SaveChanges();
                    TempData["successMessage"] = "Buyer is added successfully.";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["errorMessage"] = "Data is not valid.";
                    return View();
                }
            }
            catch (Exception ex)
            {

                TempData["errorMessage"] = ex.Message;
                return View();
            }
           
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            try
            {
                var buyer = amorDbContext.Buyers.SingleOrDefault(x => x.id == id);
                if (buyer != null)
                {
                    var buyerView = new BuyerViewModel()
                    {
                        id = buyer.id,
                        buyer_name = buyer.buyer_name,
                        address = buyer.address,
                        project_name = buyer.project_name,
                        loan_amount = buyer.loan_amount,
                        payment_start = buyer.payment_start,
                        condo_unit = buyer.condo_unit,
                        payment_term = buyer.payment_term,
                        interest_rate = buyer.interest_rate

                    };
                    return View(buyerView);

                }
                else
                {
                    TempData["errorMessage"] = $"Buyer details not available with ID:{id}";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {

                TempData["errorMessage"] = ex.Message;
                return RedirectToAction("Index");
            }
          

        }

        [HttpPost]
        public IActionResult Edit(BuyerViewModel model) 
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var buyer = new Buyer()
                    {
                        id = model.id,
                        buyer_name = model.buyer_name,
                        address = model.address,
                        project_name = model.project_name,
                        loan_amount = model.loan_amount,
                        payment_start = model.payment_start,
                        condo_unit = model.condo_unit,
                        payment_term = model.payment_term,
                        interest_rate = model.interest_rate

                    };
                    amorDbContext.Buyers.Update(buyer);
                    amorDbContext.SaveChanges();
                    TempData["successMessage"] = "Buyer details updated successfully.";
                    return RedirectToAction("Index");

                }
                else
                {
                    TempData["errorMessage"] = "Invalid Details";
                    return View();
                }
            }
            catch (Exception ex)
            {

                TempData["errorMessage"] = ex.Message ;
                return View();
            }
            
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            try
            {
                var buyer = amorDbContext.Buyers.SingleOrDefault(x => x.id == id);
                if (buyer != null)
                {
                    var buyerView = new BuyerViewModel()
                    {
                        id = buyer.id,
                        buyer_name = buyer.buyer_name,
                        address = buyer.address,
                        project_name = buyer.project_name,
                        loan_amount = buyer.loan_amount,
                        payment_start = buyer.payment_start,
                        condo_unit = buyer.condo_unit,
                        payment_term = buyer.payment_term,
                        interest_rate = buyer.interest_rate

                    };
                    return View(buyerView);

                }
                else
                {
                    TempData["errorMessage"] = $"Buyer details not available with ID:{id}";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {

                TempData["errorMessage"] = ex.Message;
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public IActionResult Delete(BuyerViewModel model)
        {
            try
            {
                var buyer = amorDbContext.Buyers.SingleOrDefault(x => x.id == model.id);
                if (buyer != null)
                {
                    amorDbContext.Buyers.Remove(buyer);
                    amorDbContext.SaveChanges();
                    TempData["successMessage"] = "Buyer is deleted successfully.";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["errorMessage"] = $"Buyer details not available with ID:{model.id}";
                    return RedirectToAction("Index");

                }
            }
            catch (Exception ex)
            {

                TempData["errorMessage"] = ex.Message;
                return RedirectToAction("Index");
            }

        }

        [HttpGet]
        public IActionResult Buyer(int id)
        {
            try
            {
                var buyer = amorDbContext.Buyers.SingleOrDefault(x => x.id == id);
                if (buyer != null)
                {
                    var buyerView = new BuyerViewModel()
                    {
                        id = buyer.id,
                        buyer_name = buyer.buyer_name,
                        address = buyer.address,
                        project_name = buyer.project_name,
                        loan_amount = buyer.loan_amount,
                        payment_start = buyer.payment_start,
                        condo_unit = buyer.condo_unit,
                        payment_term = buyer.payment_term,
                        interest_rate = buyer.interest_rate

                    };
                    return View(buyerView);

                }
                else
                {
                    TempData["errorMessage"] = $"Buyer details not available with ID:{id}";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {

                TempData["errorMessage"] = ex.Message;
                return RedirectToAction("Index");
            }


        }



        [HttpGet]
        public IActionResult Amort(int id) 
        {
            var buyer = amorDbContext.Buyers.SingleOrDefault(x => x.id == id);
            List<AmortViewModel > amortizationSchedule = new List<AmortViewModel >();

            double remainingBalance = buyer.loan_amount ;
            double monthlyInterestRate = buyer.interest_rate/100;// 12;
            int numberOfPayments = buyer.payment_term ;
            DateTime starting= buyer.payment_start ;
           double monthlyPaymentAmount = buyer.loan_amount * (monthlyInterestRate / (1 - Math.Pow(1 + monthlyInterestRate, -buyer.payment_term)));
            for (int paymentNumber = 1; paymentNumber <= numberOfPayments; paymentNumber++)
            {
                DateTime paymentDate = starting.AddMonths(paymentNumber - 1);
                double interestPayment = remainingBalance * monthlyInterestRate;
                double principalPayment = monthlyPaymentAmount - interestPayment;
                double paymentAmount = principalPayment + interestPayment;

                remainingBalance -= principalPayment;

                AmortViewModel scheduleItem = new AmortViewModel
                {
                    PaymentNumber = paymentNumber,
                    PaymentDate = paymentDate,
                    PaymentAmount = paymentAmount,
                    PrincipalPayment = principalPayment,
                    InterestPayment = interestPayment,
                    RemainingBalance = remainingBalance
                };

                amortizationSchedule.Add(scheduleItem);
            }
            return View(amortizationSchedule);
        }
    }
}
