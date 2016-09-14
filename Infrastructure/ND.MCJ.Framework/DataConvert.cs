using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml;
using Newtonsoft.Json;
using System.Web.Mvc;
using System.Collections.Specialized;

namespace ND.MCJ.Framework
{
    public static class DataConvert
    {
        public static string ToJson<T>(this T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static T ToDataFromJson<T>(this string obj)
        {
            return JsonConvert.DeserializeObject<T>(obj);
        }

        public static String ToQueryString(this Object obj)
        {
            var list = from p in obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
                       let mi = p.GetGetMethod()
                       where mi != null && mi.IsPublic
                       let value = mi.Invoke(obj, null) ?? ""
                       select p.Name + "=" + value;
            return String.Join("&", list);
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

        public static string ToQueryString(this IDictionary<String, String> dic)
        {
            return dic.Aggregate("", (current, i) => current + (i.Key + "=" + i.Value + "&")).TrimEnd('&');
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
        public static IDictionary<string, object> XmlToDictionary(this XmlDocument doc)
        {
            var json = JsonConvert.SerializeXmlNode(doc);
            return JsonConvert.DeserializeObject<IDictionary<string, object>>(json);
        }

        /// <param name="nvc"></param>
        /// <param name="handleMultipleValuesPerKey">处理重复Key的方式</param>
        /// <returns></returns>
        public static IDictionary<String, String> ToDictionary(this NameValueCollection nvc, bool handleMultipleValuesPerKey)
        {
            var result = new Dictionary<String, String>();
            foreach (string key in nvc.Keys)
            {
                if (handleMultipleValuesPerKey)
                {
                    string[] values = nvc.GetValues(key);
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
        public static IDictionary<string, object> ToDictionary(this string json)
        {
            return JsonConvert.DeserializeObject<IDictionary<string, object>>(json);
        }

        /// <summary>
        /// QueryString转Dictionary
        /// </summary>
        /// <param name="queryString"></param>
        /// <returns></returns>
        public static IDictionary<String, Object> QuertStringToDictionary(string queryString)
        {
            return queryString.Split('&').Select(item => item.Split('=')).ToDictionary<string[], string, object>(args => args[0], args => args[1]);
        }
        #endregion
    }
}
