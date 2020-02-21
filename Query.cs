using Newtonsoft.Json;
using Rede.Acquiring.SDK.Rest.Common;
using Rede.Acquiring.SDK.Rest.Model;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Rede.Acquiring.SDK.Rest
{
    public class Query
    {
        private readonly Security security;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="affiliation">affiliation.</param>
        /// <param name="password">password.</param>
        /// <param name="environment">environment.</param>
        public Query(string affiliation, string password, EnvironmentType environment)
            : this(new Security(affiliation, password, environment))
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="security">Security.</param>
        public Query(Security security)
        {
            this.security = security;
        }

        /// <summary>
        /// Get Transaction method that executes Transactions Querys by tid.
        /// </summary>
        /// <param name="tid"><Tid/param>
        /// <returns>Query transaction response</returns>
        public async Task<QueryTransactionResponse> GetTransactionByTidAsync(string tid)
        {
            return await GetTransactionAsync(tid, null);
        }

        /// <summary>
        /// Get Transaction method that executes Transactions Querys by reference.
        /// </summary>
        /// <param name="reference">Reference.</param>
        /// <returns>Query transaction response.</returns>
        public async Task<QueryTransactionResponse> GetTransactionByReferenceAsync(string reference)
        {
            return await GetTransactionAsync(null, reference);
        }

        /// <summary>
        /// Get Transaction method that executes Transactions Querys.
        /// </summary>
        /// <param name="reference">Reference.</param>
        /// <returns>Query transaction response.</returns>
        public async Task<QueryTransactionResponse> GetTransactionAsync(string tid, string reference)
        {
            return await Wrapper.ExcecuteAsync(async () =>
            {
                string path = GetQueryTransactionPath(tid, reference);
                HttpResponseMessage response = await Request.GetAsync(path, security);
                return JsonConvert.DeserializeObject<QueryTransactionResponse>(await response.Content.ReadAsStringAsync());
            });
        }

        /// <summary>
        /// Get Transaction method that executes Transactions Querys by tid.
        /// </summary>
        /// <param name="tid"><Tid/param>
        /// <returns>Query transaction response</returns>
        public QueryTransactionResponse GetTransactionByTid(string tid)
        {
            return GetTransaction(tid, null);
        }

        /// <summary>
        /// Get Transaction method that executes Transactions Querys by reference.
        /// </summary>
        /// <param name="reference">Reference.</param>
        /// <returns>Query transaction response.</returns>
        public QueryTransactionResponse GetTransactionByReference(string reference)
        {
            return GetTransaction(null, reference);
        }

        /// <summary>
        /// Get Transaction method that executes Transactions Querys.
        /// </summary>
        /// <param name="reference">Reference.</param>
        /// <returns>Query transaction response.</returns>
        public QueryTransactionResponse GetTransaction(string tid, string reference)
        {
            return Wrapper.Excecute(() =>
            {
                string path = GetQueryTransactionPath(tid, reference);
                HttpResponseMessage response = Request.GetAsync(path, security).Result;
                return JsonConvert.DeserializeObject<QueryTransactionResponse>(response.Content.ReadAsStringAsync().Result);
            });
        }

        /// <summary>
        /// Get Transaction method that executes Transactions Querys operations.
        /// </summary>
        /// <param name="tid">Tid.</param>
        /// <param name="refundId">Refund id.</param>
        /// <returns>Refund response.</returns>
        public async Task<RefundResponse> GetRefundAsync(string tid, string refundId)
        {
            return await Wrapper.ExcecuteAsync(async () =>
            {
                string path = String.Format("transactions/{0}/refunds/{1}", tid, refundId);
                HttpResponseMessage response = await Request.GetAsync(path, security);
                return JsonConvert.DeserializeObject<RefundResponse>(await response.Content.ReadAsStringAsync());
            });
        }

        /// <summary>
        /// Get Transaction method that executes Transactions Querys operations.
        /// </summary>
        /// <param name="tid">Tid.</param>
        /// <param name="refundId">Refund id.</param>
        /// <returns>Refund response.</returns>
        public RefundResponse GetRefund(string tid, string refundId)
        {
            return Wrapper.Excecute(() =>
            {
                string path = String.Format("transactions/{0}/refunds/{1}", tid, refundId);
                HttpResponseMessage response = Request.GetAsync(path, security).Result;
                return JsonConvert.DeserializeObject<RefundResponse>(response.Content.ReadAsStringAsync().Result);
            });
        }

        /// <summary>
        /// Get transaction refunds list.
        /// </summary>
        /// <param name="tid">Tid.</param>
        /// <returns>Refund list response.</returns>
        public async Task<RefundListResponse> GetRefundsAsync(string tid)
        {
            return await Wrapper.ExcecuteAsync(async () =>
            {
                string path = String.Format("transactions/{0}/refunds", tid);
                HttpResponseMessage response = await Request.GetAsync(path, security);
                return JsonConvert.DeserializeObject<RefundListResponse>(await response.Content.ReadAsStringAsync());
            });
        }

        /// <summary>
        /// Get transaction refunds list.
        /// </summary>
        /// <param name="tid">Tid.</param>
        /// <returns>Refund list response.</returns>
        public RefundListResponse GetRefunds(string tid)
        {
            return Wrapper.Excecute(() =>
            {
                string path = String.Format("transactions/{0}/refunds", tid);
                HttpResponseMessage response = Request.GetAsync(path, security).Result;
                return JsonConvert.DeserializeObject<RefundListResponse>(response.Content.ReadAsStringAsync().Result);
            });
        }
		
		/// <summary>
        /// Get query transaction url.
        /// </summary>
        /// <param name="tid">Tid.</param>
        /// <param name="reference">Reference.</param>
        /// <returns>Path.</returns>
        private string GetQueryTransactionPath(string tid, string reference)
        {
            string path = "transactions";
            if (!String.IsNullOrWhiteSpace(tid))
                path += "/" + tid;
            if (!String.IsNullOrWhiteSpace(reference))
                path += "?reference=" + reference;
            return path;
        }
    }
}
