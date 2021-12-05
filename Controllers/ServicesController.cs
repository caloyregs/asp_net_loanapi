using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LoanApi.Repository;
using LoanApi.Services;
using Microsoft.AspNetCore.SignalR;
using LoanApi.Models;
using System.Collections;

namespace LoanApi.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {

        public ServicesController()
        {
        }

        // GET api/Services
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            
            //RecurringJob.AddOrUpdate("Updating Order Screen", () => RefreshOrderAsync("hello from tester"), Cron.Minutely);
            //RecurringJob.AddOrUpdate<OrderHub>("Boardcast Message", x => x.Send("Hello From Tester"), Cron.Minutely);

            return Ok( new { Status = "Ok" });
        }
        

    }
}