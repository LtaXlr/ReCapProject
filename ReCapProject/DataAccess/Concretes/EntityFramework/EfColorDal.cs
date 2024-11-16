using Core.DataAccess.Abstracts;
using Core.DataAccess.Concretes.EntityFramework;
using Core.Entities.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfColorDal:BaseEntityFrameworkRepsitory<Color,ReCapProjectDatabaseContext>,IColorDal
    {

    }
}
