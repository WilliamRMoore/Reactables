using Microsoft.AspNetCore.Mvc;

namespace Reactivities.API.Controllers.AbsClasses
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseApiController : ControllerBase
    {
        
    }
}