using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApi.Models
{
    public class RequestRespons
    {
        public string statusCode { get; set; }
        public string ResponsMessage { get; set; }
        public List<List_of_Banks> items { get; set; }
    }
}
