using ND.MCJ.AOP.Security.WebApiFilter;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Xml;

namespace NC.MCJ.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
                    

            //optional: 设置只返回json
            //config.Services.Replace(typeof(IContentNegotiator), new JsonContentNegotiator());

            //重写xml的Formatter
            config.Formatters.Insert(0, new XmlNetTypeFormatter());
            //config.Formatters.Insert(1, new JsonNetFormatter());

            //config.Filters.Add(new ExceptionAttribute());


            // 取消注释下面的代码行可对具有 IQueryable 或 IQueryable<T> 返回类型的操作启用查询支持。
            // 若要避免处理意外查询或恶意查询，请使用 QueryableAttribute 上的验证设置来验证传入查询。
            // 有关详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=279712。
            //config.EnableQuerySupport();

            // 若要在应用程序中禁用跟踪，请注释掉或删除以下代码行
            // 有关详细信息，请参阅: http://www.asp.net/web-api
            config.EnableSystemDiagnosticsTracing();
        }
    }

    /// <summary>
    /// 设置返回格式只能为json
    /// </summary>
    public class JsonContentNegotiator : IContentNegotiator
    {
        private static readonly JsonMediaTypeFormatter JsonFormatter = new JsonMediaTypeFormatter();
        public ContentNegotiationResult Negotiate(Type type, HttpRequestMessage request, IEnumerable<MediaTypeFormatter> formatters)
        {
            var result = new ContentNegotiationResult(JsonFormatter, new MediaTypeHeaderValue("application/json"));
            return result;
        }
    }

    public class JsonNetFormatter : JsonMediaTypeFormatter
    {
        //public JsonNetFormatter()
        //{
        //    SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/json"));
        //    SupportedEncodings.Add(new UTF8Encoding(true, true));
        //}

        public override bool CanReadType(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }
            return true;
        }

        public override bool CanWriteType(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }
            return true;
        }

        public override Task<object> ReadFromStreamAsync(Type type, Stream readStream, HttpContent content, IFormatterLogger formatterLogger)
        {
            var task = Task<object>.Factory.StartNew(() =>
            {
                var val = new JsonSerializer().Deserialize(new JsonTextReader(new StreamReader(readStream)), type);
                return val;
            });

            return task;
        }

        public override Task WriteToStreamAsync(Type type, object value, Stream writeStream, HttpContent content, TransportContext transportContext)
        {
            var task = Task.Factory.StartNew(() =>
            {
                var buf = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(value));
                writeStream.Write(buf, 0, buf.Length);
                writeStream.Flush();
            });

            return task;
        }
    }

    public class XmlNetTypeFormatter : XmlMediaTypeFormatter
    {
        public override bool CanReadType(Type type)
        {
            if (type == null)
            { throw new ArgumentNullException("type"); }
            return true;
        }

        public override bool CanWriteType(Type type)
        {
            if (type == null)
            { throw new ArgumentNullException("type"); }
            return true;
        }

        public override Task<object> ReadFromStreamAsync(Type type, Stream readStream, HttpContent content, IFormatterLogger formatterLogger)
        {
            var task = Task<object>.Factory.StartNew(() =>
            {
                var val = new JsonSerializer().Deserialize<XmlNode>(new JsonTextReader(new StreamReader(readStream)));
                return val;
            });
            return task;
        }

        public override Task WriteToStreamAsync(Type type, object value, Stream writeStream, HttpContent content, TransportContext transportContext)
        {
            var task = Task.Factory.StartNew(() =>
            {
                var xml = JsonConvert.DeserializeXmlNode(JsonConvert.SerializeObject(value), value.GetType().Name);
                var buf = Encoding.UTF8.GetBytes(xml.InnerXml);
                writeStream.Write(buf, 0, buf.Length);
                writeStream.Flush();
            });
            return task;
        }
    }


}
