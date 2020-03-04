using RestSharp;

namespace Rede.Xamarin.SDK.Service
{
    internal class CaptureTransactionService : AbstractTransactionService
    {
        public CaptureTransactionService(Store store, Transaction transaction) : base(store, transaction)
        {
        }

        public TransactionResponse Execute()
        {
            return base.Execute(Method.PUT);
        }
    }
}