using API.Data;
using Microsoft.AspNetCore.Mvc;
using API.Entities;
// using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
[ApiController]
[Route("api/[controller]")] // /api/users
public class UsersContoller : ControllerBase
{

    private readonly DataContext _context;
   public UsersContoller(DataContext context)
   {        
        _context = context; 
   } 
    // create endpoint
    [HttpGet]
    public ActionResult<IEnumerable<AppUser>> GetUsers()
    {
        var users = _context.Users.ToList();
            return users;
    }

    // Another get endpoint 
    [HttpGet("{id}")] // /api/users/2
    public ActionResult<AppUser> GetUser(int id) 
    {
        // var user = _context.Users.Find(id);

        return _context.Users.Find(id);
    }
}
}