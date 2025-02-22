
namespace System.Web
{
    public interface IHttpHandler
    {
        void ProcessRequest(HttpContext context);
        bool IsReusable { get; }
    }

    public class HttpContext
    {
        public HttpRequest Request { get; set; }
    }

    public class HttpRequest
    {
        public System.Collections.Specialized.NameValueCollection QueryString { get; set; }
    }
}