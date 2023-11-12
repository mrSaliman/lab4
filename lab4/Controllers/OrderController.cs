using lab4.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace lab4.Controllers;

public class OrderController : Controller
{
    private readonly AcmeDataContext _context;

    public OrderController(AcmeDataContext context)
    {
        _context = context;
    }

    [ResponseCache(CacheProfileName = "ModelCache")]
    public IActionResult ShowOrders()
    {
        return View(_context.Orders.Include(o => o.Customer).Include(o => o.ResponsibleEmployee));
    }
}