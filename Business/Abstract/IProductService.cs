﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IProductService
    {
        public List<Product> GetAll();
       void Add(Product product);
        void Delete(Product product);
        void Uptade(Product product);
        
    }
}
