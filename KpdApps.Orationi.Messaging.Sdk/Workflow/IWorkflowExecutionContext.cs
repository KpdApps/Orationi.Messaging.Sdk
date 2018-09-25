using System;
using System.Collections;

namespace KpdApps.Orationi.Messaging.Sdk.Workflow
{
    public interface IWorkflowExecutionContext
    {
        Guid MessageId { get; }

        int RequestCode { get; }

        string MessageBody { get; }

        IDictionary GlobalSettings { get; }
    }
}
