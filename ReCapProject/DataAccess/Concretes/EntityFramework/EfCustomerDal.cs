﻿using Core.DataAccess.Concretes.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCustomerDal:BaseEntityFrameworkRepsitory<Customer,ReCapProjectDatabaseContext>,ICustomerDal
    {
    }
}