using System.Collections.Generic;
using HoneyBadgers._0.Models;

namespace HoneyBadgers._0.BusinessLogic
{
    public interface IFriendshipLogic
    {
        IEnumerable<Friendship> GetAll();
        int Add(Friendship friendship);
        int Update(Friendship friendship);
        Friendship Details(int id);
        int Delete(int id);
    }
}