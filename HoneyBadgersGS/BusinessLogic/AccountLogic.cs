using System.Collections.Generic;
using HoneyBadgers._0.DataLayers;
using HoneyBadgers._0.Models;

namespace HoneyBadgers._0.BusinessLogic
{
    public class AccountLogic : IAccountLogic
    {
        private IAccountDal _accountDal;

        public AccountLogic(IAccountDal accountDal)
        {
            _accountDal = accountDal;
        }
        
        public IEnumerable<AspNetUsers> GetAll()
        {
            return _accountDal.GetAll();
        }

        public int Add(AspNetUsers account)
        {
            return _accountDal.Add(account);
        }

        public int Update(AspNetUsers account)
        {
            return _accountDal.Update(account);
        }

        public AspNetUsers Details(string id)
        {
            return _accountDal.GetData(id);
        }
        public int Delete(string id)
        {
            return _accountDal.Delete(id);
        }
    }
}