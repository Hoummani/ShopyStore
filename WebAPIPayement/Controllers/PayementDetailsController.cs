using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using WebAPIPayement.Models;

namespace WebAPIPayement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PayementDetailsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PayementDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Get:api/payementDeatails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PayementDetail>>> GetAllPayement()
        {
            return await _context.PayementDetails.ToListAsync();
        }

        //GET:api/payementDetail/id

        [HttpGet("{id}")]
        public async Task<ActionResult<PayementDetail>> GetPayementDetail(int id)
        {
            var payementDetail = await _context.PayementDetails.FindAsync(id);
            if (payementDetail == null)
            {
                return NotFound();
            }

            return payementDetail;
        }

        //PUT :api/payemenDetails/id
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPayementDetail(int id, PayementDetail payementDetail)
        {
            if (id != payementDetail.Id)
            {
                return BadRequest();
            }

            _context.Entry(payementDetail).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PayementDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }


            }

            return NoContent();
        }
        
        // POST: api/PaymentDetail
        [HttpPost]
        public async Task<ActionResult<PayementDetail>> PostPaymentDetail(PayementDetail paymentDetail)
        {
            _context.PayementDetails.Add(paymentDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPayementDetail",new { id = paymentDetail.Id }, paymentDetail);
        }
        
        
        // DELETE: api/PaymentDetail/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PayementDetail>> DeletePaymentDetail(int id)
        {
            var paymentDetail = await _context.PayementDetails.FindAsync(id);
            if (paymentDetail == null)
            {
                return NotFound();
            }

            _context.PayementDetails.Remove(paymentDetail);
            await _context.SaveChangesAsync();

            return paymentDetail;
        }

        
        //test existence
        private bool PayementDetailExists(int id)
        {
            return _context.PayementDetails.Any(e => e.Id ==id);
        }
    }
}




