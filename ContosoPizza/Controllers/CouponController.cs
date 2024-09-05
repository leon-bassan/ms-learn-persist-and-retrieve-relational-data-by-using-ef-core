using ContosoPizza.Data;
using ContosoPizza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class CouponController : ControllerBase
{
    PromotionsContext _context;

    public CouponController(PromotionsContext context)
    {
        // this implementation directly use the dbcontext instead than a service (repository) class as in PizzaController
        _context = context;
    }

    [HttpGet]
    public IEnumerable<Coupon> Get()
    {
        return _context.Coupons
            .AsNoTracking()
            .ToList();
    }
}