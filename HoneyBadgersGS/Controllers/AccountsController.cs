using System.Collections.Generic;
using HoneyBadgers._0.BusinessLogic;
using HoneyBadgers._0.Models;
using Microsoft.AspNetCore.Mvc;

namespace HoneyBadgers._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private IAccountLogic _accountsLogic;

        public AccountsController(IAccountLogic accountsLogic)
        {
            _accountsLogic = accountsLogic;
        }

        [HttpGet("getaccounts")]
        [Route("api/Accounts")]
        public IEnumerable<AspNetUsers> GetAllAccounts()
        {
            return _accountsLogic.GetAll();
        }

        //TODO: Convert everything below this comment and remove DB context.

        //Add Single Game to Record
        [HttpPost]
        [Route("api/Accounts/Add")]
        public int Add(AspNetUsers account)
        {
            return _accountsLogic.Add(account);
        }

        //Updates Games in record
        [HttpPut]
        [Route("api/Accounts/Update")]
        public int Update(AspNetUsers account)
        {
            return _accountsLogic.Update(account);
        }

        //Get Single Game Details
        [HttpGet("getaccounts/{id}")]
        [Route("api/Accounts/Details/{id}")]
        public AspNetUsers Details(string id)
        {
            return _accountsLogic.Details(id);
        }

        //Delete game from records
        [HttpDelete]
        [Route("api/Games/Delete")]
        public int Delete(string id)
        {
            return _accountsLogic.Delete(id);
        }
    }
}