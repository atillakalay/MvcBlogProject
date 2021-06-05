﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete.Repositories;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
    }
}
