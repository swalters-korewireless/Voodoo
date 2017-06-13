using System;
using System.Data;
using System.Web.SessionState;
using System.Web.UI;

namespace WebApplicationWebFormsTry
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["hi"] = "Hello";
            Session["hiDs"] = new DataSet();
            Session["06/08"] = "hello2";

            var testWebApiSession = Session["something"];

            var test = new SessionStateItemCollection();

            var testing = string.Empty;
        }
    }
}