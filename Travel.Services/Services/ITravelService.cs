using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelServices.Logic.Models;

namespace TravelServices.Logic.Models
{
    public interface ITravelService
    {
        Task<bool> GetSession();
        Task<LocationOutput> GetLocation();
        Task<JourneyOutput> GetJourney(TravelInput travel);
    }
}
