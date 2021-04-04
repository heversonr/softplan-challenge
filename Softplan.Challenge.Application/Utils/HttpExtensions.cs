using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Softplan.Challenge.Application.Utils
{
    public static class HttpExtensions
    {
        public static async Task<T> ReceiveJson<T>(this HttpResponseMessage httpResponseMessage)
            => (await httpResponseMessage.Content.ReadAsStringAsync()).ToObject<T>();

        private static T ToObject<T>(this string json) => JsonConvert.DeserializeObject<T>(json);
    }
}
