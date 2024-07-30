using Contact_US.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contact_US.Controllers
{
    [Route("api")]
    [ApiController]
    public class ContactUSController(AppDbContext dbContext) : ControllerBase
    {
        // Get Messages 
        [HttpGet("ContactUS/Messages")]
        public IEnumerable<contactUsEntity> getMessages()
        {
            return dbContext.ContactUS;
        }
        
    }
}
