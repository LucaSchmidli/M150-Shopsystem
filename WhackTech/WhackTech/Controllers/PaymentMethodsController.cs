using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhackTech.Data;
using WhackTech.Models;

namespace WhackTech.Controllers
{
    public class PaymentMethodsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PaymentMethodsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PaymentMethods
        [HttpGet("PaymentMethods")]
        public async Task<ActionResult<IEnumerable<PaymentMethod>>> GetPaymentMethods()
        {
            return await _context.PaymentMethods.ToListAsync();
        }

        // GET: PaymentMethods/5
        [HttpGet("PaymentMethods/{id}")]
        public async Task<ActionResult<PaymentMethod>> GetPaymentMethod(int id)
        {
            var paymentMethod = await _context.PaymentMethods.FindAsync(id);

            if (paymentMethod == null)
            {
                return NotFound();
            }

            return paymentMethod;
        }

        // PUT: PaymentMethods/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("PaymentMethods/{id}")]
        public async Task<IActionResult> UpdatePaymentMethod(int id, PaymentMethod paymentMethod)
        {
            if (id != paymentMethod.ID)
            {
                return BadRequest();
            }

            var foundPaymentMethod = await _context.PaymentMethods.FindAsync(id);
            if (foundPaymentMethod == null)
            {
                return NotFound();
            }

            foundPaymentMethod.Name = paymentMethod.Name;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!PaymentMethodExists(id))
            {
                return NotFound();
            }

            return NoContent();
        }

        // POST: PaymentMethods
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("PaymentMethods/")]
        public async Task<ActionResult<PaymentMethod>> CreatePaymentMethod(PaymentMethod paymentMethod)
        {
            _context.PaymentMethods.Add(paymentMethod);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(paymentMethod),
                new { id = paymentMethod.ID },
                paymentMethod);
        }

        // DELETE: PaymentMethods/5
        [HttpDelete("PaymentMethods/{id}")]
        public async Task<IActionResult> DeletePaymentMethod(int id)
        {
            var paymentMethod = await _context.PaymentMethods.FindAsync(id);

            if (paymentMethod == null)
            {
                return NotFound();
            }

            _context.PaymentMethods.Remove(paymentMethod);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PaymentMethodExists(int id)
        {
            return _context.PaymentMethods.Any(e => e.ID == id);
        }
    }
}
