using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyntraApi.Data.Models;

namespace MyntraApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IMyntra myntra;

        public HomeController(IMyntra myntra)
        {
            this.myntra = myntra;
        }


        [HttpGet]
        public IActionResult GetGender()
        {
            return new JsonResult(myntra.GetGender());
        }

        [HttpGet]

        [Route("Category")]
        public IActionResult GetCategory()
        {
            return new JsonResult(myntra.GetCategories());
        }


        [HttpGet]
        [Route("{id}")]
        public IActionResult GetSubCategory(int id)
        {
            return new JsonResult(myntra.GetSubCategories(id));
        }

        [HttpGet]
        [Route("{id}/{catId}")]
        public IActionResult GetProducts(int id, int catId)
        {
            return new JsonResult(myntra.GetProducts(id,catId));
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetProductById(int id)
        {
            return new JsonResult(myntra.GetProducts(id, 1));
        }

        [HttpGet]
        [Route("{name}")]
        public IActionResult GetProductByName(string name)
        {
            return new JsonResult("Product");
        }

    }
}
