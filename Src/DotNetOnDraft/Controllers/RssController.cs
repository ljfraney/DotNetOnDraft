using DotNetOnDraft.Utilities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DotNetOnDraft.Controllers
{
    public class RssController : Controller
    {
        private readonly RssClient _rssClient;

        public RssController(RssClient rssClient)
        {
            _rssClient = rssClient;
        }

        [Route("Rss")]
        [Route("Rss/Index")]
        public async Task<IActionResult> Index()
        {
            var rssFeed = await _rssClient.GetRssFeed();
            return Ok(rssFeed);
        }
    }
}