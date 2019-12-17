using LeonCustomerTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeonCustomerTracker.Utilities
{
    public class GeneralUtil : IGeneralUtil
    {

        public Rank getClientRank(int clientTotalSpending)
        {
            // logic to return rank
            Rank result;

            if (clientTotalSpending >= 0 && clientTotalSpending < 101)
            {
                // Normal 0 - 100
                result = Rank.Normal;
            }
            else if (clientTotalSpending >= 101 && clientTotalSpending < 1001)
            {
                // Good 101 - 1000
                result = Rank.Good;
            }
            else
            {
                // VIP 1001+
                result = Rank.VIP;
            }
            return result;
        }
    }
}
