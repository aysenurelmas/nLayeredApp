﻿using Core.DataAccess.Repositories;
using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete;

public class EfCategoryDal : EfRepositoryBase<Category, int, NorthwindContext>, ICategoryDal
{
    public EfCategoryDal(NorthwindContext context) : base(context)
    {
    }
}
