﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TA.Domain.DBModel;

namespace TA.Infrastructure.Configuration
{
    public class UserStatusConfiguration : IEntityTypeConfiguration<UserStatus>
    {
        public void Configure(EntityTypeBuilder<UserStatus> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.Name)
                .HasMaxLength(20)
                .IsRequired();
        }
    }
}
