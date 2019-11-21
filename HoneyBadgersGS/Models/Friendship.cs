using System;
using System.Collections.Generic;

namespace HoneyBadgers._0.Models
{
    public partial class Friendship
    {
        public int FriendshipId { get; set; }
        public string? AccountId1 { get; set; }
        public string? AccountId2 { get; set; }

        public virtual Account Account { get; set; }
    }
}
