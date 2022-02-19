using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ETradeContext context = new ETradeContext())//ETradeContext very expensive thing
            {
                return context.Products.ToList();
            }
        }

        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext())//ETradeContext very expensive thing
            {
                //context.Products.Add(product);
                var entity = context.Entry(product);
                entity.State = EntityState.Added;
                context.SaveChanges(); // we say to db write
            }
        }
        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())//ETradeContext very expensive thing
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges(); // we say to db write
            }
        }
        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())//ETradeContext very expensive thing
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges(); // we say to db write
            }
        }
    }
}
