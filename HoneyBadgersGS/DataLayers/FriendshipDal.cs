using System.Collections.Generic;
using System.Linq;
using HoneyBadgers._0.Models;

namespace HoneyBadgers._0.DataLayers
{
    public class FriendshipDal : IFriendshipDal
    {
        private HoneyBadgerDBContext _db;

        public FriendshipDal(HoneyBadgerDBContext db)
        {
            _db = db;
        }

        public IEnumerable<Friendship> GetAll()
        {
            return _db.Friendship.ToList();
        }

        public int Add(Friendship friendship)
        {
            _db.Friendship.Add(friendship);
            _db.SaveChangesAsync();
            return 1;
        }

        public int Update(Friendship friendship)
        {
            _db.Friendship.Update(friendship);
            _db.SaveChangesAsync();
            return 1;
        }

        public Friendship GetData(int id)
        {
            Friendship friendship = _db.Friendship.Find(id);

            //if the object is null, just return an empty object
            if (friendship == null)
            {
                friendship = new Friendship();
            }
            return friendship;
        }

        public int Delete(int id)
        {
            Friendship friendship = _db.Friendship.Find(id);
            _db.Friendship.Remove(friendship);
            _db.SaveChangesAsync();
            return 1;
        }
    }
}