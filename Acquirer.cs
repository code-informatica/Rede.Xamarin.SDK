using Newtonsoft.Json;
using Rede.Acquiring.SDK.Rest.Common;
using Rede.Acquiring.SDK.Rest.Model;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Rede.Acquiring.SDK.Rest
{
    /// <summary>
    /// Acquirer class.
    /// </summary>
    public class Acquirer
    {
        private readonly Security security;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="affiliation">Affiliation.</param>
        /// <param name="password">Password.</param>
        /// <param name="environment">Environment.</param>
        public Acquirer(string affiliation, string password, EnvironmentType environment)
            : this(new Security(affiliation, password, environment))
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="security">Security.</param>
        public Acquirer(Security security)
        {
            this.security = security;
        }

        /// <summary>
        /// Post Transaction method that executes Authorization operations.
        /// </summary>
        /// <param name="transactionRequest">Transaction request data</param>
        /// <returns>TransactionResponse.</returns>
        public async Task<TransactionResponse> AuthorizeAsync(TransactionRequest transactionRequest)
        {
            return await Wrapper.ExcecuteAsync(async () =>
            {
                HttpResponseMessage response = await Request.PostAsync("transactions", transactionRequest, security);
                return JsonConvert.DeserializeObject<TransactionResponse>(await response.Content.ReadAsStringAsync());
            });
        }

        /// <summary>
        /// Post Transaction method that executes Authorization operations.
        /// </summary>
        /// <param name="transactionRequest">Transaction request data</param>
        /// <returns>TransactionResponse.</returns>
        public TransactionResponse Authorize(TransactionRequest transactionRequest)
        {
            return Wrapper.Excecute(() =>
            {
                HttpResponseMessage response = Request.PostAsync("transactions", transactionRequest, security).Result;
                return JsonConvert.DeserializeObject<TransactionResponse>(response.Content.ReadAsStringAsync().Result);
            });
        }

        /// <summary>
        /// Post Refuns method that executes Refunds operations.
        /// </summary>
        /// <param name="tid">Tid</param>
        /// <param name="refundRequest">RefundRequest</param>
        /// <returns>RefundResponse</returns>
        public async Task<RefundResponse> RefundAsync(string tid, RefundRequest refundRequest)
        {
            return await Wrapper.ExcecuteAsync(async () =>
            {
                string path = String.Format("transactions/{0}/refunds", tid);
                HttpResponseMessage response = await Request.PostAsync(path, refundRequest, security);
                return JsonConvert.DeserializeObject<RefundResponse>(await response.Content.ReadAsStringAsync());
            });
        }

        /// <summary>
        /// Post Refuns method that executes Refunds operations.
        /// </summary>
        /// <param name="tid">Tid</param>
        /// <param name="refundRequest">RefundRequest</param>
        /// <returns>RefundResponse</returns>
        public RefundResponse Refund(string tid, RefundRequest refundRequest)
        {
            return Wrapper.Excecute(() =>
            {
                string path = String.Format("transactions/{0}/refunds", tid);
                HttpResponseMessage response = Request.PostAsync(path, refundRequest, security).Result;
                return JsonConvert.DeserializeObject<RefundResponse>(response.Content.ReadAsStringAsync().Result);
            });
        }

        /// <summary>
        /// Put Transaction method that executes Capture operations.
        /// </summary>
        /// <param name="tid">Tid.</param>
        /// <param name="transactionRequest">Transaction request</param>
        /// <returns>Transaction response.</returns>
        public async Task<TransactionResponse> CaptureAsync(string tid, TransactionRequest transactionRequest)
        {
            return await Wrapper.ExcecuteAsync(async () =>
            {
                string path = String.Format("transactions/{0}", tid);
                HttpResponseMessage response = await Request.PutAsync(path, transactionRequest, security);
                return JsonConvert.DeserializeObject<TransactionResponse>(await response.Content.ReadAsStringAsync());
            });
        }

        /// <summary>
        /// Put Transaction method that executes Capture operations.
        /// </summary>
        /// <param name="tid">Tid.</param>
        /// <param name="transactionRequest">Transaction request</param>
        /// <returns>Transaction response.</returns>
        public TransactionResponse Capture(string tid, TransactionRequest transactionRequest)
        {
            return Wrapper.Excecute(() =>
            {
                string path = String.Format("transactions/{0}", tid);
                HttpResponseMessage response = Request.PutAsync(path, transactionRequest, security).Result;
                return JsonConvert.DeserializeObject<TransactionResponse>(response.Content.ReadAsStringAsync().Result);
            });
        }
    }
}
