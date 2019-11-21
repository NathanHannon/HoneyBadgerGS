using System.Collections.Generic;
using HoneyBadgers._0.Models;

namespace HoneyBadgers._0.BusinessLogic
{
    public interface IAccountLogic
    {
        IEnumerable<AspNetUsers> GetAll();
        int Add(AspNetUsers account);
        int Update(AspNetUsers account);
        AspNetUsers Details(string id);
        int Delete(string id);
    }
}
