using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using System.Xml;
using Newtonsoft.Json;

namespace ND.MCJ.Framework.Converter
{
    public static class DataConvert
    {
        public static String ToQueryString(this Object obj)
        {
            var list = from p in obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
                       let mi = p.GetGetMethod()
                       where mi != null && mi.IsPublic
                       let value = mi.Invoke(obj, null) ?? ""
                       select p.Name + "=" + value;
            return String.Join("&", list);
        }

        public static String ToQueryString(this IDictionary<String, String> dic)
        {
            return dic.Aggregate("", (current, i) => current + (i.Key + "=" + i.Value + "&")).TrimEnd('&');
        }

        /// <summary>
        /// 返回Model的第一条错误信息
        /// </summary>
        /// <param name="modelState"></param>
        /// <returns></returns>
        public static String FirstError(this ModelStateDictionary modelState)
        {
            return modelState.First(m => m.Value.Errors.Any()).Value.Errors.First(s => s.ErrorMessage.Any()).ErrorMessage;
        }

        public static List<SelectListItem> ToListItem<T>()
        {
            return (from int s in Enum.GetValues(typeof(T)) select new SelectListItem { Value = s.ToString(), Text = Enum.GetName(typeof(T), s) }).ToList();
        }

        #region 转Dictionary
        /// <summary>
        /// Xml转Dictionary
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        public static IDictionary<String, Object> XmlToDictionary(this XmlDocument doc)
        {
            var json = JsonConvert.SerializeXmlNode(doc);
            return JsonConvert.DeserializeObject<IDictionary<String, Object>>(json);
        }

        /// <param name="nvc"></param>
        /// <param name="handleMultipleValuesPerKey">处理重复Key的方式</param>
        /// <returns></returns>
        public static IDictionary<String, String> ToDictionary(this NameValueCollection nvc, bool handleMultipleValuesPerKey)
        {
            var result = new Dictionary<String, String>();
            foreach (String key in nvc.Keys)
            {
                if (handleMultipleValuesPerKey)
                {
                    String[] values = nvc.GetValues(key);
                    if (values != null && values.Length == 1)
                    {
                        result.Add(key, values[0]);
                    }
                    else
                    {
                        result.Add(key, values.ToString());
                    }
                }
                else
                {
                    result.Add(key, nvc[key]);
                }
            }
            return result;
        }

        /// <summary>
        /// Json转Dictionary
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static IDictionary<String, Object> ToDictionary(this String json)
        {
            return JsonConvert.DeserializeObject<IDictionary<String, Object>>(json);
        }

        /// <summary>
        /// QueryString转Dictionary
        /// </summary>
        /// <param name="queryString"></param>
        /// <returns></returns>
        public static IDictionary<String, Object> QuertStringToDictionary(String queryString)
        {
            return queryString.Split('&').Select(item => item.Split('=')).ToDictionary<String[], String, Object>(args => args[0], args => args[1]);
        }
        #endregion
    }
}
