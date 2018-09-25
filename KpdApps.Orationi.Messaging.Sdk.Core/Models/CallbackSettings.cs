using System;

namespace KpdApps.Orationi.Messaging.Sdk.Core.Models
{
    public class CallbackSettings
    {
        public Guid Id { get; set; }

        public CallbackMethodType MethodType { get; set; }

        public string RequestTargetUrl { get; set; }

        public string UrlAccessUserName { get; set; }

        public string UrlAccessUserPassword { get; set; }

        public bool NeedAuthentification { get; set; }
    }
}
