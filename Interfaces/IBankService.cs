using BankApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApi.Interfaces
{
    public interface IBankService
    {
        List_of_Banks GetListOfBanks();
    }
}
