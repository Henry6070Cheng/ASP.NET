using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI
{
    public partial class LoginOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Session.Clear();
                TimeSpan ts = new TimeSpan(-1, 0, 0, 0);
                HttpCookie cookieAdminName = Request.Cookies["AdminName"];
                HttpCookie cookieAdminPwd = Request.Cookies["AdminPwd"];
                cookieAdminName.Expires = DateTime.Now.Add(ts);
                cookieAdminPwd.Expires = DateTime.Now.Add(ts);
                Response.AppendCookie(cookieAdminName);
                Response.AppendCookie(cookieAdminPwd);
                FormsAuthentication.SignOut();
            }
            catch { }

            Response.Buffer = true;
            Response.ExpiresAbsolute = System.DateTime.Now.AddSeconds(-1);
            Response.Expires = 0;
            Response.CacheControl = "no-cache";
            Response.AddHeader("Pragma", "No-Cache");
            Response.Redirect("Login.aspx");

        }
    }
}