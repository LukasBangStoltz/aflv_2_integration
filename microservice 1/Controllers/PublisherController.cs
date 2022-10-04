using microservice_1.ComplaintService;
using microservice_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace microservice_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PublisherController : ControllerBase
    {
        private readonly IPublisher _publisher;

        public PublisherController(IPublisher publisher)
        {
            _publisher = publisher;
        }

        [HttpPost]
        public bool publishComplaint(Complaint complaint)
        {
            var complaintSent = _publisher.Publish(complaint);

            return complaintSent;
        }
    }
}