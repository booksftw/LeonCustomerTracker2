using LeonCustomerTracker.Entities;

namespace LeonCustomerTracker.Utilities
{
    public interface IGeneralUtil
    {
        Rank getClientRank(int clientTotalSpending);
    }
}