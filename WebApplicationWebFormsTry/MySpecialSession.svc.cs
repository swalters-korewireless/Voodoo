using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationWebFormsTry
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class MySpecialSession : IService3
    {
        
        public Dictionary<string, object> GetSession()
        {
            // grab the current Session...
            var testSession = HttpContext.Current.Session;
            var result = testSession.Keys.Cast<string>().ToDictionary(key => key, key => testSession[key]);

            return result;
        }

        public IEnumerable<AppSettings> GetSessionIEnumerable()
        {
            // grab the current Session...
            var testSession = HttpContext.Current.Session;

            return (from string key in testSession select new AppSettings {Name = key, Value = testSession[key]}).ToList();
        }
    }
}
