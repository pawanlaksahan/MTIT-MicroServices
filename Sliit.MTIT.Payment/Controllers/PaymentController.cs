using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Sliit.MTIT.Payment.Data;
using Sliit.MTIT.Payment.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sliit.MTIT.Payment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService ?? throw new ArgumentNullException(nameof(paymentService));
        }


        /// <summary>
        /// Get all payment
        /// </summary>
        /// <returns>return the list of payments</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_paymentService.GetPayments());
        }

        /// <summary>
        /// Get Payment by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the Payment with the passed ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _paymentService.GetPayment(id) != null ? Ok(_paymentService.GetPayment(id)) : NoContent();
        }

        /// <summary>
        /// Add payments
        /// </summary>
        /// <param name="Payment"></param>
        /// <returns>Return the added Payment</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Payment payment)
        {
            return Ok(_paymentService.AddPayment(payment));
        }

        /// <summary>
        /// Update the Payment
        /// </summary>
        /// <param name="Payment"></param>
        /// <returns>Return the updated Payment</returns>
        [HttpPut]
        public IActionResult Put([FromBody] Models.Payment payment)
        {
            return Ok(_paymentService.UpdatePayment(payment));
        }

        /// <summary>
        /// Delete the Payment with the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _paymentService.DeletePayment(id);

            return result.HasValue & result == true ? Ok($"Payment with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the Payment with ID:{id}.");
        }
    }
}
