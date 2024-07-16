using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Food.Models;
using Food.Services.Services_Dish;
using Food.Aspects;
using Microsoft.AspNetCore.Cors;



namespace Food.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("policy")]
    [ApiController]
    [ExceptionHandler]
    public class DishController : ControllerBase
    {
        private readonly IDishService service;

        public DishController(IDishService service)
        {
            this.service = service;
        }

        // GET: api/Dishes
        [HttpGet]

        public IActionResult Get()
        {
            return Ok(service.GetDish());
        }

     
        // PATCH: api/Dishes/5/toggle-publish

        [HttpPatch]
        [Route("{id}/toggle-publish")]
        public IActionResult TogglePublishStatus(int id)
        {
            var updateDish = service.TogglePublishStatus(id);
            return Ok(updateDish);
        }


    }
}
