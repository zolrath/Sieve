﻿using Sieve.Services;
using SieveTests.Entities;
using System.Linq;

namespace SieveTests.Services
{
	public class SieveCustomFilterMethods : ISieveCustomFilterMethods
    {
        public IQueryable<Post> IsNew(IQueryable<Post> source)
            => source.Where(p => p.LikeCount < 100 && p.CommentCount < 5);
    }
}
