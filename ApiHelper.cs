using System.Collections.Generic;
using System.IO;
using System.Net;
using CountiesDB.Model;
using Newtonsoft.Json;

namespace CountiesDB.Repositories
{
    public class ApiHelper
    {
        private string mainApiUrl = "";

        private List<Country> countries = new List<Country>();

        public List<Country> GetAllCountries()
        {
            string response = GetResponse(mainApiUrl);
            countries = JsonConvert.DeserializeObject<List<Country>>(response);
            return countries;
        }

        public List<Country> GetOneCountry(string name)
        {
            string response = GetResponse(GetOneCountryUrl(name));
            countries = JsonConvert.DeserializeObject<List<Country>>(response);
            return countries;
        }

        private string GetOneCountryUrl(string name)
        {
            return mainApiUrl + "/name/" + name;
        }

        private string GetResponse(string url)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }
            return response;
        }
    }
}
