using microservice_2.ComplaintService;
using Microsoft.AspNetCore.Mvc;

namespace microservice_2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubscriberController : ControllerBase
    {
        private readonly Subscriber _subscriber;

        public SubscriberController(Subscriber subscriber)
        {
            _subscriber = subscriber;
        }

        [HttpGet]
        public async void Subscribe()
        {
            _subscriber.Subscribe();
        }
    }
}