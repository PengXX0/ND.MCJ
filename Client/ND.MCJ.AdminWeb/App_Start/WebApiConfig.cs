﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;

namespace ND.MCJ.AdminWeb
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //optional: 设置只返回json
            config.Services.Replace(typeof(IContentNegotiator), new JsonContentNegotiator());

            // 取消注释下面的代码行可对具有 IQueryable 或 IQueryable<T> 返回类型的操作启用查询支持。
            // 若要避免处理意外查询或恶意查询，请使用 QueryableAttribute 上的验证设置来验证传入查询。
            // 有关详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=279712。
            //config.EnableQuerySupport();

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
}