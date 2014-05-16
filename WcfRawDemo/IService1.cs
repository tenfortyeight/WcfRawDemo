﻿using System.IO;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WcfRawDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebInvoke(Method = "POST")]
        Stream GetData(Stream request);
    }
}