using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeonCustomerTracker.ApiModels
{
    public class ClientDetailsDto
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime birthday { get; set; } // Todo Consider update type in future
        public int totalSpending { get; set; }
    }
}
