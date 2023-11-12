using lab4.Data;
using Microsoft.AspNetCore.Mvc;

namespace lab4.Controllers;

public class EmployeeController : Controller
{
    private readonly AcmeDataContext _context;

    public EmployeeController(AcmeDataContext context)
    {
        _context = context;
    }

    [ResponseCache(CacheProfileName = "ModelCache")]
    public IActionResult ShowEmployees()
    {
        return View(_context.Employees);
    }
}