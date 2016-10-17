using Newtonsoft.Json;

namespace ND.MCJ.Framework.Converter
{
    public static class ConvertJson
    {
        public static string ToJson<T>(this T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static T FromJson<T>(this string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
