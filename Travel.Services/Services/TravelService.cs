using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TravelServices.Logic.Models;

namespace TravelServices.Logic.Models
{
    public class TravelService : ITravelService
    {
        private const string _APIURL = "https://v2-api.obilet.com/api/";
        private const string _Authorization = "Basic JEcYcEMyantZV095WVc3G2JtVjNZbWx1";
        private string _sessionId, _deviceId;
        protected async Task<Object> HttpCaller<T>(Object input, string url, string method)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpRequestMessage request = new HttpRequestMessage(new HttpMethod(method), _APIURL + url);

                    if (input != null)
                    {
                        JObject inputJson = JObject.Parse(JsonConvert.SerializeObject(input));
                        StringContent stringContent = new StringContent(inputJson.ToString());
                        stringContent = new StringContent(inputJson.ToString());
                        stringContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                        request.Content = stringContent;
                        client.DefaultRequestHeaders.Add("Authorization", _Authorization);
                    }

                    HttpResponseMessage response = await client.SendAsync(request);
                    if (response.IsSuccessStatusCode)
                    {
                        string value = await response.Content.ReadAsStringAsync();
                        if (string.IsNullOrWhiteSpace(value))
                            return true;
                        return JsonConvert.DeserializeObject<T>(value);
                    }
                   
                }
                catch (Exception e)
                {
                }
            }
            return null;
        }

        public async Task<bool> GetSession()
        {
            if (_sessionId == null && _deviceId == null)
            {
                SessionInputs sessionInputs = new SessionInputs()
                {
                    Type = 7,
                    Connection = new Connection()
                    {
                        IpAddress = "145.214.41.12",
                        Port = "80"
                    },
                    Application = new Application()
                    {
                        Version = "1.0.0.0",
                        EquipmentId = "distribusion"
                    },
                    Browser = new Browser()
                    {
                        Name = "Chrome",
                        Version = "47.0.0.12"
                    }

                };
                var result = (SessionOutput)await HttpCaller<SessionOutput>(sessionInputs, "client/getsession", "POST");
                _sessionId = result.Data.SessionId;
                _deviceId = result.Data.DeviceId;
            }
            return true;
        }
        public async Task<LocationOutput> GetLocation()
        {
            if (await GetSession())
            {
                LocationInputs locationInputs = new LocationInputs()
                {
                    Data = null,
                    Date = "",
                    Language = "en-EN",
                    DeviceSession = new DeviceSession()
                    {
                        SessionId = _sessionId,
                        DeviceId = _deviceId
                    }
                };
                return (LocationOutput)await HttpCaller<LocationOutput>(locationInputs, "location/getbuslocations", "POST");
            }
            return null;
        }
        public async Task<JourneyOutput> GetJourney(TravelInput travelInput)
        {
            if (await GetSession())
            {
                JourneyInputs journeyInputs = new JourneyInputs()
                {
                    Date = "",
                    Language = "en-EN",
                    DeviceSession = new DeviceSession()
                    {
                        SessionId = _sessionId,
                        DeviceId = _deviceId
                    },
                    Data = new JourneyInputData()
                    {
                        OriginId = travelInput.OriginId,
                        DestinationId = travelInput.DestinationId,
                        DepartureDate = DateTime.Parse(travelInput.DepartureDate).Date.ToString("yyyy-MM-ddTHH:mm:ss")
                    }
                }; 

                return (JourneyOutput)await HttpCaller<JourneyOutput>(journeyInputs, "journey/getbusjourneys", "POST");
            }
            return null;
        }
    }
}
