﻿using KpdApps.Orationi.Messaging.Common.Models;
using System;
using System.ServiceModel;
using System.Threading.Tasks;

namespace KpdApps.Orationi.Messaging.Sdk.Endpoints
{
    [ServiceContract]
    public interface IMessagingService
    {
        [OperationContract]
        string GetVersion();

        [OperationContract]
        Response GetResponse(Guid requestId);

        [OperationContract]
        ResponseStatus GetStatus(Guid requestId);

        [OperationContract]
        Response ExecuteRequest(Request request);

        [OperationContract]
        ResponseId ExecuteRequestAsync(Request request);

        [OperationContract]
        ResponseId SendRequest(Request request);

        [OperationContract]
        ResponseXsd GetXsd(int requestCode);

        [OperationContract]
        Task<Response> FileUpload();
    }
}