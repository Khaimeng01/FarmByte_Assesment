using Microsoft.AspNetCore.Mvc;
using Project_1.Model;

namespace Project_1.Controllers
{
    [Route("accountInfo")]
    [ApiController]
    public class accountInfoController : Controller
    {
        [HttpGet]
        public IEnumerable<accountInfo> GetInfo()
        {
            return new List<accountInfo>
            {
                new accountInfo{Id =1,Name ="Dylan" , Number ="0125031601"},
            };
        }
    }
}
