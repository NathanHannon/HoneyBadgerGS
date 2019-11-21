<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
=======
﻿using System.Collections.Generic;
>>>>>>> Sprint-3
using HoneyBadgers._0.BusinessLogic;
using HoneyBadgers._0.Models;
using Microsoft.AspNetCore.Mvc;

namespace HoneyBadgers._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private IReviewLogic _reviewLogic;

        public ReviewsController(IReviewLogic reviewLogic)
        {
            _reviewLogic = reviewLogic;
        }

        // GET: api/Reviews
        [HttpGet("getreviews")]
        [Route("api/Reviews")]
        public IEnumerable<Review> GetAllReviews()
        {
            return _reviewLogic.GetAll();
        }
        //Add Single Review to Record
        [HttpPost]
        public int Add([FromBody] Review review)
        {
				return _reviewLogic.Add(review);
        }

        //Updates Games in record
        [HttpPut]
        [Route("api/Reviews/Update")]
        public int Update(Review review)
        {
            return _reviewLogic.Update(review);
        }

        //Get Single Review Details
        [HttpGet("getreviews/{id}")]
        [Route("api/Reviews/Details/{id}")]
        public Review Details(int id)
        {
            return _reviewLogic.Details(id);
        }

        //Delete Review from records
        [HttpDelete]
        [Route("api/Reviews/Delete")]
        public int Delete(int id)
        {
            return _reviewLogic.Delete(id);
        }
    }
}
