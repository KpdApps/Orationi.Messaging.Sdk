using System;
using System.Runtime.Serialization;

namespace KpdApps.Orationi.Messaging.Sdk.Core.Models
{
    [DataContract]
    public class ResponseId : ResponseBase
    {
        [DataMember]
        public Guid Id { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()},\r\n\"Id\" : \"{Id}\"";
        }
    }
}
