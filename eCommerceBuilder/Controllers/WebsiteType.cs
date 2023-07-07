using eCommerceBuilder.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceBuilder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebsiteType : ControllerBase
    {
        private readonly eCommerceBuilderContext _context;

        public WebsiteType(eCommerceBuilderContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async task<actionresult<ienumerable<websitetype>>> getl()
        {
            if (_context.websitetype == null)
            {
                return badrequest();
            }
            return await _context.websitetype.tolistasync();
        }
    }
}
