using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WorldExplorerEurope.API.Domain.Services
{
    public class WikipediaService
    {

        public class Rootobject
        {
            public string type { get; set; }
            public string title { get; set; }
            public string displaytitle { get; set; }
            public Namespace _namespace { get; set; }
            public string wikibase_item { get; set; }
            public Titles titles { get; set; }
            public int pageid { get; set; }
            public Thumbnail thumbnail { get; set; }
            public Originalimage originalimage { get; set; }
            public string lang { get; set; }
            public string dir { get; set; }
            public string revision { get; set; }
            public string tid { get; set; }
            public DateTime timestamp { get; set; }
            public string description { get; set; }
            public string description_source { get; set; }
            public Content_Urls content_urls { get; set; }
            public Api_Urls api_urls { get; set; }
            public string extract { get; set; }
            public string extract_html { get; set; }
        }

        public class Namespace
        {
            public int id { get; set; }
            public string text { get; set; }
        }

        public class Titles
        {
            public string canonical { get; set; }
            public string normalized { get; set; }
            public string display { get; set; }
        }

        public class Thumbnail
        {
            public string source { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }

        public class Originalimage
        {
            public string source { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }

        public class Content_Urls
        {
            public Desktop desktop { get; set; }
            public Mobile mobile { get; set; }
        }

        public class Desktop
        {
            public string page { get; set; }
            public string revisions { get; set; }
            public string edit { get; set; }
            public string talk { get; set; }
        }

        public class Mobile
        {
            public string page { get; set; }
            public string revisions { get; set; }
            public string edit { get; set; }
            public string talk { get; set; }
        }

        public class Api_Urls
        {
            public string summary { get; set; }
            public string metadata { get; set; }
            public string references { get; set; }
            public string media { get; set; }
            public string edit_html { get; set; }
            public string talk_page_html { get; set; }
        }

        public async Task<List<Rootobject>> GetDescription(List<RestcountriesService.RootObject>countries)
        {
            List<Rootobject> descriptions = new List<Rootobject>();
            foreach(var country in countries)
            {
                string ApiUrl = $"https://en.wikipedia.org/api/rest_v1/page/summary/{country.name}";
                var client = new HttpClient();
                HttpResponseMessage response =  await client.GetAsync(ApiUrl);
                var content = await response.Content.ReadAsStringAsync();
                Rootobject rootobject = JsonConvert.DeserializeObject<Rootobject>(content);
                descriptions.Add(rootobject);
            }
            return descriptions;
        }
    }
}
