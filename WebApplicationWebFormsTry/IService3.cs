using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Providers.Entities;
using System.Web.Services;

namespace WebApplicationWebFormsTry
{
    public class AppSettings
    {
        public string Name { get; set; }
        public object Value { get; set; }
    }
    
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService3
    {
        [OperationContract]
        Dictionary<string, object> GetSession();
        [OperationContract]
        IEnumerable<AppSettings> GetSessionIEnumerable();
    }
}
