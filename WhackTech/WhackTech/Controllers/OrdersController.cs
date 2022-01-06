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
    public class OrdersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrdersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Orders
        [HttpGet("Orders")]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
            return await _context.Orders.ToListAsync();
        }

        // GET: Orders/5
        [HttpGet("Orders/{id}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        // PUT: Orders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("Orders/{id}")]
        public async Task<IActionResult> UpdateOrder(int id, Order order)
        {
            if (id != order.ID)
            {
                return BadRequest();
            }

            var foundOrder = await _context.Orders.FindAsync(id);
            if (foundOrder == null)
            {
                return NotFound();
            }

            //foundOrder.ApplicationUserID = order.ApplicationUserID;
            foundOrder.PaymentMethodID = order.PaymentMethodID;
            foundOrder.TotalPrice = order.TotalPrice;

            //foundOrder.ApplicationUser = order.ApplicationUser;
            foundOrder.Items = order.Items;
            foundOrder.PaymentMethod = order.PaymentMethod;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!OrderExists(id))
            {
                return NotFound();
            }

            return NoContent();
        }

        // POST: Orders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("Orders/")]
        public async Task<ActionResult<Order>> CreateOrder( Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(Order),
                new { id = order.ID },
                order);
        }

        // DELETE: Orders/5
        [HttpDelete("Orders/{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.ID == id);
        }
    }
}
