using System;
using System.Collections.Generic;

namespace HoneyBadgers._0.Models
{
    public partial class Account
    {
        public Account()
        {
            Cart = new HashSet<Cart>();
            Event = new HashSet<Event>();
            Friendship = new HashSet<Friendship>();
            Review = new HashSet<Review>();
            Sales = new HashSet<Sales>();
            Wishlist = new HashSet<Wishlist>();
        }

        public string AccountId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string ProfileId { get; set; }
        public int? LibraryId { get; set; }

        public virtual Profile Profile { get; set; }
        public virtual ICollection<Cart> Cart { get; set; }
        public virtual ICollection<Event> Event { get; set; }
        public virtual ICollection<Friendship> Friendship { get; set; }
        public virtual ICollection<Review> Review { get; set; }
        public virtual ICollection<Sales> Sales { get; set; }
        public virtual ICollection<Wishlist> Wishlist { get; set; }
    }
}
