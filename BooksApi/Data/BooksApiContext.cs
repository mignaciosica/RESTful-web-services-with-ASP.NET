using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BooksApi.Models;

namespace BooksApi.Data
{
    public class BooksApiContext : DbContext
    {
        public BooksApiContext (DbContextOptions<BooksApiContext> options)
            : base(options)
        {
        }

        public DbSet<BooksApi.Models.Asset> Asset { get; set; }
    }
}
