﻿using System.Collections.Generic;
using HoneyBadgers._0.Models;

namespace HoneyBadgers._0.DataLayers
{
    public interface IReviewDal
    {
        IEnumerable<Review> GetAll();
        int Add(Review review);
        int Update(Review review);
        Review GetData(int id);
        int Delete(int id);
    }
}
