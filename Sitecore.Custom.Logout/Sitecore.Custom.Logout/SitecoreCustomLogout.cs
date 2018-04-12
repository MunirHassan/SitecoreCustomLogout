using Sitecore.Text;
using Sitecore.Web.UI.Sheer;

namespace Sitecore.Pipelines.Logout
{
    /// <summary>Redirects the browser to the custom Logout page.</summary>
    public class SitecoreCustomLogout
    {
        /// <summary>Runs the processor.</summary>
        /// <param name="args">The arguments.</param>
        public void Process(LogoutArgs args)
        {
            var redirectUrl = "http://www.google.com";
            args.RedirectUrl = new UrlString(redirectUrl);
            SheerResponse.Eval("window.top.location.href='" + redirectUrl + "'");
        }
    }
}
