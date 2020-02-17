using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnTheWay_Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<OnTheWayDbContext>
    {
        public OnTheWayDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<OnTheWayDbContext>();

            builder.UseSqlServer("Data Source=DESKTOP-S3RA57L;Initial Catalog=onTheWay;Integrated Security=true;", 
                                    opt => opt.MigrationsAssembly("OnTheWay_Migrations"));

            return new OnTheWayDbContext(builder.Options);
        }
    }
}
