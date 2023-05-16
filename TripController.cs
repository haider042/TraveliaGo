using Microsoft.AspNetCore.Mvc;
using Tavelia_Go.Shared;

namespace Tavelia_Go.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TripController : ControllerBase
    {
       


        [HttpGet("TripsList")]
        public IEnumerable<Trip> GetTrips()
        {
            
            IList<Trip> tripsList = new List<Trip>();

            tripsList.Add(new Trip { Id = 1, Destination = "Bankok",});
            tripsList.Add(new Trip { Id = 2, Destination = "Sydney", });
            tripsList.Add(new Trip { Id = 3, Destination = "Paris", });
            tripsList.Add(new Trip { Id = 4, Destination = "Swithzerland", });

            return tripsList;
        }
    }
}