using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domian.Model;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BankingController : ControllerBase
    {
        private readonly ILogger<BankingController> _logger;
        private readonly IAccountService _accountservice;

        public BankingController(ILogger<BankingController> logger, IAccountService accountService)
        {
            _logger = logger;
            _accountservice = accountService;
        }
        //Get api/banking
        [HttpGet]
        public ActionResult <IEnumerable<Account>> Get()
        {
              
            return Ok(_accountservice.GetAccounts());
        }
    }
}