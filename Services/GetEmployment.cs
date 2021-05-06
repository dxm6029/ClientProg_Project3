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
    public class GetEmployment
    {
        public async Task<List<Employment>> GetEmploymentTable()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync("api/employment/employmentTable/professionalEmploymentInformation", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<Employment>>>(data);

                    List<Employment> employmentData = new List<Employment>();
                    Employment employ = new Employment();

                    foreach (KeyValuePair<string, List<Employment>> kvp in rtnResults)
                    {
                        foreach (var item in kvp.Value)
                        {
                            employmentData.Add(item);
                        }
                    }

                    return employmentData;
                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    List<Employment> employmentData = new List<Employment>();
                    return employmentData;
                    //return "HttpRequestException";
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    List<Employment> employmentData = new List<Employment>();
                    return employmentData;
                    //return "Exception"; ;
                }
            }
        }


        public async Task<List<Coop>> GetCoopTable()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync("api/employment/coopTable/coopInformation", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<Coop>>>(data);

                    List<Coop> coopData = new List<Coop>();
                    Coop Coop = new Coop();

                    foreach (KeyValuePair<string, List<Coop>> kvp in rtnResults)
                    {
                        foreach (var item in kvp.Value)
                        {
                            coopData.Add(item);
                        }
                    }

                    return coopData;
                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    List<Coop> coopData = new List<Coop>();
                    return coopData;
                    //return "HttpRequestException";
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    List<Coop> coopData = new List<Coop>();
                    return coopData;
                    //return "Exception"; ;
                }
            }
        }
    }
}
