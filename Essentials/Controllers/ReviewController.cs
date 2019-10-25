using System.Collections.Generic;
using Essentials.Models;
using Microsoft.AspNetCore.Mvc;

namespace Essentials.Controllers
{
    public class ReviewController : Controller
    {
        [HttpGet]
        public IEnumerable<Review> GetAllReviews()
        {
            return new List<Review>
            {
                new Review
                {
                    Title = "ABC",
                    Description = "A very long description",
                    Rating = 4,
                    Author = "John Doe"
                },
                new Review
                {
                    Title = "XYZ",
                    Description = "Another very long description",
                    Rating = 5,
                    Author = "John Doe"
                }
            };
        }
    }
}