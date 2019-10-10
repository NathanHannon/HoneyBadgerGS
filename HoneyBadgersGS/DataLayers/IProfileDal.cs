using System.Collections.Generic;
using HoneyBadgers._0.Models;

namespace HoneyBadgers._0.DataLayers
{
    public interface IProfileDal
    {
        IEnumerable<Profile> GetAll();
        int Add(Profile profile);
        int Update(Profile profile);
        Profile GetData(int id);
        int Delete(int id);
    }
}