using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnTheWay_Models.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnTheWay_Data.EntityTypeConfigurations.Users
{
    public class UserEntityTipeConfiguration : OnTheWayEntityTypeConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Username)
                    .IsRequired();

            builder.Property(u => u.FirstName)
                    .HasMaxLength(20)
                    .IsRequired();

            builder.Property(u => u.LastName)
                    .HasMaxLength(15)
                    .IsRequired();

            builder.Property(u => u.Email)
                    .IsRequired();

            builder.Property(u => u.Password)
                    .IsRequired();

            builder.Property(u => u.CreatedOnUTC)
                    .IsRequired();

            base.Configure(builder);
        }
    }
}
