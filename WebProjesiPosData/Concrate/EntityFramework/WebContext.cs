using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebProjesiDataAccess.Models;

namespace WebProjesiPosData.Concrate.EntityFramework
{
 public   class WebContext: DbContext
    {
        public WebContext() { }
        public WebContext(DbContextOptions<WebContext> options) : base(options) { }


        public DbSet<Place> Places { get; set; }
    }
}
