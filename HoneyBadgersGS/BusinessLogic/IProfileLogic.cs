using System.Collections.Generic;
using HoneyBadgers._0.Models;

namespace HoneyBadgers._0.BusinessLogic
{
    public interface IProfileLogic
    {
        IEnumerable<Profile> GetAll();
        int Add(Profile profile);
        int Update(Profile profile);
        Profile Details(int id);
        int Delete(int id);
    }
}