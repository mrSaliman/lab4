using lab4.Data;
using Microsoft.AspNetCore.Mvc;

namespace lab4.Controllers;

public class CustomerController : Controller
{
    private readonly AcmeDataContext _context;

    public CustomerController(AcmeDataContext context)
    {
        _context = context;
    }

    [ResponseCache(CacheProfileName = "ModelCache")]
    public IActionResult ShowCustomers()
    {
        return View(_context.Customers);
    }
}