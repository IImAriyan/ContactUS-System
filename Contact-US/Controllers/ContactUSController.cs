using Contact_US.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

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
        
        //Add Messages
        [HttpPost("ContactUS/Add")]
        public async Task<ActionResult<contactUsEntity>> addMessage(contactUsEntity dto)
        {
            EntityEntry<contactUsEntity> Message = dbContext.ContactUS.Add(dto);

            await dbContext.SaveChangesAsync();

            Response.StatusCode = 200;
            var messageResponse = new
            {
                Sataus = 200,
                Message = "Message Successfully Send"
            };
            return Ok(messageResponse);
        }


        [HttpGet("ContactUS/Remove/{id}")]
        public async Task<ActionResult<contactUsEntity>> removeMessage(int id)
        {
            contactUsEntity message = await dbContext.ContactUS.FirstOrDefaultAsync(x =>  x.Id == id);
            if (message == null) return NotFound();

            dbContext.ContactUS.Remove(message);
            dbContext.SaveChangesAsync();

            return Ok(message);
        }
    }
}
