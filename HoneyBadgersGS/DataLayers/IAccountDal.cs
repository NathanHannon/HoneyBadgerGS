using System.Collections.Generic;
using HoneyBadgers._0.Models;

namespace HoneyBadgers._0.DataLayers
{
    public interface IAccountDal
    {
         IEnumerable<AspNetUsers> GetAll();
         int Add(AspNetUsers account);
         int Update(AspNetUsers account);
         AspNetUsers GetData(string id);
         int Delete(string id);
    }
}