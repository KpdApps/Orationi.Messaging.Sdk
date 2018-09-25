using System;

namespace KpdApps.Orationi.Messaging.Sdk.Core.Models
{
    public class RabbitRequest
    {
        public int RequestCode { get; set; }

        public Guid MessageId { get; set; }
    }
}
