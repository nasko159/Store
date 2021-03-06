﻿using Store.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.RepositoryInterfaces
{
    public interface IProductRepository: IRepository<Product>
    {
        Product GetById(int id);
    }
}
