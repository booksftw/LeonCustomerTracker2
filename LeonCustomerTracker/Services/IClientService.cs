using LeonCustomerTracker.ApiModels;

namespace LeonCustomerTracker.Services
{
    public interface IClientService
    {
        void Add(ClientDetailsDto clientData);
    }
}