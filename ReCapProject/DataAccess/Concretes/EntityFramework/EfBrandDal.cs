using Core.DataAccess.Abstracts;
using Core.DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfBrandDal : BaseEntityFrameworkRepsitory<Brand, ReCapProjectDatabaseContext>, IEntityRepository<Brand>
    {
    }
}
