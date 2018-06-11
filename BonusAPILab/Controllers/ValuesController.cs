using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BonusAPILab.Models;

namespace BonusAPILab.Controllers
{
    public class ValuesController : ApiController
    {
        NORTHWNDEntities db = new NORTHWNDEntities();

        public List<string> GetProductID()
        {
            List<Products> prod = db.Products1.ToList();
            List<string> product = new List<string>();

            for (int i = 0; i < prod.Count; i++)
            {
                product.Add(prod[i].ProductID.ToString());
                product.Add(prod[i].ProductName);
            }

            return product;
        }

        public Products GetProd(int id)
        {
            List<Products> prod = db.Products1.ToList();
            Products p = (from i in db.Products1
                          where i.ProductID == id
                          select i).Single();
            return p;

        }
    }
}
