﻿using System.Collections.Generic;
using HoneyBadgers._0.Models;

namespace HoneyBadgers._0.BusinessLogic
{
    public interface IReviewLogic
    {
        IEnumerable<Review> GetAll();
        int Add(Review review);
        int Update(Review review);
        Review Details(int id);
        int Delete(int id);
    }
}
