using System.IO;
using System.ServiceModel.Web;
using System.Text;

namespace WcfRawDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public Stream GetData(Stream request)
        {
            var json = new StreamReader(request, Encoding.UTF8).ReadToEnd();

            //TODO: do serious stuff

            WebOperationContext.Current.OutgoingResponse.ContentType = "application/json; charset=utf-8";
            return new MemoryStream(Encoding.UTF8.GetBytes(json));
        }
    }
}