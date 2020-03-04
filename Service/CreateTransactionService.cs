using Rede.Xamarin.SDK.Model;

namespace Rede.Xamarin.SDK.Service
{
    internal class CreateTransactionService : AbstractTransactionService
    {
        public CreateTransactionService(Store store, Transaction transaction) : base(store, transaction)
        {
        }
    }
}