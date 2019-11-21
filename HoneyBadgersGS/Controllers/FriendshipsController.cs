using System.Collections.Generic;
using HoneyBadgers._0.BusinessLogic;
using HoneyBadgers._0.Models;
using Microsoft.AspNetCore.Mvc;

namespace HoneyBadgers._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendshipsController : ControllerBase
    {
        private IFriendshipLogic _friendshipLogic;

        public FriendshipsController(IFriendshipLogic friendshipLogic)
        {
            _friendshipLogic = friendshipLogic;
        }

        [HttpGet("getfriendships")]
        [Route("api/Friendships")]
        public IEnumerable<Friendship> GetAllFriendships()
        {
            return _friendshipLogic.GetAll();
        }
        
        //TODO: Convert everything below this comment and remove DB context.
        
        //Add Single Friendship to Record
        [HttpPost]
        [Route("api/Friendships/Add")]
        public int Add(Friendship friendship)
        {
            return _friendshipLogic.Add(friendship);
        }

        //Updates Friendships in record
        [HttpPut]
        [Route("api/Friendships/Update")]
        public int Update(Friendship friendship)
        {
            return _friendshipLogic.Update(friendship);
        }

        //Get Single Friendship Details
        [HttpGet("getfriendships/{id}")]
        [Route("api/Friendships/Details/{id}")]
        public Friendship Details(int id)
        {
            return _friendshipLogic.Details(id);
        }

        //Delete friendship from records
        [HttpDelete]
        [Route("api/Friendships/Delete")]
        public int Delete(int id)
        {
            return _friendshipLogic.Delete(id);
        }
    }
}
