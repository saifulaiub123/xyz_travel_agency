﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TA.Domain.Constant;
using TA.Domain.DBModel;

namespace TA.Infrastructure.Configuration
{
    public class OtpConfiguration : IEntityTypeConfiguration<Otp>
    {
        public void Configure(EntityTypeBuilder<Otp> builder)
        {
            builder.Property(x => x.MobileNumber)
                .IsRequired()
                .HasMaxLength(15);
            builder.Property(x => x.VerificationCode)
                .HasMaxLength(6);
            builder.Property(x => x.ExpiredAt)
                .HasColumnType(DbDataType.DateTime)
                .HasMaxLength(250);
            builder.HasIndex(x => x.MobileNumber);
        }
    }
}
