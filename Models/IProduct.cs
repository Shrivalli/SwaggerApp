using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerEg.Models
{
   public interface IProduct
    {
        void addproduct(Product p);
        IQueryable<Product> delproduct(int id);
        Product updateproduct(int id, Product p);
        List<Product> retrieveproducts();
        IQueryable<Product> retrieveProductByID(int id);
    }

  public  class Prd : IProduct
    {
        OrganizationContext _context=new OrganizationContext();
        public Prd(OrganizationContext context)
        {
            _context = context;
        }
        
        public void addproduct(Product product)
        {
            _context.Product.Add(product);
            _context.SaveChanges();
            
        }

        public IQueryable<Product> delproduct(int id)
        {
            IQueryable<Product> product = _context.Product.Where(p => p.Id == id);
            _context.Product.Remove(product.FirstOrDefault());
            _context.SaveChangesAsync();
            return product;
        }

        public IQueryable<Product> retrieveProductByID(int id)
        {
            return (_context.Product.Where(p => p.Id == id));
        }

        public List<Product> retrieveproducts()
        {
            return _context.Product.ToList();
        }

        public Product updateproduct(int id, Product product)
        {
           _context.Entry(product).State = EntityState.Modified;

            _context.SaveChanges();
            return product;
        }
    }
}
