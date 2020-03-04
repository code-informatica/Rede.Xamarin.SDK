using System;

namespace Rede.Xamarin.SDK.Service.Error
{
    public class RedeException : Exception
    {
        public RedeError error { get; set; }
    }
}