using Rede.Acquiring.SDK.Rest.Model;
using System;
using System.Threading.Tasks;

namespace Rede.Acquiring.SDK.Rest
{
    internal static class Wrapper
    {
        public static T Excecute<T>(Func<T> method) where T : ResponseBase, new()
        {
            T response = default(T);

            try
            {
                response = method();
            }
            catch (AggregateException ex)
            {
                response = new T();
                response.ReturnCode = ReturnCode.UNSUCCESSFUL;
                response.ReturnMessage = ex.InnerExceptions.Count > 0 ? ex.InnerExceptions[0].Message : null;
            }
            catch (Exception ex)
            {
                response = new T();
                response.ReturnCode = ReturnCode.UNSUCCESSFUL;
                response.ReturnMessage = ex.Message;
            }

            return response;
        }

        public static async Task<T> ExcecuteAsync<T>(Func<Task<T>> method) where T : ResponseBase, new()
        {
            T response = default(T);

            try
            {
                response = await method();
            }
            catch (AggregateException ex)
            {
                response = new T();
                response.ReturnCode = ReturnCode.UNSUCCESSFUL;
                response.ReturnMessage = ex.InnerExceptions.Count > 0 ? ex.InnerExceptions[0].Message : null;
            }
            catch (Exception ex)
            {
                response = new T();
                response.ReturnCode = ReturnCode.UNSUCCESSFUL;
                response.ReturnMessage = ex.Message;
            }

            return response;
        }
    }
}
