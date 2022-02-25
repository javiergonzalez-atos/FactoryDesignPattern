using FactoryDesignPattern.Services;
using Microsoft.AspNetCore.Mvc;

namespace FactoryDesignPattern.Controllers
{
    [ApiController]
    [Route("api/bank/")]
    public class BankController : Controller
    {
        private readonly IBankService _bankService;

        public BankController(IBankService bankService)
        {
            _bankService = bankService;
        }
        
        [HttpGet]
        [Route("pay")]
        public IActionResult Pay()
        {
            var response = _bankService.MakePayment();
            return Ok(response);
        }
        
        [HttpGet]
        [Route("void")]
        public IActionResult Void()
        {
            var response = _bankService.MakeVoid();
            return Ok(response);
        }
        
        [HttpGet]
        [Route("refund")]
        public IActionResult Refund()
        {
            var response = _bankService.MakeRefund();
            return Ok(response);
        }
    }
}