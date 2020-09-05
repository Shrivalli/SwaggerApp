using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SwaggerEg.Models;

namespace SwaggerEg.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        
        private readonly IProduct obj;
        
        public ProductsController(Prd prd)
        {
            obj = prd;   
        }
        // GET: api/Products
        [HttpGet]
        public  IActionResult GetProduct()
        {
            return Ok(obj.retrieveproducts());
            
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public  IActionResult GetProduct(int id)
        {
            IQueryable<Product> product =(IQueryable<Product>) obj.retrieveProductByID(id);

            if (product.Count() == 0)
            {
                return BadRequest();
            }

            return Ok(product);
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public  IActionResult PutProduct(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }
            try
            {
                obj.updateproduct(id, product);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
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
        

        // POST: api/Products
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public ActionResult<Product> PostProduct(Product product)
        {
            try
            {
                obj.addproduct(product);
            }
            catch (DbUpdateException)
            {
                if (ProductExists(product.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProduct", new { id = product.Id }, product);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            IQueryable<Product> product = (IQueryable<Product>)obj.delproduct(id);
            if (product.Count() == 0)
            {
                return BadRequest();
            }
           

            return Ok(product);
        }

        private bool ProductExists(int id)
        {
            var prd= obj.retrieveProductByID(id).FirstOrDefault();
            if (prd != null)
            {
                return true;
            }
            else
                return false;
            
        }
    }
}
