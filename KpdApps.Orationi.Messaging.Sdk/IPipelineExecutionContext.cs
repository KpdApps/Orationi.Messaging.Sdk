using System;
using System.Collections;
using KpdApps.Orationi.Messaging.Sdk.Cache;
using KpdApps.Orationi.Messaging.Sdk.Core.Models;

namespace KpdApps.Orationi.Messaging.Sdk
{
    public interface IPipelineExecutionContext
    {
        string RequestBody { get; set; }

        string ResponseBody { get; set; }

        string ResponseUser { get; set; }

        string ResponseSystem { get; set; }

        Nullable<int> StatusCode { get; set; }

        IDictionary PipelineValues { get; }

        IDictionary PluginStepSettings { get; set; }

        Guid MessageId { get; }

        int RequestCode { get; }

        string MessageBody { get; }

        IDictionary GlobalSettings { get; }

        byte[] GetFile(Guid messageId, out string filename);

        ICacheProvider CacheProvider { get; }

        CallbackSettings TryGetCallbackSettings(Guid messageId, out int? requestCode);
    }
}