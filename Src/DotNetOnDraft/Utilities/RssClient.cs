using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DotNetOnDraft.Utilities
{
    public class RssClient
    {
        private readonly HttpClient _httpClient;

        public RssClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<rss> GetRssFeed()
        {
            using (var response = await _httpClient.GetAsync(_httpClient.BaseAddress))
            {
                var serializer = new XmlSerializer(typeof(rss));
                var result = (rss)serializer.Deserialize(await response.Content.ReadAsStreamAsync());
                return result;
            }
        }
    }
}
