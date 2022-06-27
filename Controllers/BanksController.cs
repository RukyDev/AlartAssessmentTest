using Abp.UI;
using BankApi.Interfaces;
using BankApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BanksController : ControllerBase
    {
        private readonly IBankService _bankService;

        public BanksController(IBankService bankService)
        {
            _bankService = bankService;
        }

        [HttpGet("GetListOfBanks")]
        public List_of_Banks GetListOfBanks()
        {
            var items = _bankService.GetListOfBanks();
            if (items == null)
            {
                return items;
            }
            else
            {
                return items;
            }
        }
    }
}
