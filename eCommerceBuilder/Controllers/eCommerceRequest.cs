using eCommerceBuilder.Data;
using eCommerceBuilder.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eCommerceBuilder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class eCommerceRequest : ControllerBase
    {
        private readonly eCommerceBuilderContext _context;

        public eCommerceRequest(eCommerceBuilderContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<StoreRequestQue>>> Get() {
            if(_context.StoreRequestQue == null)
            {
                return BadRequest();
            }
            return await _context.StoreRequestQue.ToListAsync();
        }



        [HttpPost]

        public async Task<ActionResult<IEnumerable<StoreRequestQue>>> eComPost(StoreRequestQue store )
        {
            _context.StoreRequestQue.Add(store);
            await _context.SaveChangesAsync();
            //return RedirectToAction("Index");

            return CreatedAtAction(nameof(Get), new {Id  = store.Id}, store);
        }


        [HttpGet("{Id}")]
        public async Task<ActionResult<StoreRequestQue>> Get(int Id)
        {
            if (_context.StoreRequestQue == null)
            {
                return BadRequest();
            }
            var eCom =  await _context.StoreRequestQue.FindAsync(Id);
            if (eCom == null)
            {
                return BadRequest();
            }
            return eCom;
        }

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<WebsiteType>>> Getl()
        //{
        //    if (_context.WebsiteType == null)
        //    {
        //        return BadRequest();
        //    }
        //    return await _context.WebsiteType.ToListAsync();
        //}
    }
}
