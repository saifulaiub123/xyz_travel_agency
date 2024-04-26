using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TA.Domain.Constant;
using TA.Domain.DBModel;

namespace TA.Infrastructure.Configuration
{
    public class ApplicationLogConfiguration : IEntityTypeConfiguration<ApplicationLog>
    {
        public void Configure(EntityTypeBuilder<ApplicationLog> builder)
        {
            builder.Property(x => x.MessageTemplate)
                .IsRequired(false);
            builder.Property(x => x.Exception)
                .IsRequired(false);
            builder.Property(x => x.Properties)
                .IsRequired(false);
            builder.Property(x => x.LogEvent)
                .IsRequired(false);
            builder.Property(x => x.Level)
                .HasMaxLength(128);
            builder.Property(x => x.TimeStamp)
                .HasColumnType(DbDataType.DateTime)
                .HasMaxLength(250);
            builder.Property(x => x.Properties)
                .HasColumnType(DbDataType.Xml);
        }
    }
}
