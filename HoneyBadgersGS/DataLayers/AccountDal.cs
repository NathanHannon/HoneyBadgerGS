using System.Collections.Generic;
using System.Linq;
using HoneyBadgers._0.Models;
using Microsoft.EntityFrameworkCore;

namespace HoneyBadgers._0.DataLayers
{
    public class AccountDal : IAccountDal
    {
        private HoneyBadgerDBContext _db;

        public AccountDal(HoneyBadgerDBContext db)
        {
            _db = db;
        }
        
        public IEnumerable<AspNetUsers> GetAll()
        {
            return _db.AspNetUsers.ToList();
        }
        public int Add(AspNetUsers account)
        {
            _db.AspNetUsers.Add(account);
            _db.SaveChangesAsync();
            return 1;
        }

        public int Update(AspNetUsers account)
        {
            _db.AspNetUsers.Update(account);
            _db.SaveChangesAsync();
            return 1;
        }

        public AspNetUsers GetData(string id)
        {
            AspNetUsers account = _db.AspNetUsers.Find(id);
            return account;
        }

        public int Delete(string id)
        {
            AspNetUsers account = _db.AspNetUsers.Find(id);
            _db.AspNetUsers.Remove(account);
            _db.SaveChangesAsync();
            return 1;
        }
        //TODO: ADD rest of functions based on https://dzone.com/articles/aspnet-core-crud-with-reactjs-and-entity-framework
    }
}