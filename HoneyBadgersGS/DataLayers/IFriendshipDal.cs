using System.Collections.Generic;
using HoneyBadgers._0.Models;

namespace HoneyBadgers._0.DataLayers
{
    public interface IFriendshipDal
    {
        IEnumerable<Friendship> GetAll();
        int Add(Friendship friend);
        int Update(Friendship friend);
        Friendship GetData(int id);
        int Delete(int id);
    }
}