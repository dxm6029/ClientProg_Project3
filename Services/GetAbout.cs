using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project3_FinalExam.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Project3_FinalExam.Services
{
    public class GetAbout
    {
        public async Task<About> GetAboutInfo()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                About about = new About();

                try
                {
                    HttpResponseMessage response = await client.GetAsync("api/about", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    var rtnResults = JsonConvert.DeserializeObject<About>(data);


                    about = rtnResults;


                    List<About> aboutList = new List<About>();

                    //foreach (KeyValuePair<string, List<About>> kvp in rtnResults)
                    //{
                    //    foreach (var item in kvp.Value)
                    //    {
                    //        aboutList.Add(item);
                    //    }
                    //}



                    return about;
                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    List<About> aboutList = new List<About>();
                    return about;
                    //return "HttpRequestException";
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    List<About> aboutList = new List<About>();
                    return about;
                    //return "Exception"; ;
                }
            }
        }
    }
}
