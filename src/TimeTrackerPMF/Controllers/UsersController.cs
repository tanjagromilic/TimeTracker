using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;
using TimeTrackerPMF.Data;
using TimeTrackerPMF.Models;

namespace TimeTrackerPMF.Controllers
{
    [ApiController]
    [Route(template:"/api/users")]
    public class UsersController : Controller
    {
        private readonly TimeTrackerDbContext _dbContext;
        private readonly ILogger<UsersController> _logger;
        public UsersController(TimeTrackerDbContext dbContext, ILogger<UsersController> logger)
        {
            _dbContext = dbContext;
            _logger=logger;
        }

        [HttpGet(template:"{id}")]
        public async Task<ActionResult<UserModel>> GetById(long id)
        {
            _logger.LogInformation(message: $"Getting user by id: {id}");
            var user =await _dbContext.Users.FindAsync(id);
            if (user == null)
            {
                _logger.LogWarning(message: $"User with id: {id} not found");
                return NotFound();
            }

            return UserModel.FromUser(user);
            
        }

        [HttpGet]
        public async Task<ActionResult<PagedList<UserModel>>> GetPage(int page = 1, int size = 5)
        {
            _logger.LogInformation(message: $"Getting a page {page} of users with page size {size}");

            var users = await _dbContext.Users.Skip((page - 1) * size).Take(size).ToListAsync();

            var totalUsers = await _dbContext.Users.CountAsync();

            return new PagedList<UserModel>
            {
                Items = users.Select(UserModel.FromUser),
                Page = page,
                PageSize = size,
                TotalCount = totalUsers
            };
        }

    }
}