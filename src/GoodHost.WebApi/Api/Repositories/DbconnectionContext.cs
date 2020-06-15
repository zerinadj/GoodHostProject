using GoodHost.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;

using System.Collections.Generic;


using System.Linq;

using System.Web;


namespace GoodHost.Api.Repositories

{

    public class DbconnectionContext : DbContext

    {

        public DbconnectionContext() : base()

        {

        }

        public DbSet<Comment> Comment { get; set; }

    }

}